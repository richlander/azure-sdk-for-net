// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class PrivateEndpointData : IUtf8JsonSerializable, IJsonModel<PrivateEndpointData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpointData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteObjectValue(Subnet, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PrivateLinkServiceConnections))
            {
                writer.WritePropertyName("privateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManualPrivateLinkServiceConnections))
            {
                writer.WritePropertyName("manualPrivateLinkServiceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in ManualPrivateLinkServiceConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomDnsConfigs))
            {
                writer.WritePropertyName("customDnsConfigs"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDnsConfigs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
            {
                writer.WritePropertyName("applicationSecurityGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomNetworkInterfaceName))
            {
                writer.WritePropertyName("customNetworkInterfaceName"u8);
                writer.WriteStringValue(CustomNetworkInterfaceName);
            }
            writer.WriteEndObject();
        }

        PrivateEndpointData IJsonModel<PrivateEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointData(document.RootElement, options);
        }

        internal static PrivateEndpointData DeserializePrivateEndpointData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            SubnetData subnet = default;
            IReadOnlyList<NetworkInterfaceData> networkInterfaces = default;
            NetworkProvisioningState? provisioningState = default;
            IList<NetworkPrivateLinkServiceConnection> privateLinkServiceConnections = default;
            IList<NetworkPrivateLinkServiceConnection> manualPrivateLinkServiceConnections = default;
            IList<CustomDnsConfigProperties> customDnsConfigs = default;
            IList<ApplicationSecurityGroupData> applicationSecurityGroups = default;
            IList<PrivateEndpointIPConfiguration> ipConfigurations = default;
            string customNetworkInterfaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = SubnetData.DeserializeSubnetData(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceData> array = new List<NetworkInterfaceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceData.DeserializeNetworkInterfaceData(item, options));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkPrivateLinkServiceConnection> array = new List<NetworkPrivateLinkServiceConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkPrivateLinkServiceConnection.DeserializeNetworkPrivateLinkServiceConnection(item, options));
                            }
                            privateLinkServiceConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("manualPrivateLinkServiceConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkPrivateLinkServiceConnection> array = new List<NetworkPrivateLinkServiceConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkPrivateLinkServiceConnection.DeserializeNetworkPrivateLinkServiceConnection(item, options));
                            }
                            manualPrivateLinkServiceConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("customDnsConfigs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CustomDnsConfigProperties> array = new List<CustomDnsConfigProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CustomDnsConfigProperties.DeserializeCustomDnsConfigProperties(item, options));
                            }
                            customDnsConfigs = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationSecurityGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationSecurityGroupData> array = new List<ApplicationSecurityGroupData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationSecurityGroupData.DeserializeApplicationSecurityGroupData(item, options));
                            }
                            applicationSecurityGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateEndpointIPConfiguration> array = new List<PrivateEndpointIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointIPConfiguration.DeserializePrivateEndpointIPConfiguration(item, options));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("customNetworkInterfaceName"u8))
                        {
                            customNetworkInterfaceName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateEndpointData(
                id,
                name,
                type,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                extendedLocation,
                etag,
                subnet,
                networkInterfaces ?? new ChangeTrackingList<NetworkInterfaceData>(),
                provisioningState,
                privateLinkServiceConnections ?? new ChangeTrackingList<NetworkPrivateLinkServiceConnection>(),
                manualPrivateLinkServiceConnections ?? new ChangeTrackingList<NetworkPrivateLinkServiceConnection>(),
                customDnsConfigs ?? new ChangeTrackingList<CustomDnsConfigProperties>(),
                applicationSecurityGroups ?? new ChangeTrackingList<ApplicationSecurityGroupData>(),
                ipConfigurations ?? new ChangeTrackingList<PrivateEndpointIPConfiguration>(),
                customNetworkInterfaceName);
        }

        BinaryData IPersistableModel<PrivateEndpointData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointData)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateEndpointData IPersistableModel<PrivateEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpointData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
