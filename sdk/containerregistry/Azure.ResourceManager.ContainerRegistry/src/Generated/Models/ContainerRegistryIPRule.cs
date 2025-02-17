// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> IP rule with specific IP or IP range in CIDR format. </summary>
    public partial class ContainerRegistryIPRule
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryIPRule"/>. </summary>
        /// <param name="ipAddressOrRange"> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipAddressOrRange"/> is null. </exception>
        public ContainerRegistryIPRule(string ipAddressOrRange)
        {
            Argument.AssertNotNull(ipAddressOrRange, nameof(ipAddressOrRange));

            IPAddressOrRange = ipAddressOrRange;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryIPRule"/>. </summary>
        /// <param name="action"> The action of IP ACL rule. </param>
        /// <param name="ipAddressOrRange"> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryIPRule(ContainerRegistryIPRuleAction? action, string ipAddressOrRange, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            IPAddressOrRange = ipAddressOrRange;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryIPRule"/> for deserialization. </summary>
        internal ContainerRegistryIPRule()
        {
        }

        /// <summary> The action of IP ACL rule. </summary>
        public ContainerRegistryIPRuleAction? Action { get; set; }
        /// <summary> Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed. </summary>
        public string IPAddressOrRange { get; set; }
    }
}
