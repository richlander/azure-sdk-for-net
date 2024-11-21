// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasDateFormat : IUtf8JsonSerializable, IJsonModel<AtlasDateFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasDateFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasDateFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasDateFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasDateFormat)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AvailableLocales))
            {
                writer.WritePropertyName("availableLocales"u8);
                writer.WriteStartArray();
                foreach (var item in AvailableLocales)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Calendar))
            {
                writer.WritePropertyName("calendar"u8);
                writer.WriteNumberValue(Calendar.Value);
            }
            if (Optional.IsDefined(DateInstance))
            {
                writer.WritePropertyName("dateInstance"u8);
                writer.WriteObjectValue(DateInstance, options);
            }
            if (Optional.IsDefined(DateTimeInstance))
            {
                writer.WritePropertyName("dateTimeInstance"u8);
                writer.WriteObjectValue(DateTimeInstance, options);
            }
            if (Optional.IsDefined(Instance))
            {
                writer.WritePropertyName("instance"u8);
                writer.WriteObjectValue(Instance, options);
            }
            if (Optional.IsDefined(Lenient))
            {
                writer.WritePropertyName("lenient"u8);
                writer.WriteBooleanValue(Lenient.Value);
            }
            if (Optional.IsDefined(NumberFormat))
            {
                writer.WritePropertyName("numberFormat"u8);
                writer.WriteObjectValue(NumberFormat, options);
            }
            if (Optional.IsDefined(TimeInstance))
            {
                writer.WritePropertyName("timeInstance"u8);
                writer.WriteObjectValue(TimeInstance, options);
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteObjectValue(TimeZone, options);
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

        AtlasDateFormat IJsonModel<AtlasDateFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasDateFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasDateFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasDateFormat(document.RootElement, options);
        }

        internal static AtlasDateFormat DeserializeAtlasDateFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> availableLocales = default;
            float? calendar = default;
            AtlasDateFormat dateInstance = default;
            AtlasDateFormat dateTimeInstance = default;
            AtlasDateFormat instance = default;
            bool? lenient = default;
            AtlasNumberFormat numberFormat = default;
            AtlasDateFormat timeInstance = default;
            AtlasTimeZone timeZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availableLocales"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availableLocales = array;
                    continue;
                }
                if (property.NameEquals("calendar"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    calendar = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("dateInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateInstance = DeserializeAtlasDateFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dateTimeInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateTimeInstance = DeserializeAtlasDateFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instance = DeserializeAtlasDateFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lenient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lenient = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("numberFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberFormat = AtlasNumberFormat.DeserializeAtlasNumberFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeInstance = DeserializeAtlasDateFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeZone = AtlasTimeZone.DeserializeAtlasTimeZone(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasDateFormat(
                availableLocales ?? new ChangeTrackingList<string>(),
                calendar,
                dateInstance,
                dateTimeInstance,
                instance,
                lenient,
                numberFormat,
                timeInstance,
                timeZone,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasDateFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasDateFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasDateFormat)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasDateFormat IPersistableModel<AtlasDateFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasDateFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasDateFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasDateFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasDateFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasDateFormat FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasDateFormat(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
