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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServiceFabricManagedClusterVersion : IUtf8JsonSerializable, IJsonModel<ServiceFabricManagedClusterVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricManagedClusterVersion>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceFabricManagedClusterVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedClusterVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricManagedClusterVersion)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterCodeVersion))
            {
                writer.WritePropertyName("clusterCodeVersion"u8);
                writer.WriteStringValue(ClusterCodeVersion);
            }
            if (Optional.IsDefined(VersionSupportExpireOn))
            {
                writer.WritePropertyName("supportExpiryUtc"u8);
                writer.WriteStringValue(VersionSupportExpireOn.Value, "O");
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ServiceFabricManagedClusterVersion IJsonModel<ServiceFabricManagedClusterVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedClusterVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricManagedClusterVersion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricManagedClusterVersion(document.RootElement, options);
        }

        internal static ServiceFabricManagedClusterVersion DeserializeServiceFabricManagedClusterVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string clusterCodeVersion = default;
            DateTimeOffset? supportExpiryUtc = default;
            ServiceFabricManagedClusterOSType? osType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("clusterCodeVersion"u8))
                        {
                            clusterCodeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportExpiryUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            supportExpiryUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = new ServiceFabricManagedClusterOSType(property0.Value.GetString());
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
            return new ServiceFabricManagedClusterVersion(
                id,
                name,
                type,
                systemData,
                clusterCodeVersion,
                supportExpiryUtc,
                osType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricManagedClusterVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedClusterVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricManagedClusterVersion)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceFabricManagedClusterVersion IPersistableModel<ServiceFabricManagedClusterVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricManagedClusterVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricManagedClusterVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricManagedClusterVersion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricManagedClusterVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
