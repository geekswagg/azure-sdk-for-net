// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The UnknownAction. </summary>
    internal partial class UnknownAction : AlertProcessingRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAction"/>. </summary>
        /// <param name="actionType"> Action that should be applied. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAction(AlertProcessingRuleActionType actionType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(actionType, serializedAdditionalRawData)
        {
            ActionType = actionType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAction"/> for deserialization. </summary>
        internal UnknownAction()
        {
        }
    }
}
