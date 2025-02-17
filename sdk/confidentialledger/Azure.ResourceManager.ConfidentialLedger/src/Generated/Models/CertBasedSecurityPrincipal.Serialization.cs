// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class CertBasedSecurityPrincipal : IUtf8JsonSerializable, IJsonModel<CertBasedSecurityPrincipal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CertBasedSecurityPrincipal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CertBasedSecurityPrincipal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertBasedSecurityPrincipal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertBasedSecurityPrincipal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Cert))
            {
                writer.WritePropertyName("cert"u8);
                writer.WriteStringValue(Cert);
            }
            if (Optional.IsDefined(LedgerRoleName))
            {
                writer.WritePropertyName("ledgerRoleName"u8);
                writer.WriteStringValue(LedgerRoleName.Value.ToString());
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

        CertBasedSecurityPrincipal IJsonModel<CertBasedSecurityPrincipal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertBasedSecurityPrincipal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CertBasedSecurityPrincipal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCertBasedSecurityPrincipal(document.RootElement, options);
        }

        internal static CertBasedSecurityPrincipal DeserializeCertBasedSecurityPrincipal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cert = default;
            Optional<ConfidentialLedgerRoleName> ledgerRoleName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cert"u8))
                {
                    cert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ledgerRoleName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ledgerRoleName = new ConfidentialLedgerRoleName(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CertBasedSecurityPrincipal(cert.Value, Optional.ToNullable(ledgerRoleName), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CertBasedSecurityPrincipal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertBasedSecurityPrincipal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CertBasedSecurityPrincipal)} does not support '{options.Format}' format.");
            }
        }

        CertBasedSecurityPrincipal IPersistableModel<CertBasedSecurityPrincipal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CertBasedSecurityPrincipal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCertBasedSecurityPrincipal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CertBasedSecurityPrincipal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CertBasedSecurityPrincipal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
