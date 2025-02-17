// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HostingEnvironmentDiagnostics : IUtf8JsonSerializable, IJsonModel<HostingEnvironmentDiagnostics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostingEnvironmentDiagnostics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostingEnvironmentDiagnostics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostingEnvironmentDiagnostics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostingEnvironmentDiagnostics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DiagnosticsOutput))
            {
                writer.WritePropertyName("diagnosticsOutput"u8);
                writer.WriteStringValue(DiagnosticsOutput);
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

        HostingEnvironmentDiagnostics IJsonModel<HostingEnvironmentDiagnostics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostingEnvironmentDiagnostics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostingEnvironmentDiagnostics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostingEnvironmentDiagnostics(document.RootElement, options);
        }

        internal static HostingEnvironmentDiagnostics DeserializeHostingEnvironmentDiagnostics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> diagnosticsOutput = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diagnosticsOutput"u8))
                {
                    diagnosticsOutput = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostingEnvironmentDiagnostics(name.Value, diagnosticsOutput.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostingEnvironmentDiagnostics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostingEnvironmentDiagnostics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostingEnvironmentDiagnostics)} does not support '{options.Format}' format.");
            }
        }

        HostingEnvironmentDiagnostics IPersistableModel<HostingEnvironmentDiagnostics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostingEnvironmentDiagnostics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostingEnvironmentDiagnostics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostingEnvironmentDiagnostics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostingEnvironmentDiagnostics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
