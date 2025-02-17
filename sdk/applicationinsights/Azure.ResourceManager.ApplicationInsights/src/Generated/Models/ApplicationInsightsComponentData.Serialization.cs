// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    public partial class ApplicationInsightsComponentData : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationInsightsComponentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("ApplicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (options.Format != "W" && Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("AppId"u8);
                writer.WriteStringValue(AppId);
            }
            if (options.Format != "W" && Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("Application_Type"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(FlowType))
            {
                writer.WritePropertyName("Flow_Type"u8);
                writer.WriteStringValue(FlowType.Value.ToString());
            }
            if (Optional.IsDefined(RequestSource))
            {
                writer.WritePropertyName("Request_Source"u8);
                writer.WriteStringValue(RequestSource.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InstrumentationKey))
            {
                writer.WritePropertyName("InstrumentationKey"u8);
                writer.WriteStringValue(InstrumentationKey);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("CreationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("TenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(HockeyAppId))
            {
                writer.WritePropertyName("HockeyAppId"u8);
                writer.WriteStringValue(HockeyAppId);
            }
            if (options.Format != "W" && Optional.IsDefined(HockeyAppToken))
            {
                writer.WritePropertyName("HockeyAppToken"u8);
                writer.WriteStringValue(HockeyAppToken);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(SamplingPercentage))
            {
                writer.WritePropertyName("SamplingPercentage"u8);
                writer.WriteNumberValue(SamplingPercentage.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("ConnectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(RetentionInDays))
            {
                writer.WritePropertyName("RetentionInDays"u8);
                writer.WriteNumberValue(RetentionInDays.Value);
            }
            if (Optional.IsDefined(IsDisableIPMasking))
            {
                writer.WritePropertyName("DisableIpMasking"u8);
                writer.WriteBooleanValue(IsDisableIPMasking.Value);
            }
            if (Optional.IsDefined(IsImmediatePurgeDataOn30Days))
            {
                writer.WritePropertyName("ImmediatePurgeDataOn30Days"u8);
                writer.WriteBooleanValue(IsImmediatePurgeDataOn30Days.Value);
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("WorkspaceResourceId"u8);
                writer.WriteStringValue(WorkspaceResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(LaMigrationOn))
            {
                writer.WritePropertyName("LaMigrationDate"u8);
                writer.WriteStringValue(LaMigrationOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateLinkScopedResources))
            {
                writer.WritePropertyName("PrivateLinkScopedResources"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkScopedResources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccessForIngestion))
            {
                writer.WritePropertyName("publicNetworkAccessForIngestion"u8);
                writer.WriteStringValue(PublicNetworkAccessForIngestion.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccessForQuery))
            {
                writer.WritePropertyName("publicNetworkAccessForQuery"u8);
                writer.WriteStringValue(PublicNetworkAccessForQuery.Value.ToString());
            }
            if (Optional.IsDefined(IngestionMode))
            {
                writer.WritePropertyName("IngestionMode"u8);
                writer.WriteStringValue(IngestionMode.Value.ToString());
            }
            if (Optional.IsDefined(IsDisableLocalAuth))
            {
                writer.WritePropertyName("DisableLocalAuth"u8);
                writer.WriteBooleanValue(IsDisableLocalAuth.Value);
            }
            if (Optional.IsDefined(IsForceCustomerStorageForProfiler))
            {
                writer.WritePropertyName("ForceCustomerStorageForProfiler"u8);
                writer.WriteBooleanValue(IsForceCustomerStorageForProfiler.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApplicationInsightsComponentData IJsonModel<ApplicationInsightsComponentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentData(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentData DeserializeApplicationInsightsComponentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> applicationId = default;
            Optional<string> appId = default;
            Optional<string> name0 = default;
            Optional<ApplicationType> applicationType = default;
            Optional<FlowType> flowType = default;
            Optional<RequestSource> requestSource = default;
            Optional<string> instrumentationKey = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<Guid> tenantId = default;
            Optional<string> hockeyAppId = default;
            Optional<string> hockeyAppToken = default;
            Optional<string> provisioningState = default;
            Optional<double> samplingPercentage = default;
            Optional<string> connectionString = default;
            Optional<int> retentionInDays = default;
            Optional<bool> disableIPMasking = default;
            Optional<bool> immediatePurgeDataOn30Days = default;
            Optional<string> workspaceResourceId = default;
            Optional<DateTimeOffset> laMigrationDate = default;
            Optional<IReadOnlyList<PrivateLinkScopedResourceContent>> privateLinkScopedResources = default;
            Optional<PublicNetworkAccessType> publicNetworkAccessForIngestion = default;
            Optional<PublicNetworkAccessType> publicNetworkAccessForQuery = default;
            Optional<IngestionMode> ingestionMode = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> forceCustomerStorageForProfiler = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ApplicationId"u8))
                        {
                            applicationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("AppId"u8))
                        {
                            appId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Application_Type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationType = new ApplicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("Flow_Type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            flowType = new FlowType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("Request_Source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestSource = new RequestSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("InstrumentationKey"u8))
                        {
                            instrumentationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("CreationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("TenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("HockeyAppId"u8))
                        {
                            hockeyAppId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("HockeyAppToken"u8))
                        {
                            hockeyAppToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("SamplingPercentage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            samplingPercentage = property0.Value.GetDouble();
                            continue;
                        }
                        if (property0.NameEquals("ConnectionString"u8))
                        {
                            connectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("RetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("DisableIpMasking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableIPMasking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ImmediatePurgeDataOn30Days"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immediatePurgeDataOn30Days = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("WorkspaceResourceId"u8))
                        {
                            workspaceResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("LaMigrationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            laMigrationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("PrivateLinkScopedResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateLinkScopedResourceContent> array = new List<PrivateLinkScopedResourceContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateLinkScopedResourceContent.DeserializePrivateLinkScopedResourceContent(item));
                            }
                            privateLinkScopedResources = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccessForIngestion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccessForIngestion = new PublicNetworkAccessType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccessForQuery"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccessForQuery = new PublicNetworkAccessType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("IngestionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingestionMode = new IngestionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("DisableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ForceCustomerStorageForProfiler"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forceCustomerStorageForProfiler = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, kind, Optional.ToNullable(etag), applicationId.Value, appId.Value, name0.Value, Optional.ToNullable(applicationType), Optional.ToNullable(flowType), Optional.ToNullable(requestSource), instrumentationKey.Value, Optional.ToNullable(creationDate), Optional.ToNullable(tenantId), hockeyAppId.Value, hockeyAppToken.Value, provisioningState.Value, Optional.ToNullable(samplingPercentage), connectionString.Value, Optional.ToNullable(retentionInDays), Optional.ToNullable(disableIPMasking), Optional.ToNullable(immediatePurgeDataOn30Days), workspaceResourceId.Value, Optional.ToNullable(laMigrationDate), Optional.ToList(privateLinkScopedResources), Optional.ToNullable(publicNetworkAccessForIngestion), Optional.ToNullable(publicNetworkAccessForQuery), Optional.ToNullable(ingestionMode), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(forceCustomerStorageForProfiler), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentData)} does not support '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentData IPersistableModel<ApplicationInsightsComponentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationInsightsComponentData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
