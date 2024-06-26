// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The information about next hop from the specified VM.
    /// </summary>
    public partial class NextHopResult
    {
        /// <summary>
        /// Initializes a new instance of the NextHopResult class.
        /// </summary>
        public NextHopResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NextHopResult class.
        /// </summary>

        /// <param name="nextHopType">Next hop type.
        /// Possible values include: &#39;Internet&#39;, &#39;VirtualAppliance&#39;,
        /// &#39;VirtualNetworkGateway&#39;, &#39;VnetLocal&#39;, &#39;HyperNetGateway&#39;, &#39;None&#39;</param>

        /// <param name="nextHopIPAddress">Next hop IP Address.
        /// </param>

        /// <param name="routeTableId">The resource identifier for the route table associated with the route being
        /// returned. If the route being returned does not correspond to any user
        /// created routes then this field will be the string &#39;System Route&#39;.
        /// </param>
        public NextHopResult(string nextHopType = default(string), string nextHopIPAddress = default(string), string routeTableId = default(string))

        {
            this.NextHopType = nextHopType;
            this.NextHopIPAddress = nextHopIPAddress;
            this.RouteTableId = routeTableId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets next hop type. Possible values include: &#39;Internet&#39;, &#39;VirtualAppliance&#39;, &#39;VirtualNetworkGateway&#39;, &#39;VnetLocal&#39;, &#39;HyperNetGateway&#39;, &#39;None&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType {get; set; }

        /// <summary>
        /// Gets or sets next hop IP Address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextHopIpAddress")]
        public string NextHopIPAddress {get; set; }

        /// <summary>
        /// Gets or sets the resource identifier for the route table associated with
        /// the route being returned. If the route being returned does not correspond
        /// to any user created routes then this field will be the string &#39;System
        /// Route&#39;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId {get; set; }
    }
}