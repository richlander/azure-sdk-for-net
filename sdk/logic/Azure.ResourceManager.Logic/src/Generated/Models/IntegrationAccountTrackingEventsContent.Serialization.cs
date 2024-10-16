// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountTrackingEventsContent : IUtf8JsonSerializable, IJsonModel<IntegrationAccountTrackingEventsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationAccountTrackingEventsContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationAccountTrackingEventsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountTrackingEventsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("sourceType"u8);
            writer.WriteStringValue(SourceType);
            if (Optional.IsDefined(TrackEventsOptions))
            {
                writer.WritePropertyName("trackEventsOptions"u8);
                writer.WriteStringValue(TrackEventsOptions.Value.ToString());
            }
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        IntegrationAccountTrackingEventsContent IJsonModel<IntegrationAccountTrackingEventsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountTrackingEventsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationAccountTrackingEventsContent(document.RootElement, options);
        }

        internal static IntegrationAccountTrackingEventsContent DeserializeIntegrationAccountTrackingEventsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceType = default;
            IntegrationAccountTrackEventOperationOption? trackEventsOptions = default;
            IList<IntegrationAccountTrackingEvent> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceType"u8))
                {
                    sourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackEventsOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackEventsOptions = new IntegrationAccountTrackEventOperationOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    List<IntegrationAccountTrackingEvent> array = new List<IntegrationAccountTrackingEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationAccountTrackingEvent.DeserializeIntegrationAccountTrackingEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationAccountTrackingEventsContent(sourceType, trackEventsOptions, events, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationAccountTrackingEventsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountTrackingEventsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationAccountTrackingEventsContent IPersistableModel<IntegrationAccountTrackingEventsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationAccountTrackingEventsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationAccountTrackingEventsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationAccountTrackingEventsContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationAccountTrackingEventsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
