// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515
{
    using Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.PowerShell;

    /// <summary>
    /// Parameters supplied to the Create or Update Environment operation for a Gen2 environment.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Gen2EnvironmentCreateOrUpdateParametersTypeConverter))]
    public partial class Gen2EnvironmentCreateOrUpdateParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Gen2EnvironmentCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Gen2EnvironmentCreateOrUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Gen2EnvironmentCreateOrUpdateParameters" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="Gen2EnvironmentCreateOrUpdateParameters" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Gen2EnvironmentCreateOrUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentCreationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.CreateOrUpdateTrackedResourcePropertiesTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName.CreateFrom);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity = (int) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.Kind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.Kind.CreateFrom);
            }
            if (content.Contains("StorageConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2StorageConfigurationInput) content.GetValueForProperty("StorageConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2StorageConfigurationInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("WarmStoreConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoreConfigurationProperties) content.GetValueForProperty("WarmStoreConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoreConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("TimeSeriesIdProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).TimeSeriesIdProperty = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[]) content.GetValueForProperty("TimeSeriesIdProperty",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).TimeSeriesIdProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.TimeSeriesIdPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("StorageConfigurationAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationAccountName = (string) content.GetValueForProperty("StorageConfigurationAccountName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageConfigurationManagementKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationManagementKey = (string) content.GetValueForProperty("StorageConfigurationManagementKey",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationManagementKey, global::System.Convert.ToString);
            }
            if (content.Contains("WarmStoreConfigurationDataRetention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfigurationDataRetention = (global::System.TimeSpan) content.GetValueForProperty("WarmStoreConfigurationDataRetention",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfigurationDataRetention, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentCreateOrUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Gen2EnvironmentCreateOrUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreationProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2EnvironmentCreationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ICreateOrUpdateTrackedResourcePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.CreateOrUpdateTrackedResourcePropertiesTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuName, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.SkuName.CreateFrom);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity = (int) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.SkuTypeConverter.ConvertFrom);
            }
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Kind = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.Kind) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IEnvironmentCreateOrUpdateParametersInternal)this).Kind, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Support.Kind.CreateFrom);
            }
            if (content.Contains("StorageConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2StorageConfigurationInput) content.GetValueForProperty("StorageConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.Gen2StorageConfigurationInputTypeConverter.ConvertFrom);
            }
            if (content.Contains("WarmStoreConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IWarmStoreConfigurationProperties) content.GetValueForProperty("WarmStoreConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfiguration, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.WarmStoreConfigurationPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("TimeSeriesIdProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).TimeSeriesIdProperty = (Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty[]) content.GetValueForProperty("TimeSeriesIdProperty",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).TimeSeriesIdProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.ITimeSeriesIdProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.TimeSeriesIdPropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("StorageConfigurationAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationAccountName = (string) content.GetValueForProperty("StorageConfigurationAccountName",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageConfigurationManagementKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationManagementKey = (string) content.GetValueForProperty("StorageConfigurationManagementKey",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).StorageConfigurationManagementKey, global::System.Convert.ToString);
            }
            if (content.Contains("WarmStoreConfigurationDataRetention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfigurationDataRetention = (global::System.TimeSpan) content.GetValueForProperty("WarmStoreConfigurationDataRetention",((Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Models.Api20200515.IGen2EnvironmentCreateOrUpdateParametersInternal)this).WarmStoreConfigurationDataRetention, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.TimeSeriesInsights.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Parameters supplied to the Create or Update Environment operation for a Gen2 environment.
    [System.ComponentModel.TypeConverter(typeof(Gen2EnvironmentCreateOrUpdateParametersTypeConverter))]
    public partial interface IGen2EnvironmentCreateOrUpdateParameters

    {

    }
}