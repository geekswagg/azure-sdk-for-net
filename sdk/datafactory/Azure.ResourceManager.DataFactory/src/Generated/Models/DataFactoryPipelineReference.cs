// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Pipeline reference type. </summary>
    public partial class DataFactoryPipelineReference
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReference"/>. </summary>
        /// <param name="referenceType"> Pipeline reference type. </param>
        /// <param name="referenceName"> Reference pipeline name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public DataFactoryPipelineReference(DataFactoryPipelineReferenceType referenceType, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            ReferenceType = referenceType;
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReference"/>. </summary>
        /// <param name="referenceType"> Pipeline reference type. </param>
        /// <param name="referenceName"> Reference pipeline name. </param>
        /// <param name="name"> Reference name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryPipelineReference(DataFactoryPipelineReferenceType referenceType, string referenceName, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReferenceType = referenceType;
            ReferenceName = referenceName;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineReference"/> for deserialization. </summary>
        internal DataFactoryPipelineReference()
        {
        }

        /// <summary> Pipeline reference type. </summary>
        public DataFactoryPipelineReferenceType ReferenceType { get; set; }
        /// <summary> Reference pipeline name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Reference name. </summary>
        public string Name { get; set; }
    }
}
