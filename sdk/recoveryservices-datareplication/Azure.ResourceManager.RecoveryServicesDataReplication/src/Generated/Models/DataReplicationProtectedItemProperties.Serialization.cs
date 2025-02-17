// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationProtectedItemProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationProtectedItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationProtectedItemProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataReplicationProtectedItemProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationProtectedItemProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("policyName"u8);
            writer.WriteStringValue(PolicyName);
            writer.WritePropertyName("replicationExtensionName"u8);
            writer.WriteStringValue(ReplicationExtensionName);
            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProtectionStateDescription))
            {
                writer.WritePropertyName("protectionStateDescription"u8);
                writer.WriteStringValue(ProtectionStateDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(TestFailoverState))
            {
                writer.WritePropertyName("testFailoverState"u8);
                writer.WriteStringValue(TestFailoverState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(TestFailoverStateDescription))
            {
                writer.WritePropertyName("testFailoverStateDescription"u8);
                writer.WriteStringValue(TestFailoverStateDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(ResynchronizationState))
            {
                writer.WritePropertyName("resynchronizationState"u8);
                writer.WriteStringValue(ResynchronizationState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricObjectName))
            {
                writer.WritePropertyName("fabricObjectName"u8);
                writer.WriteStringValue(FabricObjectName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceFabricProviderId))
            {
                writer.WritePropertyName("sourceFabricProviderId"u8);
                writer.WriteStringValue(SourceFabricProviderId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetFabricProviderId))
            {
                writer.WritePropertyName("targetFabricProviderId"u8);
                writer.WriteStringValue(TargetFabricProviderId);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricId))
            {
                writer.WritePropertyName("fabricId"u8);
                writer.WriteStringValue(FabricId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetFabricId))
            {
                writer.WritePropertyName("targetFabricId"u8);
                writer.WriteStringValue(TargetFabricId);
            }
            if (options.Format != "W" && Optional.IsDefined(DraId))
            {
                writer.WritePropertyName("draId"u8);
                writer.WriteStringValue(DraId);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetDraId))
            {
                writer.WritePropertyName("targetDraId"u8);
                writer.WriteStringValue(TargetDraId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsResyncRequired))
            {
                writer.WritePropertyName("resyncRequired"u8);
                writer.WriteBooleanValue(IsResyncRequired.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSuccessfulPlannedFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulPlannedFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulPlannedFailoverOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastSuccessfulUnplannedFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulUnplannedFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulUnplannedFailoverOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastSuccessfulTestFailoverOn))
            {
                writer.WritePropertyName("lastSuccessfulTestFailoverTime"u8);
                writer.WriteStringValue(LastSuccessfulTestFailoverOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentJob))
            {
                writer.WritePropertyName("currentJob"u8);
                writer.WriteObjectValue(CurrentJob);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AllowedJobs))
            {
                writer.WritePropertyName("allowedJobs"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedJobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastFailedEnableProtectionJob))
            {
                writer.WritePropertyName("lastFailedEnableProtectionJob"u8);
                writer.WriteObjectValue(LastFailedEnableProtectionJob);
            }
            if (options.Format != "W" && Optional.IsDefined(LastFailedPlannedFailoverJob))
            {
                writer.WritePropertyName("lastFailedPlannedFailoverJob"u8);
                writer.WriteObjectValue(LastFailedPlannedFailoverJob);
            }
            if (options.Format != "W" && Optional.IsDefined(LastTestFailoverJob))
            {
                writer.WritePropertyName("lastTestFailoverJob"u8);
                writer.WriteObjectValue(LastTestFailoverJob);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicationHealth))
            {
                writer.WritePropertyName("replicationHealth"u8);
                writer.WriteStringValue(ReplicationHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties);
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

        DataReplicationProtectedItemProperties IJsonModel<DataReplicationProtectedItemProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationProtectedItemProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationProtectedItemProperties(document.RootElement, options);
        }

        internal static DataReplicationProtectedItemProperties DeserializeDataReplicationProtectedItemProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string policyName = default;
            string replicationExtensionName = default;
            Optional<string> correlationId = default;
            Optional<DataReplicationProvisioningState> provisioningState = default;
            Optional<DataReplicationProtectionState> protectionState = default;
            Optional<string> protectionStateDescription = default;
            Optional<DataReplicationTestFailoverState> testFailoverState = default;
            Optional<string> testFailoverStateDescription = default;
            Optional<DataReplicationResynchronizationState> resynchronizationState = default;
            Optional<string> fabricObjectId = default;
            Optional<string> fabricObjectName = default;
            Optional<string> sourceFabricProviderId = default;
            Optional<string> targetFabricProviderId = default;
            Optional<string> fabricId = default;
            Optional<string> targetFabricId = default;
            Optional<string> draId = default;
            Optional<string> targetDraId = default;
            Optional<bool> resyncRequired = default;
            Optional<DateTimeOffset> lastSuccessfulPlannedFailoverTime = default;
            Optional<DateTimeOffset> lastSuccessfulUnplannedFailoverTime = default;
            Optional<DateTimeOffset> lastSuccessfulTestFailoverTime = default;
            Optional<ProtectedItemJobProperties> currentJob = default;
            Optional<IReadOnlyList<string>> allowedJobs = default;
            Optional<ProtectedItemJobProperties> lastFailedEnableProtectionJob = default;
            Optional<ProtectedItemJobProperties> lastFailedPlannedFailoverJob = default;
            Optional<ProtectedItemJobProperties> lastTestFailoverJob = default;
            Optional<DataReplicationHealthStatus> replicationHealth = default;
            Optional<IReadOnlyList<DataReplicationHealthErrorInfo>> healthErrors = default;
            ProtectedItemModelCustomProperties customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationExtensionName"u8))
                {
                    replicationExtensionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataReplicationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new DataReplicationProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionStateDescription"u8))
                {
                    protectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFailoverState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testFailoverState = new DataReplicationTestFailoverState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("testFailoverStateDescription"u8))
                {
                    testFailoverStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resynchronizationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resynchronizationState = new DataReplicationResynchronizationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    fabricObjectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectName"u8))
                {
                    fabricObjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFabricProviderId"u8))
                {
                    sourceFabricProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFabricProviderId"u8))
                {
                    targetFabricProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricId"u8))
                {
                    fabricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFabricId"u8))
                {
                    targetFabricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("draId"u8))
                {
                    draId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDraId"u8))
                {
                    targetDraId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastSuccessfulPlannedFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulPlannedFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSuccessfulUnplannedFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulUnplannedFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSuccessfulTestFailoverTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSuccessfulTestFailoverTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentJob = ProtectedItemJobProperties.DeserializeProtectedItemJobProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("allowedJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedJobs = array;
                    continue;
                }
                if (property.NameEquals("lastFailedEnableProtectionJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastFailedEnableProtectionJob = ProtectedItemJobProperties.DeserializeProtectedItemJobProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("lastFailedPlannedFailoverJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastFailedPlannedFailoverJob = ProtectedItemJobProperties.DeserializeProtectedItemJobProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("lastTestFailoverJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTestFailoverJob = ProtectedItemJobProperties.DeserializeProtectedItemJobProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("replicationHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationHealth = new DataReplicationHealthStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationHealthErrorInfo> array = new List<DataReplicationHealthErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationHealthErrorInfo.DeserializeDataReplicationHealthErrorInfo(item));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = ProtectedItemModelCustomProperties.DeserializeProtectedItemModelCustomProperties(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationProtectedItemProperties(policyName, replicationExtensionName, correlationId.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(protectionState), protectionStateDescription.Value, Optional.ToNullable(testFailoverState), testFailoverStateDescription.Value, Optional.ToNullable(resynchronizationState), fabricObjectId.Value, fabricObjectName.Value, sourceFabricProviderId.Value, targetFabricProviderId.Value, fabricId.Value, targetFabricId.Value, draId.Value, targetDraId.Value, Optional.ToNullable(resyncRequired), Optional.ToNullable(lastSuccessfulPlannedFailoverTime), Optional.ToNullable(lastSuccessfulUnplannedFailoverTime), Optional.ToNullable(lastSuccessfulTestFailoverTime), currentJob.Value, Optional.ToList(allowedJobs), lastFailedEnableProtectionJob.Value, lastFailedPlannedFailoverJob.Value, lastTestFailoverJob.Value, Optional.ToNullable(replicationHealth), Optional.ToList(healthErrors), customProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataReplicationProtectedItemProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        DataReplicationProtectedItemProperties IPersistableModel<DataReplicationProtectedItemProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationProtectedItemProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataReplicationProtectedItemProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataReplicationProtectedItemProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataReplicationProtectedItemProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
