// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class PrometheusHAClusterProviderInstanceProperties : IUtf8JsonSerializable, IJsonModel<PrometheusHAClusterProviderInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrometheusHAClusterProviderInstanceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrometheusHAClusterProviderInstanceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusHAClusterProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrometheusHAClusterProviderInstanceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrometheusUri))
            {
                writer.WritePropertyName("prometheusUrl"u8);
                writer.WriteStringValue(PrometheusUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName"u8);
                writer.WriteStringValue(ClusterName);
            }
            if (Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
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

        PrometheusHAClusterProviderInstanceProperties IJsonModel<PrometheusHAClusterProviderInstanceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusHAClusterProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrometheusHAClusterProviderInstanceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrometheusHAClusterProviderInstanceProperties(document.RootElement, options);
        }

        internal static PrometheusHAClusterProviderInstanceProperties DeserializePrometheusHAClusterProviderInstanceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> prometheusUrl = default;
            Optional<string> hostname = default;
            Optional<string> sid = default;
            Optional<string> clusterName = default;
            Optional<SapSslPreference> sslPreference = default;
            Optional<Uri> sslCertificateUri = default;
            string providerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prometheusUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"u8))
                {
                    sid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterName"u8))
                {
                    clusterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrometheusHAClusterProviderInstanceProperties(providerType, serializedAdditionalRawData, prometheusUrl.Value, hostname.Value, sid.Value, clusterName.Value, Optional.ToNullable(sslPreference), sslCertificateUri.Value);
        }

        BinaryData IPersistableModel<PrometheusHAClusterProviderInstanceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusHAClusterProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrometheusHAClusterProviderInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        PrometheusHAClusterProviderInstanceProperties IPersistableModel<PrometheusHAClusterProviderInstanceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrometheusHAClusterProviderInstanceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrometheusHAClusterProviderInstanceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrometheusHAClusterProviderInstanceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrometheusHAClusterProviderInstanceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
