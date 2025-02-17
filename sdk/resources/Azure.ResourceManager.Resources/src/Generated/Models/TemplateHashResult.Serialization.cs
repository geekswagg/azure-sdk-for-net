// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class TemplateHashResult : IUtf8JsonSerializable, IJsonModel<TemplateHashResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TemplateHashResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TemplateHashResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateHashResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemplateHashResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MinifiedTemplate))
            {
                writer.WritePropertyName("minifiedTemplate"u8);
                writer.WriteStringValue(MinifiedTemplate);
            }
            if (Optional.IsDefined(TemplateHash))
            {
                writer.WritePropertyName("templateHash"u8);
                writer.WriteStringValue(TemplateHash);
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

        TemplateHashResult IJsonModel<TemplateHashResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateHashResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TemplateHashResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTemplateHashResult(document.RootElement, options);
        }

        internal static TemplateHashResult DeserializeTemplateHashResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> minifiedTemplate = default;
            Optional<string> templateHash = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minifiedTemplate"u8))
                {
                    minifiedTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateHash"u8))
                {
                    templateHash = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TemplateHashResult(minifiedTemplate.Value, templateHash.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TemplateHashResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateHashResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TemplateHashResult)} does not support '{options.Format}' format.");
            }
        }

        TemplateHashResult IPersistableModel<TemplateHashResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TemplateHashResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTemplateHashResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TemplateHashResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TemplateHashResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
