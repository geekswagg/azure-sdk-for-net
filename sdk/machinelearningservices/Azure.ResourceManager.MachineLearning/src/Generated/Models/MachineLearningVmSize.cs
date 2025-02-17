// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Describes the properties of a VM size. </summary>
    public partial class MachineLearningVmSize
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningVmSize"/>. </summary>
        internal MachineLearningVmSize()
        {
            SupportedComputeTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningVmSize"/>. </summary>
        /// <param name="name"> The name of the virtual machine size. </param>
        /// <param name="family"> The family name of the virtual machine size. </param>
        /// <param name="vCpus"> The number of vCPUs supported by the virtual machine size. </param>
        /// <param name="gpus"> The number of gPUs supported by the virtual machine size. </param>
        /// <param name="osVhdSizeMB"> The OS VHD disk size, in MB, allowed by the virtual machine size. </param>
        /// <param name="maxResourceVolumeMB"> The resource volume size, in MB, allowed by the virtual machine size. </param>
        /// <param name="memoryGB"> The amount of memory, in GB, supported by the virtual machine size. </param>
        /// <param name="lowPriorityCapable"> Specifies if the virtual machine size supports low priority VMs. </param>
        /// <param name="isPremiumIOSupported"> Specifies if the virtual machine size supports premium IO. </param>
        /// <param name="estimatedVmPrices"> The estimated price information for using a VM. </param>
        /// <param name="supportedComputeTypes"> Specifies the compute types supported by the virtual machine size. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningVmSize(string name, string family, int? vCpus, int? gpus, int? osVhdSizeMB, int? maxResourceVolumeMB, double? memoryGB, bool? lowPriorityCapable, bool? isPremiumIOSupported, MachineLearningEstimatedVmPrices estimatedVmPrices, IReadOnlyList<string> supportedComputeTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Family = family;
            VCpus = vCpus;
            Gpus = gpus;
            OSVhdSizeMB = osVhdSizeMB;
            MaxResourceVolumeMB = maxResourceVolumeMB;
            MemoryGB = memoryGB;
            LowPriorityCapable = lowPriorityCapable;
            IsPremiumIOSupported = isPremiumIOSupported;
            EstimatedVmPrices = estimatedVmPrices;
            SupportedComputeTypes = supportedComputeTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the virtual machine size. </summary>
        public string Name { get; }
        /// <summary> The family name of the virtual machine size. </summary>
        public string Family { get; }
        /// <summary> The number of vCPUs supported by the virtual machine size. </summary>
        public int? VCpus { get; }
        /// <summary> The number of gPUs supported by the virtual machine size. </summary>
        public int? Gpus { get; }
        /// <summary> The OS VHD disk size, in MB, allowed by the virtual machine size. </summary>
        public int? OSVhdSizeMB { get; }
        /// <summary> The resource volume size, in MB, allowed by the virtual machine size. </summary>
        public int? MaxResourceVolumeMB { get; }
        /// <summary> The amount of memory, in GB, supported by the virtual machine size. </summary>
        public double? MemoryGB { get; }
        /// <summary> Specifies if the virtual machine size supports low priority VMs. </summary>
        public bool? LowPriorityCapable { get; }
        /// <summary> Specifies if the virtual machine size supports premium IO. </summary>
        public bool? IsPremiumIOSupported { get; }
        /// <summary> The estimated price information for using a VM. </summary>
        public MachineLearningEstimatedVmPrices EstimatedVmPrices { get; }
        /// <summary> Specifies the compute types supported by the virtual machine size. </summary>
        public IReadOnlyList<string> SupportedComputeTypes { get; }
    }
}
