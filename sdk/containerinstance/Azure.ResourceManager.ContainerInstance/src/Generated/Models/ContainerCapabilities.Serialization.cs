// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerCapabilities : IUtf8JsonSerializable, IJsonModel<ContainerCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerCapabilities>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType);
            }
            if (options.Format != "W" && Optional.IsDefined(Gpu))
            {
                writer.WritePropertyName("gpu"u8);
                writer.WriteStringValue(Gpu);
            }
            if (options.Format != "W" && Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities, options);
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
        }

        ContainerCapabilities IJsonModel<ContainerCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCapabilities(document.RootElement, options);
        }

        internal static ContainerCapabilities DeserializeContainerCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceType = default;
            string osType = default;
            AzureLocation? location = default;
            string ipAddressType = default;
            string gpu = default;
            ContainerSupportedCapabilities capabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
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
                if (property.NameEquals("ipAddressType"u8))
                {
                    ipAddressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpu"u8))
                {
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = ContainerSupportedCapabilities.DeserializeContainerSupportedCapabilities(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerCapabilities(
                resourceType,
                osType,
                location,
                ipAddressType,
                gpu,
                capabilities,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerCapabilities IPersistableModel<ContainerCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
