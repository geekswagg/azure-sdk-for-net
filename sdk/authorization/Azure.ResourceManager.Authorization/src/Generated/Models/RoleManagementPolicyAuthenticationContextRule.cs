// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The role management policy authentication context rule. </summary>
    public partial class RoleManagementPolicyAuthenticationContextRule : RoleManagementPolicyRule
    {
        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyAuthenticationContextRule"/>. </summary>
        public RoleManagementPolicyAuthenticationContextRule()
        {
            RuleType = RoleManagementPolicyRuleType.RoleManagementPolicyAuthenticationContextRule;
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyAuthenticationContextRule"/>. </summary>
        /// <param name="id"> The id of the rule. </param>
        /// <param name="ruleType"> The type of rule. </param>
        /// <param name="target"> The target of the current rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isEnabled"> The value indicating if rule is enabled. </param>
        /// <param name="claimValue"> The claim value. </param>
        internal RoleManagementPolicyAuthenticationContextRule(string id, RoleManagementPolicyRuleType ruleType, RoleManagementPolicyRuleTarget target, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isEnabled, string claimValue) : base(id, ruleType, target, serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            ClaimValue = claimValue;
            RuleType = ruleType;
        }

        /// <summary> The value indicating if rule is enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The claim value. </summary>
        public string ClaimValue { get; set; }
    }
}
