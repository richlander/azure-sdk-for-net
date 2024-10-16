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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DiscoveredSecuritySolution : IUtf8JsonSerializable, IJsonModel<DiscoveredSecuritySolution>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveredSecuritySolution>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiscoveredSecuritySolution>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveredSecuritySolution)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("securityFamily"u8);
            writer.WriteStringValue(SecurityFamily.ToString());
            writer.WritePropertyName("offer"u8);
            writer.WriteStringValue(Offer);
            writer.WritePropertyName("publisher"u8);
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("sku"u8);
            writer.WriteStringValue(Sku);
            writer.WriteEndObject();
        }

        DiscoveredSecuritySolution IJsonModel<DiscoveredSecuritySolution>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveredSecuritySolution)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveredSecuritySolution(document.RootElement, options);
        }

        internal static DiscoveredSecuritySolution DeserializeDiscoveredSecuritySolution(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SecurityFamily securityFamily = default;
            string offer = default;
            string publisher = default;
            string sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                        if (property0.NameEquals("securityFamily"u8))
                        {
                            securityFamily = new SecurityFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("offer"u8))
                        {
                            offer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
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
            return new DiscoveredSecuritySolution(
                id,
                name,
                type,
                systemData,
                securityFamily,
                offer,
                publisher,
                sku,
                location,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiscoveredSecuritySolution>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveredSecuritySolution)} does not support writing '{options.Format}' format.");
            }
        }

        DiscoveredSecuritySolution IPersistableModel<DiscoveredSecuritySolution>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveredSecuritySolution>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiscoveredSecuritySolution(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveredSecuritySolution)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveredSecuritySolution>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
