// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication
{
    /// <summary> The CommunicationUserIdentifierModel. </summary>
    internal partial class CommunicationUserIdentifierModel
    {
        /// <summary> Initializes a new instance of <see cref="CommunicationUserIdentifierModel"/>. </summary>
        /// <param name="id"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CommunicationUserIdentifierModel(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
    }
}
