// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the Machine Extensions List Result. </summary>
    internal partial class MachineExtensionsListResult
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

        /// <summary> Initializes a new instance of <see cref="MachineExtensionsListResult"/>. </summary>
        internal MachineExtensionsListResult()
        {
            Value = new ChangeTrackingList<HybridComputeMachineExtensionData>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineExtensionsListResult"/>. </summary>
        /// <param name="value"> The list of extensions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineExtensionsListResult(IReadOnlyList<HybridComputeMachineExtensionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of extensions. </summary>
        public IReadOnlyList<HybridComputeMachineExtensionData> Value { get; }
        /// <summary> The uri to fetch the next page of machine extensions. Call ListNext() with this to fetch the next page of extensions. </summary>
        public string NextLink { get; }
    }
}
