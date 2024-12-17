// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    public partial class ExportedEntityRegex : IUtf8JsonSerializable, IJsonModel<ExportedEntityRegex>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportedEntityRegex>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportedEntityRegex>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedEntityRegex>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedEntityRegex)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Expressions))
            {
                writer.WritePropertyName("expressions"u8);
                writer.WriteStartArray();
                foreach (var item in Expressions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ExportedEntityRegex IJsonModel<ExportedEntityRegex>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedEntityRegex>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportedEntityRegex)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportedEntityRegex(document.RootElement, options);
        }

        internal static ExportedEntityRegex DeserializeExportedEntityRegex(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ExportedEntityRegexExpression> expressions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExportedEntityRegexExpression> array = new List<ExportedEntityRegexExpression>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExportedEntityRegexExpression.DeserializeExportedEntityRegexExpression(item, options));
                    }
                    expressions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportedEntityRegex(expressions ?? new ChangeTrackingList<ExportedEntityRegexExpression>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportedEntityRegex>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedEntityRegex>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportedEntityRegex)} does not support writing '{options.Format}' format.");
            }
        }

        ExportedEntityRegex IPersistableModel<ExportedEntityRegex>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportedEntityRegex>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExportedEntityRegex(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportedEntityRegex)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportedEntityRegex>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ExportedEntityRegex FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeExportedEntityRegex(document.RootElement);
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
