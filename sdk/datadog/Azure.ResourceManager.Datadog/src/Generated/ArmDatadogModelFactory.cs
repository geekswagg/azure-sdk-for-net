// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Datadog;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDatadogModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.DatadogAgreementResourceProperties"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Represents the properties of the resource. </param>
        /// <returns> A new <see cref="Models.DatadogAgreementResourceProperties"/> instance for mocking. </returns>
        public static DatadogAgreementResourceProperties DatadogAgreementResourceProperties(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DatadogAgreementProperties properties = null)
        {
            return new DatadogAgreementResourceProperties(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DatadogHost"/>. </summary>
        /// <param name="name"> The name of the host. </param>
        /// <param name="aliases"> The aliases for the host. </param>
        /// <param name="apps"> The Datadog integrations reporting metrics for the host. </param>
        /// <param name="meta"></param>
        /// <returns> A new <see cref="Models.DatadogHost"/> instance for mocking. </returns>
        public static DatadogHost DatadogHost(string name = null, IEnumerable<string> aliases = null, IEnumerable<string> apps = null, DatadogHostMetadata meta = null)
        {
            aliases ??= new List<string>();
            apps ??= new List<string>();

            return new DatadogHost(name, aliases?.ToList(), apps?.ToList(), meta, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DatadogHostMetadata"/>. </summary>
        /// <param name="agentVersion"> The agent version. </param>
        /// <param name="installMethod"></param>
        /// <param name="logsAgentTransport"></param>
        /// <returns> A new <see cref="Models.DatadogHostMetadata"/> instance for mocking. </returns>
        public static DatadogHostMetadata DatadogHostMetadata(string agentVersion = null, DatadogInstallMethod installMethod = null, string logsAgentTransport = null)
        {
            return new DatadogHostMetadata(agentVersion, installMethod, logsAgentTransport != null ? new DatadogLogsAgent(logsAgentTransport, serializedAdditionalRawData: null) : null, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DatadogInstallMethod"/>. </summary>
        /// <param name="tool"> The tool. </param>
        /// <param name="toolVersion"> The tool version. </param>
        /// <param name="installerVersion"> The installer version. </param>
        /// <returns> A new <see cref="Models.DatadogInstallMethod"/> instance for mocking. </returns>
        public static DatadogInstallMethod DatadogInstallMethod(string tool = null, string toolVersion = null, string installerVersion = null)
        {
            return new DatadogInstallMethod(tool, toolVersion, installerVersion, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MonitoredResourceContent"/>. </summary>
        /// <param name="id"> The ARM id of the resource. </param>
        /// <param name="sendingMetrics"> Flag indicating if resource is sending metrics to Datadog. </param>
        /// <param name="reasonForMetricsStatus"> Reason for why the resource is sending metrics (or why it is not sending). </param>
        /// <param name="sendingLogs"> Flag indicating if resource is sending logs to Datadog. </param>
        /// <param name="reasonForLogsStatus"> Reason for why the resource is sending logs (or why it is not sending). </param>
        /// <returns> A new <see cref="Models.MonitoredResourceContent"/> instance for mocking. </returns>
        public static MonitoredResourceContent MonitoredResourceContent(string id = null, bool? sendingMetrics = null, string reasonForMetricsStatus = null, bool? sendingLogs = null, string reasonForLogsStatus = null)
        {
            return new MonitoredResourceContent(id, sendingMetrics, reasonForMetricsStatus, sendingLogs, reasonForLogsStatus, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Datadog.DatadogMonitorResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="skuName"></param>
        /// <param name="properties"> Properties specific to the monitor resource. </param>
        /// <param name="identity"> Gets or sets the identity. Current supported identity types: SystemAssigned, UserAssigned. </param>
        /// <returns> A new <see cref="Datadog.DatadogMonitorResourceData"/> instance for mocking. </returns>
        public static DatadogMonitorResourceData DatadogMonitorResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string skuName = null, MonitorProperties properties = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DatadogMonitorResourceData(id, name, resourceType, systemData, tags, location, skuName != null ? new ResourceSku(skuName, serializedAdditionalRawData: null) : null, properties, identity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MonitorProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="monitoringStatus"> Flag specifying if the resource monitoring is enabled or disabled. </param>
        /// <param name="marketplaceSubscriptionStatus"> Flag specifying the Marketplace Subscription Status of the resource. If payment is not made in time, the resource will go in Suspended state. </param>
        /// <param name="datadogOrganizationProperties"> Datadog organization properties. </param>
        /// <param name="userInfo"> User info. </param>
        /// <param name="liftrResourceCategory"></param>
        /// <param name="liftrResourcePreference"> The priority of the resource. </param>
        /// <returns> A new <see cref="Models.MonitorProperties"/> instance for mocking. </returns>
        public static MonitorProperties MonitorProperties(ProvisioningState? provisioningState = null, MonitoringStatus? monitoringStatus = null, MarketplaceSubscriptionStatus? marketplaceSubscriptionStatus = null, DatadogOrganizationProperties datadogOrganizationProperties = null, UserInfo userInfo = null, LiftrResourceCategory? liftrResourceCategory = null, int? liftrResourcePreference = null)
        {
            return new MonitorProperties(provisioningState, monitoringStatus, marketplaceSubscriptionStatus, datadogOrganizationProperties, userInfo, liftrResourceCategory, liftrResourcePreference, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DatadogOrganizationProperties"/>. </summary>
        /// <param name="name"> Name of the Datadog organization. </param>
        /// <param name="id"> Id of the Datadog organization. </param>
        /// <param name="linkingAuthCode"> The auth code used to linking to an existing datadog organization. </param>
        /// <param name="linkingClientId"> The client_id from an existing in exchange for an auth token to link organization. </param>
        /// <param name="redirectUri"> The redirect uri for linking. </param>
        /// <param name="apiKey"> Api key associated to the Datadog organization. </param>
        /// <param name="applicationKey"> Application key associated to the Datadog organization. </param>
        /// <param name="enterpriseAppId"> The Id of the Enterprise App used for Single sign on. </param>
        /// <returns> A new <see cref="Models.DatadogOrganizationProperties"/> instance for mocking. </returns>
        public static DatadogOrganizationProperties DatadogOrganizationProperties(string name = null, string id = null, string linkingAuthCode = null, string linkingClientId = null, Uri redirectUri = null, string apiKey = null, string applicationKey = null, string enterpriseAppId = null)
        {
            return new DatadogOrganizationProperties(name, id, linkingAuthCode, linkingClientId, redirectUri, apiKey, applicationKey, enterpriseAppId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DatadogSetPasswordLink"/>. </summary>
        /// <param name="setPasswordLink"></param>
        /// <returns> A new <see cref="Models.DatadogSetPasswordLink"/> instance for mocking. </returns>
        public static DatadogSetPasswordLink DatadogSetPasswordLink(string setPasswordLink = null)
        {
            return new DatadogSetPasswordLink(setPasswordLink, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Datadog.MonitoringTagRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Definition of the properties for a TagRules resource. </param>
        /// <returns> A new <see cref="Datadog.MonitoringTagRuleData"/> instance for mocking. </returns>
        public static MonitoringTagRuleData MonitoringTagRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MonitoringTagRulesProperties properties = null)
        {
            return new MonitoringTagRuleData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MonitoringTagRulesProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRulesFilteringTags"> Set of rules for sending metrics for the Monitor resource. </param>
        /// <returns> A new <see cref="Models.MonitoringTagRulesProperties"/> instance for mocking. </returns>
        public static MonitoringTagRulesProperties MonitoringTagRulesProperties(ProvisioningState? provisioningState = null, LogRules logRules = null, IEnumerable<FilteringTag> metricRulesFilteringTags = null)
        {
            metricRulesFilteringTags ??= new List<FilteringTag>();

            return new MonitoringTagRulesProperties(provisioningState, logRules, metricRulesFilteringTags != null ? new MetricRules(metricRulesFilteringTags?.ToList(), serializedAdditionalRawData: null) : null, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Datadog.DatadogSingleSignOnResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"></param>
        /// <returns> A new <see cref="Datadog.DatadogSingleSignOnResourceData"/> instance for mocking. </returns>
        public static DatadogSingleSignOnResourceData DatadogSingleSignOnResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DatadogSingleSignOnProperties properties = null)
        {
            return new DatadogSingleSignOnResourceData(id, name, resourceType, systemData, properties, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DatadogSingleSignOnProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="singleSignOnState"> Various states of the SSO resource. </param>
        /// <param name="enterpriseAppId"> The Id of the Enterprise App used for Single sign-on. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Datadog Organization. </param>
        /// <returns> A new <see cref="Models.DatadogSingleSignOnProperties"/> instance for mocking. </returns>
        public static DatadogSingleSignOnProperties DatadogSingleSignOnProperties(ProvisioningState? provisioningState = null, SingleSignOnState? singleSignOnState = null, string enterpriseAppId = null, Uri singleSignOnUri = null)
        {
            return new DatadogSingleSignOnProperties(provisioningState, singleSignOnState, enterpriseAppId, singleSignOnUri, serializedAdditionalRawData: null);
        }
    }
}
