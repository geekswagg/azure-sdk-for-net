// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthAvailabilityStatusProperties : IUtf8JsonSerializable, IJsonModel<ResourceHealthAvailabilityStatusProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthAvailabilityStatusProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthAvailabilityStatusProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthAvailabilityStatusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthAvailabilityStatusProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AvailabilityState))
            {
                writer.WritePropertyName("availabilityState"u8);
                writer.WriteStringValue(AvailabilityState.Value.ToString());
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(DetailedStatus))
            {
                writer.WritePropertyName("detailedStatus"u8);
                writer.WriteStringValue(DetailedStatus);
            }
            if (Optional.IsDefined(ReasonType))
            {
                writer.WritePropertyName("reasonType"u8);
                writer.WriteStringValue(ReasonType);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsDefined(ArticleId))
            {
                writer.WritePropertyName("articleId"u8);
                writer.WriteStringValue(ArticleId);
            }
            if (Optional.IsDefined(RootCauseAttributionOn))
            {
                writer.WritePropertyName("rootCauseAttributionTime"u8);
                writer.WriteStringValue(RootCauseAttributionOn.Value, "O");
            }
            if (Optional.IsDefined(HealthEventType))
            {
                writer.WritePropertyName("healthEventType"u8);
                writer.WriteStringValue(HealthEventType);
            }
            if (Optional.IsDefined(HealthEventCause))
            {
                writer.WritePropertyName("healthEventCause"u8);
                writer.WriteStringValue(HealthEventCause);
            }
            if (Optional.IsDefined(HealthEventCategory))
            {
                writer.WritePropertyName("healthEventCategory"u8);
                writer.WriteStringValue(HealthEventCategory);
            }
            if (Optional.IsDefined(HealthEventId))
            {
                writer.WritePropertyName("healthEventId"u8);
                writer.WriteStringValue(HealthEventId);
            }
            if (Optional.IsDefined(ResolutionEta))
            {
                writer.WritePropertyName("resolutionETA"u8);
                writer.WriteStringValue(ResolutionEta.Value, "O");
            }
            if (Optional.IsDefined(OccuredOn))
            {
                writer.WritePropertyName("occuredTime"u8);
                writer.WriteStringValue(OccuredOn.Value, "O");
            }
            if (Optional.IsDefined(ReasonChronicity))
            {
                writer.WritePropertyName("reasonChronicity"u8);
                writer.WriteStringValue(ReasonChronicity.Value.ToString());
            }
            if (Optional.IsDefined(ReportedOn))
            {
                writer.WritePropertyName("reportedTime"u8);
                writer.WriteStringValue(ReportedOn.Value, "O");
            }
            if (Optional.IsDefined(RecentlyResolved))
            {
                writer.WritePropertyName("recentlyResolved"u8);
                writer.WriteObjectValue(RecentlyResolved);
            }
            if (Optional.IsCollectionDefined(RecommendedActions))
            {
                writer.WritePropertyName("recommendedActions"u8);
                writer.WriteStartArray();
                foreach (var item in RecommendedActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceImpactingEvents))
            {
                writer.WritePropertyName("serviceImpactingEvents"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceImpactingEvents)
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

        ResourceHealthAvailabilityStatusProperties IJsonModel<ResourceHealthAvailabilityStatusProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthAvailabilityStatusProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthAvailabilityStatusProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthAvailabilityStatusProperties(document.RootElement, options);
        }

        internal static ResourceHealthAvailabilityStatusProperties DeserializeResourceHealthAvailabilityStatusProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceHealthAvailabilityStateValue> availabilityState = default;
            Optional<string> title = default;
            Optional<string> summary = default;
            Optional<string> detailedStatus = default;
            Optional<string> reasonType = default;
            Optional<string> context = default;
            Optional<string> category = default;
            Optional<string> articleId = default;
            Optional<DateTimeOffset> rootCauseAttributionTime = default;
            Optional<string> healthEventType = default;
            Optional<string> healthEventCause = default;
            Optional<string> healthEventCategory = default;
            Optional<string> healthEventId = default;
            Optional<DateTimeOffset> resolutionETA = default;
            Optional<DateTimeOffset> occuredTime = default;
            Optional<ReasonChronicityType> reasonChronicity = default;
            Optional<DateTimeOffset> reportedTime = default;
            Optional<ResourceHealthAvailabilityStateRecentlyResolved> recentlyResolved = default;
            Optional<IReadOnlyList<ResourceHealthRecommendedAction>> recommendedActions = default;
            Optional<IReadOnlyList<ServiceImpactingEvent>> serviceImpactingEvents = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availabilityState = new ResourceHealthAvailabilityStateValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    summary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detailedStatus"u8))
                {
                    detailedStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reasonType"u8))
                {
                    reasonType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("articleId"u8))
                {
                    articleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootCauseAttributionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rootCauseAttributionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("healthEventType"u8))
                {
                    healthEventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthEventCause"u8))
                {
                    healthEventCause = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthEventCategory"u8))
                {
                    healthEventCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthEventId"u8))
                {
                    healthEventId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionETA"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolutionETA = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("occuredTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occuredTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("reasonChronicity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reasonChronicity = new ReasonChronicityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recentlyResolved"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recentlyResolved = ResourceHealthAvailabilityStateRecentlyResolved.DeserializeResourceHealthAvailabilityStateRecentlyResolved(property.Value);
                    continue;
                }
                if (property.NameEquals("recommendedActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceHealthRecommendedAction> array = new List<ResourceHealthRecommendedAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceHealthRecommendedAction.DeserializeResourceHealthRecommendedAction(item));
                    }
                    recommendedActions = array;
                    continue;
                }
                if (property.NameEquals("serviceImpactingEvents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceImpactingEvent> array = new List<ServiceImpactingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceImpactingEvent.DeserializeServiceImpactingEvent(item));
                    }
                    serviceImpactingEvents = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthAvailabilityStatusProperties(Optional.ToNullable(availabilityState), title.Value, summary.Value, detailedStatus.Value, reasonType.Value, context.Value, category.Value, articleId.Value, Optional.ToNullable(rootCauseAttributionTime), healthEventType.Value, healthEventCause.Value, healthEventCategory.Value, healthEventId.Value, Optional.ToNullable(resolutionETA), Optional.ToNullable(occuredTime), Optional.ToNullable(reasonChronicity), Optional.ToNullable(reportedTime), recentlyResolved.Value, Optional.ToList(recommendedActions), Optional.ToList(serviceImpactingEvents), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthAvailabilityStatusProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthAvailabilityStatusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthAvailabilityStatusProperties)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthAvailabilityStatusProperties IPersistableModel<ResourceHealthAvailabilityStatusProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthAvailabilityStatusProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthAvailabilityStatusProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthAvailabilityStatusProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthAvailabilityStatusProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
