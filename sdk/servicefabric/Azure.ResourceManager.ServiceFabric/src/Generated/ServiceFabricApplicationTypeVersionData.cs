// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing the ServiceFabricApplicationTypeVersion data model.
    /// An application type version resource for the specified application type name resource.
    /// </summary>
    public partial class ServiceFabricApplicationTypeVersionData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationTypeVersionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ServiceFabricApplicationTypeVersionData(AzureLocation location) : base(location)
        {
            DefaultParameterList = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationTypeVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="appPackageUri"> The URL to the application package. </param>
        /// <param name="defaultParameterList"> List of application type parameters that can be overridden when creating or updating the application. </param>
        /// <param name="etag"> Azure resource etag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricApplicationTypeVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, Uri appPackageUri, IReadOnlyDictionary<string, string> defaultParameterList, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AppPackageUri = appPackageUri;
            DefaultParameterList = defaultParameterList;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationTypeVersionData"/> for deserialization. </summary>
        internal ServiceFabricApplicationTypeVersionData()
        {
        }

        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The URL to the application package. </summary>
        public Uri AppPackageUri { get; set; }
        /// <summary> List of application type parameters that can be overridden when creating or updating the application. </summary>
        public IReadOnlyDictionary<string, string> DefaultParameterList { get; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
