// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Connection string for the Cosmos DB account. </summary>
    public partial class CosmosDBAccountConnectionString
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountConnectionString"/>. </summary>
        internal CosmosDBAccountConnectionString()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountConnectionString"/>. </summary>
        /// <param name="connectionString"> Value of the connection string. </param>
        /// <param name="description"> Description of the connection string. </param>
        /// <param name="keyKind"> Kind of the connection string key. </param>
        /// <param name="keyType"> Type of the connection string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBAccountConnectionString(string connectionString, string description, CosmosDBKind? keyKind, CosmosDBType? keyType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionString = connectionString;
            Description = description;
            KeyKind = keyKind;
            KeyType = keyType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Value of the connection string. </summary>
        public string ConnectionString { get; }
        /// <summary> Description of the connection string. </summary>
        public string Description { get; }
        /// <summary> Kind of the connection string key. </summary>
        public CosmosDBKind? KeyKind { get; }
        /// <summary> Type of the connection string. </summary>
        public CosmosDBType? KeyType { get; }
    }
}
