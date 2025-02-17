// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class TransferOffersResult : IUtf8JsonSerializable, IJsonModel<TransferOffersResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferOffersResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransferOffersResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferOffersResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Succeeded))
            {
                writer.WritePropertyName("succeeded"u8);
                writer.WriteStartArray();
                foreach (var item in Succeeded)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Failed))
            {
                writer.WritePropertyName("failed"u8);
                writer.WriteStartArray();
                foreach (var item in Failed)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        TransferOffersResult IJsonModel<TransferOffersResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferOffersResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferOffersResult(document.RootElement, options);
        }

        internal static TransferOffersResult DeserializeTransferOffersResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PrivateStoreCollectionDetails>> succeeded = default;
            Optional<IReadOnlyList<PrivateStoreCollectionDetails>> failed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item));
                    }
                    succeeded = array;
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item));
                    }
                    failed = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransferOffersResult(Optional.ToList(succeeded), Optional.ToList(failed), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransferOffersResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransferOffersResult)} does not support '{options.Format}' format.");
            }
        }

        TransferOffersResult IPersistableModel<TransferOffersResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransferOffersResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransferOffersResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferOffersResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
