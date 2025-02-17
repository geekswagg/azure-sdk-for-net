// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageSetting : IUtf8JsonSerializable, IJsonModel<ImageSetting>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageSetting>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageSetting>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageSetting)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImageType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ImageType.Value.ToString());
            }
            if (Optional.IsDefined(Reference))
            {
                writer.WritePropertyName("reference"u8);
                writer.WriteStringValue(Reference);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        ImageSetting IJsonModel<ImageSetting>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSetting>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageSetting)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageSetting(document.RootElement, options);
        }

        internal static ImageSetting DeserializeImageSetting(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ImageType> type = default;
            Optional<string> reference = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ImageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reference"u8))
                {
                    reference = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ImageSetting(Optional.ToNullable(type), reference.Value, additionalProperties);
        }

        BinaryData IPersistableModel<ImageSetting>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageSetting)} does not support '{options.Format}' format.");
            }
        }

        ImageSetting IPersistableModel<ImageSetting>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageSetting>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageSetting(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageSetting)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageSetting>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
