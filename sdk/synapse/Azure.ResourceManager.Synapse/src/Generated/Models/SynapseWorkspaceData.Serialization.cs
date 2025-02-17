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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseWorkspaceData : IUtf8JsonSerializable, IJsonModel<SynapseWorkspaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseWorkspaceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseWorkspaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseWorkspaceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(DefaultDataLakeStorage))
            {
                writer.WritePropertyName("defaultDataLakeStorage"u8);
                writer.WriteObjectValue(DefaultDataLakeStorage);
            }
            if (Optional.IsDefined(SqlAdministratorLoginPassword))
            {
                writer.WritePropertyName("sqlAdministratorLoginPassword"u8);
                writer.WriteStringValue(SqlAdministratorLoginPassword);
            }
            if (Optional.IsDefined(ManagedResourceGroupName))
            {
                writer.WritePropertyName("managedResourceGroupName"u8);
                writer.WriteStringValue(ManagedResourceGroupName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(SqlAdministratorLogin))
            {
                writer.WritePropertyName("sqlAdministratorLogin"u8);
                writer.WriteStringValue(SqlAdministratorLogin);
            }
            if (Optional.IsDefined(VirtualNetworkProfile))
            {
                writer.WritePropertyName("virtualNetworkProfile"u8);
                writer.WriteObjectValue(VirtualNetworkProfile);
            }
            if (Optional.IsCollectionDefined(ConnectivityEndpoints))
            {
                writer.WritePropertyName("connectivityEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in ConnectivityEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork"u8);
                writer.WriteStringValue(ManagedVirtualNetwork);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (options.Format != "W" && Optional.IsDefined(WorkspaceUid))
            {
                writer.WritePropertyName("workspaceUID"u8);
                writer.WriteStringValue(WorkspaceUid.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExtraProperties))
            {
                writer.WritePropertyName("extraProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtraProperties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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
            if (Optional.IsDefined(ManagedVirtualNetworkSettings))
            {
                writer.WritePropertyName("managedVirtualNetworkSettings"u8);
                writer.WriteObjectValue(ManagedVirtualNetworkSettings);
            }
            if (Optional.IsDefined(WorkspaceRepositoryConfiguration))
            {
                writer.WritePropertyName("workspaceRepositoryConfiguration"u8);
                writer.WriteObjectValue(WorkspaceRepositoryConfiguration);
            }
            if (Optional.IsDefined(PurviewConfiguration))
            {
                writer.WritePropertyName("purviewConfiguration"u8);
                writer.WriteObjectValue(PurviewConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(AdlaResourceId))
            {
                writer.WritePropertyName("adlaResourceId"u8);
                writer.WriteStringValue(AdlaResourceId);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(CspWorkspaceAdminProperties))
            {
                writer.WritePropertyName("cspWorkspaceAdminProperties"u8);
                writer.WriteObjectValue(CspWorkspaceAdminProperties);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteStartObject();
                foreach (var item in Settings)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
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
            if (Optional.IsDefined(IsAadOnlyAuthenticationEnabled))
            {
                writer.WritePropertyName("azureADOnlyAuthentication"u8);
                writer.WriteBooleanValue(IsAadOnlyAuthenticationEnabled.Value);
            }
            if (Optional.IsDefined(IsTrustedServiceBypassEnabled))
            {
                writer.WritePropertyName("trustedServiceBypassEnabled"u8);
                writer.WriteBooleanValue(IsTrustedServiceBypassEnabled.Value);
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

        SynapseWorkspaceData IJsonModel<SynapseWorkspaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseWorkspaceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseWorkspaceData(document.RootElement, options);
        }

        internal static SynapseWorkspaceData DeserializeSynapseWorkspaceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SynapseDataLakeStorageAccountDetails> defaultDataLakeStorage = default;
            Optional<string> sqlAdministratorLoginPassword = default;
            Optional<string> managedResourceGroupName = default;
            Optional<string> provisioningState = default;
            Optional<string> sqlAdministratorLogin = default;
            Optional<VirtualNetworkProfile> virtualNetworkProfile = default;
            Optional<IDictionary<string, string>> connectivityEndpoints = default;
            Optional<string> managedVirtualNetwork = default;
            Optional<IList<SynapsePrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<SynapseEncryptionDetails> encryption = default;
            Optional<Guid> workspaceUID = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> extraProperties = default;
            Optional<SynapseManagedVirtualNetworkSettings> managedVirtualNetworkSettings = default;
            Optional<SynapseWorkspaceRepositoryConfiguration> workspaceRepositoryConfiguration = default;
            Optional<PurviewConfiguration> purviewConfiguration = default;
            Optional<ResourceIdentifier> adlaResourceId = default;
            Optional<WorkspacePublicNetworkAccess> publicNetworkAccess = default;
            Optional<CspWorkspaceAdminProperties> cspWorkspaceAdminProperties = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> settings = default;
            Optional<bool> azureADOnlyAuthentication = default;
            Optional<bool> trustedServiceBypassEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("defaultDataLakeStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultDataLakeStorage = SynapseDataLakeStorageAccountDetails.DeserializeSynapseDataLakeStorageAccountDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sqlAdministratorLoginPassword"u8))
                        {
                            sqlAdministratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupName"u8))
                        {
                            managedResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sqlAdministratorLogin"u8))
                        {
                            sqlAdministratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkProfile = VirtualNetworkProfile.DeserializeVirtualNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectivityEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            connectivityEndpoints = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetwork"u8))
                        {
                            managedVirtualNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapsePrivateEndpointConnectionData> array = new List<SynapsePrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapsePrivateEndpointConnectionData.DeserializeSynapsePrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = SynapseEncryptionDetails.DeserializeSynapseEncryptionDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceUID"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceUID = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("extraProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            extraProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetworkSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedVirtualNetworkSettings = SynapseManagedVirtualNetworkSettings.DeserializeSynapseManagedVirtualNetworkSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceRepositoryConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceRepositoryConfiguration = SynapseWorkspaceRepositoryConfiguration.DeserializeSynapseWorkspaceRepositoryConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("purviewConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purviewConfiguration = PurviewConfiguration.DeserializePurviewConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("adlaResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adlaResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new WorkspacePublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cspWorkspaceAdminProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cspWorkspaceAdminProperties = CspWorkspaceAdminProperties.DeserializeCspWorkspaceAdminProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("settings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            settings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("azureADOnlyAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureADOnlyAuthentication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("trustedServiceBypassEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedServiceBypassEnabled = property0.Value.GetBoolean();
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
            return new SynapseWorkspaceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, defaultDataLakeStorage.Value, sqlAdministratorLoginPassword.Value, managedResourceGroupName.Value, provisioningState.Value, sqlAdministratorLogin.Value, virtualNetworkProfile.Value, Optional.ToDictionary(connectivityEndpoints), managedVirtualNetwork.Value, Optional.ToList(privateEndpointConnections), encryption.Value, Optional.ToNullable(workspaceUID), Optional.ToDictionary(extraProperties), managedVirtualNetworkSettings.Value, workspaceRepositoryConfiguration.Value, purviewConfiguration.Value, adlaResourceId.Value, Optional.ToNullable(publicNetworkAccess), cspWorkspaceAdminProperties.Value, Optional.ToDictionary(settings), Optional.ToNullable(azureADOnlyAuthentication), Optional.ToNullable(trustedServiceBypassEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseWorkspaceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseWorkspaceData)} does not support '{options.Format}' format.");
            }
        }

        SynapseWorkspaceData IPersistableModel<SynapseWorkspaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseWorkspaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseWorkspaceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseWorkspaceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseWorkspaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
