// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class ClinicalTrials : IUtf8JsonSerializable, IJsonModel<ClinicalTrials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClinicalTrials>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClinicalTrials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClinicalTrials)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CustomTrials))
            {
                writer.WritePropertyName("customTrials"u8);
                writer.WriteStartArray();
                foreach (var item in CustomTrials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegistryFilters))
            {
                writer.WritePropertyName("registryFilters"u8);
                writer.WriteStartArray();
                foreach (var item in RegistryFilters)
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

        ClinicalTrials IJsonModel<ClinicalTrials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrials>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClinicalTrials)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClinicalTrials(document.RootElement, options);
        }

        internal static ClinicalTrials DeserializeClinicalTrials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ClinicalTrialDetails>> customTrials = default;
            Optional<IList<ClinicalTrialRegistryFilter>> registryFilters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClinicalTrialDetails> array = new List<ClinicalTrialDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClinicalTrialDetails.DeserializeClinicalTrialDetails(item));
                    }
                    customTrials = array;
                    continue;
                }
                if (property.NameEquals("registryFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClinicalTrialRegistryFilter> array = new List<ClinicalTrialRegistryFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClinicalTrialRegistryFilter.DeserializeClinicalTrialRegistryFilter(item));
                    }
                    registryFilters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClinicalTrials(Optional.ToList(customTrials), Optional.ToList(registryFilters), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClinicalTrials>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClinicalTrials)} does not support '{options.Format}' format.");
            }
        }

        ClinicalTrials IPersistableModel<ClinicalTrials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrials>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClinicalTrials(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClinicalTrials)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClinicalTrials>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ClinicalTrials FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeClinicalTrials(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
