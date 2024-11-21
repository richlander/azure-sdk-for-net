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
    public partial class SynapseTransparentDataEncryptionData : IUtf8JsonSerializable, IJsonModel<SynapseTransparentDataEncryptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseTransparentDataEncryptionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseTransparentDataEncryptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTransparentDataEncryptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseTransparentDataEncryptionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        SynapseTransparentDataEncryptionData IJsonModel<SynapseTransparentDataEncryptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTransparentDataEncryptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseTransparentDataEncryptionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseTransparentDataEncryptionData(document.RootElement, options);
        }

        internal static SynapseTransparentDataEncryptionData DeserializeSynapseTransparentDataEncryptionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            SynapseTransparentDataEncryptionStatus? status = default;
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
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToSynapseTransparentDataEncryptionStatus();
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
            return new SynapseTransparentDataEncryptionData(
                id,
                name,
                type,
                systemData,
                location,
                status,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseTransparentDataEncryptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTransparentDataEncryptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseTransparentDataEncryptionData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseTransparentDataEncryptionData IPersistableModel<SynapseTransparentDataEncryptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseTransparentDataEncryptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseTransparentDataEncryptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseTransparentDataEncryptionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseTransparentDataEncryptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
