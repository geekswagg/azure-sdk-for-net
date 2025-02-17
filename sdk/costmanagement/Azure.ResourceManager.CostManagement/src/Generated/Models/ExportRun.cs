// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> An export run. </summary>
    public partial class ExportRun : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ExportRun"/>. </summary>
        public ExportRun()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExportRun"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="executionType"> The type of the export run. </param>
        /// <param name="status"> The last known status of the export run. </param>
        /// <param name="submittedBy"> The identifier for the entity that triggered the export. For on-demand runs it is the user email. For scheduled runs it is 'System'. </param>
        /// <param name="submittedOn"> The time when export was queued to be run. </param>
        /// <param name="processingStartOn"> The time when export was picked up to be run. </param>
        /// <param name="processingEndOn"> The time when the export run finished. </param>
        /// <param name="fileName"> The name of the exported file. </param>
        /// <param name="runSettings"> The export settings that were in effect for this run. </param>
        /// <param name="error"> The details of any error. </param>
        /// <param name="eTag"> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportRun(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ExportRunExecutionType? executionType, ExportRunExecutionStatus? status, string submittedBy, DateTimeOffset? submittedOn, DateTimeOffset? processingStartOn, DateTimeOffset? processingEndOn, string fileName, CommonExportProperties runSettings, ExportRunErrorDetails error, ETag? eTag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ExecutionType = executionType;
            Status = status;
            SubmittedBy = submittedBy;
            SubmittedOn = submittedOn;
            ProcessingStartOn = processingStartOn;
            ProcessingEndOn = processingEndOn;
            FileName = fileName;
            RunSettings = runSettings;
            Error = error;
            ETag = eTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the export run. </summary>
        public ExportRunExecutionType? ExecutionType { get; set; }
        /// <summary> The last known status of the export run. </summary>
        public ExportRunExecutionStatus? Status { get; set; }
        /// <summary> The identifier for the entity that triggered the export. For on-demand runs it is the user email. For scheduled runs it is 'System'. </summary>
        public string SubmittedBy { get; set; }
        /// <summary> The time when export was queued to be run. </summary>
        public DateTimeOffset? SubmittedOn { get; set; }
        /// <summary> The time when export was picked up to be run. </summary>
        public DateTimeOffset? ProcessingStartOn { get; set; }
        /// <summary> The time when the export run finished. </summary>
        public DateTimeOffset? ProcessingEndOn { get; set; }
        /// <summary> The name of the exported file. </summary>
        public string FileName { get; set; }
        /// <summary> The export settings that were in effect for this run. </summary>
        public CommonExportProperties RunSettings { get; set; }
        /// <summary> The details of any error. </summary>
        public ExportRunErrorDetails Error { get; set; }
        /// <summary> eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not. </summary>
        public ETag? ETag { get; set; }
    }
}
