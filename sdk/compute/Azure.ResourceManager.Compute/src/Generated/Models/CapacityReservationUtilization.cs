// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Represents the capacity reservation utilization in terms of resources allocated. </summary>
    public partial class CapacityReservationUtilization
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

        /// <summary> Initializes a new instance of <see cref="CapacityReservationUtilization"/>. </summary>
        internal CapacityReservationUtilization()
        {
            VirtualMachinesAllocated = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationUtilization"/>. </summary>
        /// <param name="currentCapacity"> The value provides the current capacity of the VM size which was reserved successfully and for which the customer is getting billed. Minimum api-version: 2022-08-01. </param>
        /// <param name="virtualMachinesAllocated"> A list of all virtual machines resource ids allocated against the capacity reservation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CapacityReservationUtilization(int? currentCapacity, IReadOnlyList<SubResource> virtualMachinesAllocated, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrentCapacity = currentCapacity;
            VirtualMachinesAllocated = virtualMachinesAllocated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The value provides the current capacity of the VM size which was reserved successfully and for which the customer is getting billed. Minimum api-version: 2022-08-01. </summary>
        public int? CurrentCapacity { get; }
        /// <summary> A list of all virtual machines resource ids allocated against the capacity reservation. </summary>
        public IReadOnlyList<SubResource> VirtualMachinesAllocated { get; }
    }
}
