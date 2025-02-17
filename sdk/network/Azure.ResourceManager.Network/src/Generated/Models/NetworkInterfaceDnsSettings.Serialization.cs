// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkInterfaceDnsSettings : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceDnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceDnsSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkInterfaceDnsSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceDnsSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AppliedDnsServers))
            {
                writer.WritePropertyName("appliedDnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in AppliedDnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InternalDnsNameLabel))
            {
                writer.WritePropertyName("internalDnsNameLabel"u8);
                writer.WriteStringValue(InternalDnsNameLabel);
            }
            if (options.Format != "W" && Optional.IsDefined(InternalFqdn))
            {
                writer.WritePropertyName("internalFqdn"u8);
                writer.WriteStringValue(InternalFqdn);
            }
            if (options.Format != "W" && Optional.IsDefined(InternalDomainNameSuffix))
            {
                writer.WritePropertyName("internalDomainNameSuffix"u8);
                writer.WriteStringValue(InternalDomainNameSuffix);
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

        NetworkInterfaceDnsSettings IJsonModel<NetworkInterfaceDnsSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceDnsSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceDnsSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceDnsSettings(document.RootElement, options);
        }

        internal static NetworkInterfaceDnsSettings DeserializeNetworkInterfaceDnsSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> dnsServers = default;
            Optional<IReadOnlyList<string>> appliedDnsServers = default;
            Optional<string> internalDnsNameLabel = default;
            Optional<string> internalFqdn = default;
            Optional<string> internalDomainNameSuffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"u8))
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
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("appliedDnsServers"u8))
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
                    appliedDnsServers = array;
                    continue;
                }
                if (property.NameEquals("internalDnsNameLabel"u8))
                {
                    internalDnsNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalFqdn"u8))
                {
                    internalFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalDomainNameSuffix"u8))
                {
                    internalDomainNameSuffix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceDnsSettings(Optional.ToList(dnsServers), Optional.ToList(appliedDnsServers), internalDnsNameLabel.Value, internalFqdn.Value, internalDomainNameSuffix.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkInterfaceDnsSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceDnsSettings)} does not support '{options.Format}' format.");
            }
        }

        NetworkInterfaceDnsSettings IPersistableModel<NetworkInterfaceDnsSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceDnsSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkInterfaceDnsSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceDnsSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaceDnsSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
