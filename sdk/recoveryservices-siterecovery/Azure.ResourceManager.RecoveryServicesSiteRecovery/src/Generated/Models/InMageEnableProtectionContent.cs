// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMware Azure specific enable protection input. </summary>
    public partial class InMageEnableProtectionContent : EnableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageEnableProtectionContent"/>. </summary>
        /// <param name="masterTargetId"> The Master Target Id. </param>
        /// <param name="processServerId"> The Process Server Id. </param>
        /// <param name="retentionDrive"> The retention drive to use on the MT. </param>
        /// <param name="multiVmGroupId"> The multi VM group Id. </param>
        /// <param name="multiVmGroupName"> The multi VM group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="masterTargetId"/>, <paramref name="retentionDrive"/>, <paramref name="multiVmGroupId"/> or <paramref name="multiVmGroupName"/> is null. </exception>
        public InMageEnableProtectionContent(string masterTargetId, Guid processServerId, string retentionDrive, string multiVmGroupId, string multiVmGroupName)
        {
            Argument.AssertNotNull(masterTargetId, nameof(masterTargetId));
            Argument.AssertNotNull(retentionDrive, nameof(retentionDrive));
            Argument.AssertNotNull(multiVmGroupId, nameof(multiVmGroupId));
            Argument.AssertNotNull(multiVmGroupName, nameof(multiVmGroupName));

            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            RetentionDrive = retentionDrive;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            DisksToInclude = new ChangeTrackingList<string>();
            InstanceType = "InMage";
        }

        /// <summary> Initializes a new instance of <see cref="InMageEnableProtectionContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="vmFriendlyName"> The VM Name. </param>
        /// <param name="masterTargetId"> The Master Target Id. </param>
        /// <param name="processServerId"> The Process Server Id. </param>
        /// <param name="retentionDrive"> The retention drive to use on the MT. </param>
        /// <param name="runAsAccountId"> The CS account Id. </param>
        /// <param name="multiVmGroupId"> The multi VM group Id. </param>
        /// <param name="multiVmGroupName"> The multi VM group name. </param>
        /// <param name="datastoreName"> The target datastore name. </param>
        /// <param name="diskExclusionContent"> The enable disk exclusion input. </param>
        /// <param name="disksToInclude"> The disks to include list. </param>
        internal InMageEnableProtectionContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string vmFriendlyName, string masterTargetId, Guid processServerId, string retentionDrive, string runAsAccountId, string multiVmGroupId, string multiVmGroupName, string datastoreName, InMageDiskExclusionContent diskExclusionContent, IList<string> disksToInclude) : base(instanceType, serializedAdditionalRawData)
        {
            VmFriendlyName = vmFriendlyName;
            MasterTargetId = masterTargetId;
            ProcessServerId = processServerId;
            RetentionDrive = retentionDrive;
            RunAsAccountId = runAsAccountId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            DatastoreName = datastoreName;
            DiskExclusionContent = diskExclusionContent;
            DisksToInclude = disksToInclude;
            InstanceType = instanceType ?? "InMage";
        }

        /// <summary> Initializes a new instance of <see cref="InMageEnableProtectionContent"/> for deserialization. </summary>
        internal InMageEnableProtectionContent()
        {
        }

        /// <summary> The VM Name. </summary>
        public string VmFriendlyName { get; set; }
        /// <summary> The Master Target Id. </summary>
        public string MasterTargetId { get; }
        /// <summary> The Process Server Id. </summary>
        public Guid ProcessServerId { get; }
        /// <summary> The retention drive to use on the MT. </summary>
        public string RetentionDrive { get; }
        /// <summary> The CS account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> The multi VM group Id. </summary>
        public string MultiVmGroupId { get; }
        /// <summary> The multi VM group name. </summary>
        public string MultiVmGroupName { get; }
        /// <summary> The target datastore name. </summary>
        public string DatastoreName { get; set; }
        /// <summary> The enable disk exclusion input. </summary>
        public InMageDiskExclusionContent DiskExclusionContent { get; set; }
        /// <summary> The disks to include list. </summary>
        public IList<string> DisksToInclude { get; }
    }
}
