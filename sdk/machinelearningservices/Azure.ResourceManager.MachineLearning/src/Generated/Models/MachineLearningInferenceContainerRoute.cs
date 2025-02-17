// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningInferenceContainerRoute. </summary>
    public partial class MachineLearningInferenceContainerRoute
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningInferenceContainerRoute"/>. </summary>
        /// <param name="path"> [Required] The path for the route. </param>
        /// <param name="port"> [Required] The port for the route. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public MachineLearningInferenceContainerRoute(string path, int port)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
            Port = port;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningInferenceContainerRoute"/>. </summary>
        /// <param name="path"> [Required] The path for the route. </param>
        /// <param name="port"> [Required] The port for the route. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningInferenceContainerRoute(string path, int port, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Path = path;
            Port = port;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningInferenceContainerRoute"/> for deserialization. </summary>
        internal MachineLearningInferenceContainerRoute()
        {
        }

        /// <summary> [Required] The path for the route. </summary>
        public string Path { get; set; }
        /// <summary> [Required] The port for the route. </summary>
        public int Port { get; set; }
    }
}
