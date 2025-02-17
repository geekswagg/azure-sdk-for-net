// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes multiple sets of queue selectors, of which one will be selected and attached according to a weighting. </summary>
    public partial class WeightedAllocationQueueSelectorAttachment : QueueSelectorAttachment
    {
        /// <summary> Initializes a new instance of <see cref="WeightedAllocationQueueSelectorAttachment"/>. </summary>
        /// <param name="kind"> The type discriminator describing a sub-type of QueueSelectorAttachment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        internal WeightedAllocationQueueSelectorAttachment(QueueSelectorAttachmentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<QueueWeightedAllocation> allocations) : base(kind, serializedAdditionalRawData)
        {
            Allocations = allocations;
        }

        /// <summary> Initializes a new instance of <see cref="WeightedAllocationQueueSelectorAttachment"/> for deserialization. </summary>
        internal WeightedAllocationQueueSelectorAttachment()
        {
        }

        /// <summary> A collection of percentage based weighted allocations. </summary>
        public IReadOnlyList<QueueWeightedAllocation> Allocations { get; }
    }
}
