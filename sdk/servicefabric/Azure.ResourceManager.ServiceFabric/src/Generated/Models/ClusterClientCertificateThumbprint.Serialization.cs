// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterClientCertificateThumbprint : IUtf8JsonSerializable, IJsonModel<ClusterClientCertificateThumbprint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterClientCertificateThumbprint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterClientCertificateThumbprint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateThumbprint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterClientCertificateThumbprint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("isAdmin"u8);
            writer.WriteBooleanValue(IsAdmin);
            writer.WritePropertyName("certificateThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CertificateThumbprint);
#else
            using (JsonDocument document = JsonDocument.Parse(CertificateThumbprint))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
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

        ClusterClientCertificateThumbprint IJsonModel<ClusterClientCertificateThumbprint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateThumbprint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterClientCertificateThumbprint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterClientCertificateThumbprint(document.RootElement, options);
        }

        internal static ClusterClientCertificateThumbprint DeserializeClusterClientCertificateThumbprint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isAdmin = default;
            BinaryData certificateThumbprint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAdmin"u8))
                {
                    isAdmin = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("certificateThumbprint"u8))
                {
                    certificateThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterClientCertificateThumbprint(isAdmin, certificateThumbprint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterClientCertificateThumbprint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateThumbprint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterClientCertificateThumbprint)} does not support '{options.Format}' format.");
            }
        }

        ClusterClientCertificateThumbprint IPersistableModel<ClusterClientCertificateThumbprint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterClientCertificateThumbprint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterClientCertificateThumbprint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterClientCertificateThumbprint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterClientCertificateThumbprint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
