// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BgpServiceLoadBalancerConfiguration represents the configuration of a BGP service load balancer. </summary>
    public partial class BgpServiceLoadBalancerConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BgpServiceLoadBalancerConfiguration"/>. </summary>
        public BgpServiceLoadBalancerConfiguration()
        {
            BgpAdvertisements = new ChangeTrackingList<BgpAdvertisement>();
            BgpPeers = new ChangeTrackingList<ServiceLoadBalancerBgpPeer>();
            IPAddressPools = new ChangeTrackingList<IPAddressPool>();
        }

        /// <summary> Initializes a new instance of <see cref="BgpServiceLoadBalancerConfiguration"/>. </summary>
        /// <param name="bgpAdvertisements"> The association of IP address pools to the communities and peers, allowing for announcement of IPs. </param>
        /// <param name="bgpPeers"> The list of additional BgpPeer entities that the Kubernetes cluster will peer with. All peering must be explicitly defined. </param>
        /// <param name="fabricPeeringEnabled"> The indicator to specify if the load balancer peers with the network fabric. </param>
        /// <param name="ipAddressPools"> The list of pools of IP addresses that can be allocated to Load Balancer services. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BgpServiceLoadBalancerConfiguration(IList<BgpAdvertisement> bgpAdvertisements, IList<ServiceLoadBalancerBgpPeer> bgpPeers, FabricPeeringEnabled? fabricPeeringEnabled, IList<IPAddressPool> ipAddressPools, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BgpAdvertisements = bgpAdvertisements;
            BgpPeers = bgpPeers;
            FabricPeeringEnabled = fabricPeeringEnabled;
            IPAddressPools = ipAddressPools;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The association of IP address pools to the communities and peers, allowing for announcement of IPs. </summary>
        public IList<BgpAdvertisement> BgpAdvertisements { get; }
        /// <summary> The list of additional BgpPeer entities that the Kubernetes cluster will peer with. All peering must be explicitly defined. </summary>
        public IList<ServiceLoadBalancerBgpPeer> BgpPeers { get; }
        /// <summary> The indicator to specify if the load balancer peers with the network fabric. </summary>
        public FabricPeeringEnabled? FabricPeeringEnabled { get; set; }
        /// <summary> The list of pools of IP addresses that can be allocated to Load Balancer services. </summary>
        public IList<IPAddressPool> IPAddressPools { get; }
    }
}
