// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownSchedulePolicy))]
    public partial class BackupSchedulePolicy : IUtf8JsonSerializable, IJsonModel<BackupSchedulePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupSchedulePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupSchedulePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupSchedulePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("schedulePolicyType"u8);
            writer.WriteStringValue(SchedulePolicyType);
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

        BackupSchedulePolicy IJsonModel<BackupSchedulePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupSchedulePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupSchedulePolicy(document.RootElement, options);
        }

        internal static BackupSchedulePolicy DeserializeBackupSchedulePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("schedulePolicyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LogSchedulePolicy": return LogSchedulePolicy.DeserializeLogSchedulePolicy(element);
                    case "LongTermSchedulePolicy": return LongTermSchedulePolicy.DeserializeLongTermSchedulePolicy(element);
                    case "SimpleSchedulePolicy": return SimpleSchedulePolicy.DeserializeSimpleSchedulePolicy(element);
                    case "SimpleSchedulePolicyV2": return SimpleSchedulePolicyV2.DeserializeSimpleSchedulePolicyV2(element);
                }
            }
            return UnknownSchedulePolicy.DeserializeUnknownSchedulePolicy(element);
        }

        BinaryData IPersistableModel<BackupSchedulePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupSchedulePolicy)} does not support '{options.Format}' format.");
            }
        }

        BackupSchedulePolicy IPersistableModel<BackupSchedulePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupSchedulePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupSchedulePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupSchedulePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupSchedulePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
