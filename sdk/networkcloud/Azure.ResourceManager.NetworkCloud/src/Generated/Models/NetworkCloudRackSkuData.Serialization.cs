// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudRackSkuData : IUtf8JsonSerializable, IJsonModel<NetworkCloudRackSkuData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudRackSkuData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudRackSkuData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackSkuData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudRackSkuData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(ComputeMachines))
            {
                writer.WritePropertyName("computeMachines"u8);
                writer.WriteStartArray();
                foreach (var item in ComputeMachines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ControllerMachines))
            {
                writer.WritePropertyName("controllerMachines"u8);
                writer.WriteStartArray();
                foreach (var item in ControllerMachines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxClusterSlots))
            {
                writer.WritePropertyName("maxClusterSlots"u8);
                writer.WriteNumberValue(MaxClusterSlots.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RackType))
            {
                writer.WritePropertyName("rackType"u8);
                writer.WriteStringValue(RackType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(StorageAppliances))
            {
                writer.WritePropertyName("storageAppliances"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAppliances)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedRackSkuIds))
            {
                writer.WritePropertyName("supportedRackSkuIds"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedRackSkuIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        NetworkCloudRackSkuData IJsonModel<NetworkCloudRackSkuData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackSkuData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudRackSkuData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudRackSkuData(document.RootElement, options);
        }

        internal static NetworkCloudRackSkuData DeserializeNetworkCloudRackSkuData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<MachineSkuSlot>> computeMachines = default;
            Optional<IReadOnlyList<MachineSkuSlot>> controllerMachines = default;
            Optional<string> description = default;
            Optional<long> maxClusterSlots = default;
            Optional<RackSkuProvisioningState> provisioningState = default;
            Optional<RackSkuType> rackType = default;
            Optional<IReadOnlyList<StorageApplianceSkuSlot>> storageAppliances = default;
            Optional<IReadOnlyList<string>> supportedRackSkuIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("computeMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineSkuSlot> array = new List<MachineSkuSlot>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineSkuSlot.DeserializeMachineSkuSlot(item));
                            }
                            computeMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("controllerMachines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineSkuSlot> array = new List<MachineSkuSlot>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineSkuSlot.DeserializeMachineSkuSlot(item));
                            }
                            controllerMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxClusterSlots"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxClusterSlots = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new RackSkuProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rackType = new RackSkuType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAppliances"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StorageApplianceSkuSlot> array = new List<StorageApplianceSkuSlot>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageApplianceSkuSlot.DeserializeStorageApplianceSkuSlot(item));
                            }
                            storageAppliances = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedRackSkuIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            supportedRackSkuIds = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudRackSkuData(id, name, type, systemData.Value, Optional.ToList(computeMachines), Optional.ToList(controllerMachines), description.Value, Optional.ToNullable(maxClusterSlots), Optional.ToNullable(provisioningState), Optional.ToNullable(rackType), Optional.ToList(storageAppliances), Optional.ToList(supportedRackSkuIds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudRackSkuData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackSkuData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudRackSkuData)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudRackSkuData IPersistableModel<NetworkCloudRackSkuData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudRackSkuData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudRackSkuData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudRackSkuData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudRackSkuData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
