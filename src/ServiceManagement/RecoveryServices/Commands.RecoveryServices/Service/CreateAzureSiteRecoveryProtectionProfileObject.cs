﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using Microsoft.Azure.Commands.RecoveryServices.SiteRecovery;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;
using Microsoft.WindowsAzure.Management.Storage.Models;

namespace Microsoft.Azure.Commands.RecoveryServices
{
    /// <summary>
    /// Creates Azure Site Recovery Protection Profile object in memory.
    /// </summary>
    [Cmdlet(VerbsCommon.New, "AzureSiteRecoveryProtectionProfile", DefaultParameterSetName = ASRParameterSets.Default)]
    [OutputType(typeof(ASRProtectionProfile))]
    public class CreateAzureSiteRecoveryProtectionProfileObject : RecoveryServicesCmdletBase
    {
        #region Parameters

        /// <summary>
        /// Gets or sets Replication Type of the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            "HyperVReplica",
            "HyperVReplicaAzure")]
        public string ReplicationType { get; set; }

        /// <summary>
        /// Gets or sets Replication Method of the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            "Online",
            "Offline")]
        public string ReplicationMethod { get; set; }

        /// <summary>
        /// Gets or sets Recovery Protection Container of the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public ProtectionContainer RecoveryProtectionContainer { get; set; }

        /// <summary>
        /// Gets or sets Recovery Azure Subscription of the Protection Profile for E2A scenarios.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.EnterpriseToAzure, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string RecoveryAzureSubscription { get; set; }

        /// <summary>
        /// Gets or sets Recovery Azure Storage Account Name of the Protection Profile for E2A scenarios.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.EnterpriseToAzure, Mandatory = true, ValueFromPipeline = true)]
        [ValidateNotNullOrEmpty]
        public string RecoveryAzureStorageAccount { get; set; }

        /// <summary>
        /// Gets or sets Replication Frequency of the Protection Profile in seconds.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public int ReplicationFrequencySecond { get; set; }

        /// <summary>
        /// Gets or sets Recovery Points of the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public int RecoveryPoints { get; set; }

        /// <summary>
        /// Gets or sets Application Consistent Snapshot Frequency of the Protection Profile in hours.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public int ApplicationConsistentSnapshotFrequencyInHours { get; set; }

        /// <summary>
        /// Gets or sets if Compression needs to be Enabled on the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public bool CompressionEnabled { get; set; }

        /// <summary>
        /// Gets or sets the Replication Port of the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public int ReplicationPort { get; set; }

        /// <summary>
        /// Gets or sets Replication Start time of the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public int ReplicationStartTime { get; set; }

        /// <summary>
        /// Gets or sets the boolean value indicating Replica Deletion on disabling protection
        /// on a protection entity protected by the Protection Profile.
        /// </summary>
        [Parameter(ParameterSetName = ASRParameterSets.Default, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public bool AllowReplicaDeletion { get; set; }

        #endregion Parameters

        /// <summary>
        /// ProcessRecord of the command.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            try
            {
                switch (this.ReplicationType)
                {
                    case "HyperVReplica":
                        EnterpriseToEnterpriseProtectionProfileObject();
                        break;
                    case "HyperVReplicaAzure":
                        EnterpriseToAzureProtectionProfileObject();
                        break;
                }
            }
            catch (Exception exception)
            {
                this.HandleException(exception);
            }
        }

        private void EnterpriseToAzureProtectionProfileObject()
        {
            // Verify whether the storage account is associated with the account or not.
            PSRecoveryServicesClientHelper.ValidateStorageAccountAssociation(this.RecoveryAzureStorageAccount);

            // Verify whether the subscription is associated with the account or not.
            PSRecoveryServicesClientHelper.ValidateSubscriptionAccountAssociation(this.RecoveryAzureSubscription);

            ASRProtectionProfile protectionProfile = new ASRProtectionProfile()
            {
                ReplicationType = this.ReplicationType,
                ReplicationMethod = this.ReplicationMethod,
                RecoveryProtectionContainer = this.RecoveryProtectionContainer,
                RecoveryAzureSubscription = this.RecoveryAzureSubscription,
                RecoveryAzureStorageAccountName = this.RecoveryAzureStorageAccount,
                ReplicationFrequencySecond = this.ReplicationFrequencySecond,
                RecoveryPoints = this.RecoveryPoints,
                ApplicationConsistentSnapshotFrequencyInHours = this.ApplicationConsistentSnapshotFrequencyInHours,
                CompressionEnabled = this.CompressionEnabled,
                ReplicationPort = this.ReplicationPort,
                ReplicationStartTime = this.ReplicationStartTime,
                AllowReplicaDeletion = this.AllowReplicaDeletion
            };

            this.WriteObject(protectionProfile);
        }

        private void EnterpriseToEnterpriseProtectionProfileObject()
        {
            ASRProtectionProfile protectionProfile = new ASRProtectionProfile()
            {
                ReplicationType = this.ReplicationType,
                ReplicationMethod = this.ReplicationMethod,
                RecoveryProtectionContainer = this.RecoveryProtectionContainer,
                RecoveryAzureSubscription = null,
                RecoveryAzureStorageAccountName = null,
                ReplicationFrequencySecond = this.ReplicationFrequencySecond,
                RecoveryPoints = this.RecoveryPoints,
                ApplicationConsistentSnapshotFrequencyInHours = this.ApplicationConsistentSnapshotFrequencyInHours,
                CompressionEnabled = this.CompressionEnabled,
                ReplicationPort = this.ReplicationPort,
                ReplicationStartTime = this.ReplicationStartTime,
                AllowReplicaDeletion = this.AllowReplicaDeletion
            };

            this.WriteObject(protectionProfile);
        }

        /// <summary>
        /// Handles interrupts.
        /// </summary>
        protected override void StopProcessing()
        {
            // Ctrl + C and etc
            base.StopProcessing();
            this.StopProcessingFlag = true;
        }
    }
}
