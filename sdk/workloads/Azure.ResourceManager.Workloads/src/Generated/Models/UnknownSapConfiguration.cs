// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownSapConfiguration. </summary>
    internal partial class UnknownSapConfiguration : SapConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSapConfiguration"/>. </summary>
        /// <param name="configurationType"> The configuration Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSapConfiguration(SapConfigurationType configurationType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(configurationType, serializedAdditionalRawData)
        {
            ConfigurationType = configurationType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSapConfiguration"/> for deserialization. </summary>
        internal UnknownSapConfiguration()
        {
        }
    }
}
