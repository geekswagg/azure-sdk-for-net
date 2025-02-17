// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryServiceVaultProtectionIntent : IUtf8JsonSerializable, IJsonModel<RecoveryServiceVaultProtectionIntent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryServiceVaultProtectionIntent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryServiceVaultProtectionIntent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("protectionIntentItemType"u8);
            writer.WriteStringValue(ProtectionIntentItemType.ToString());
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(ItemId))
            {
                writer.WritePropertyName("itemId"u8);
                writer.WriteStringValue(ItemId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
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

        RecoveryServiceVaultProtectionIntent IJsonModel<RecoveryServiceVaultProtectionIntent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServiceVaultProtectionIntent(document.RootElement, options);
        }

        internal static RecoveryServiceVaultProtectionIntent DeserializeRecoveryServiceVaultProtectionIntent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectionIntentItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadAutoProtectionIntent": return WorkloadAutoProtectionIntent.DeserializeWorkloadAutoProtectionIntent(element);
                    case "AzureWorkloadSQLAutoProtectionIntent": return WorkloadSqlAutoProtectionIntent.DeserializeWorkloadSqlAutoProtectionIntent(element);
                }
            }
            ProtectionIntentItemType protectionIntentItemType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            Optional<BackupManagementType> backupManagementType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<ResourceIdentifier> itemId = default;
            Optional<ResourceIdentifier> policyId = default;
            Optional<BackupProtectionStatus> protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionIntentItemType"u8))
                {
                    protectionIntentItemType = new ProtectionIntentItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("itemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    itemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryServiceVaultProtectionIntent(protectionIntentItemType, Optional.ToNullable(backupManagementType), sourceResourceId.Value, itemId.Value, policyId.Value, Optional.ToNullable(protectionState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryServiceVaultProtectionIntent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support '{options.Format}' format.");
            }
        }

        RecoveryServiceVaultProtectionIntent IPersistableModel<RecoveryServiceVaultProtectionIntent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServiceVaultProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryServiceVaultProtectionIntent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryServiceVaultProtectionIntent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryServiceVaultProtectionIntent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
