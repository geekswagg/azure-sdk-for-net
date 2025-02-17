// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosMongoDataTransferDataSourceSink : IUtf8JsonSerializable, IJsonModel<CosmosMongoDataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosMongoDataTransferDataSourceSink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosMongoDataTransferDataSourceSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosMongoDataTransferDataSourceSink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("collectionName"u8);
            writer.WriteStringValue(CollectionName);
            if (Optional.IsDefined(RemoteAccountName))
            {
                writer.WritePropertyName("remoteAccountName"u8);
                writer.WriteStringValue(RemoteAccountName);
            }
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
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

        CosmosMongoDataTransferDataSourceSink IJsonModel<CosmosMongoDataTransferDataSourceSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosMongoDataTransferDataSourceSink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosMongoDataTransferDataSourceSink(document.RootElement, options);
        }

        internal static CosmosMongoDataTransferDataSourceSink DeserializeCosmosMongoDataTransferDataSourceSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            string collectionName = default;
            Optional<string> remoteAccountName = default;
            DataTransferComponent component = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionName"u8))
                {
                    collectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteAccountName"u8))
                {
                    remoteAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosMongoDataTransferDataSourceSink(component, serializedAdditionalRawData, databaseName, collectionName, remoteAccountName.Value);
        }

        BinaryData IPersistableModel<CosmosMongoDataTransferDataSourceSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosMongoDataTransferDataSourceSink)} does not support '{options.Format}' format.");
            }
        }

        CosmosMongoDataTransferDataSourceSink IPersistableModel<CosmosMongoDataTransferDataSourceSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosMongoDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosMongoDataTransferDataSourceSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosMongoDataTransferDataSourceSink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosMongoDataTransferDataSourceSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
