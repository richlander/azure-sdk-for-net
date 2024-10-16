// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class DedicatedHostGroupPropertiesAdditionalCapabilities : IUtf8JsonSerializable, IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UltraSsdEnabled))
            {
                writer.WritePropertyName("ultraSSDEnabled"u8);
                writer.WriteBooleanValue(UltraSsdEnabled.Value);
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

        DedicatedHostGroupPropertiesAdditionalCapabilities IJsonModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(document.RootElement, options);
        }

        internal static DedicatedHostGroupPropertiesAdditionalCapabilities DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? ultraSsdEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ultraSSDEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ultraSsdEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DedicatedHostGroupPropertiesAdditionalCapabilities(ultraSsdEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support writing '{options.Format}' format.");
            }
        }

        DedicatedHostGroupPropertiesAdditionalCapabilities IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDedicatedHostGroupPropertiesAdditionalCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedHostGroupPropertiesAdditionalCapabilities)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHostGroupPropertiesAdditionalCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
