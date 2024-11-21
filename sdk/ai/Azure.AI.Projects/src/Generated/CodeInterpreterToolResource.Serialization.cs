// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class CodeInterpreterToolResource : IUtf8JsonSerializable, IJsonModel<CodeInterpreterToolResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CodeInterpreterToolResource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CodeInterpreterToolResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodeInterpreterToolResource)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(FileIds))
            {
                writer.WritePropertyName("file_ids"u8);
                writer.WriteStartArray();
                foreach (var item in FileIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataSources))
            {
                writer.WritePropertyName("data_sources"u8);
                writer.WriteStartArray();
                foreach (var item in DataSources)
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

        CodeInterpreterToolResource IJsonModel<CodeInterpreterToolResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodeInterpreterToolResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCodeInterpreterToolResource(document.RootElement, options);
        }

        internal static CodeInterpreterToolResource DeserializeCodeInterpreterToolResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> fileIds = default;
            IList<VectorStoreDataSource> dataSources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file_ids"u8))
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
                    fileIds = array;
                    continue;
                }
                if (property.NameEquals("data_sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VectorStoreDataSource> array = new List<VectorStoreDataSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VectorStoreDataSource.DeserializeVectorStoreDataSource(item, options));
                    }
                    dataSources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CodeInterpreterToolResource(fileIds ?? new ChangeTrackingList<string>(), dataSources ?? new ChangeTrackingList<VectorStoreDataSource>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CodeInterpreterToolResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CodeInterpreterToolResource)} does not support writing '{options.Format}' format.");
            }
        }

        CodeInterpreterToolResource IPersistableModel<CodeInterpreterToolResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeInterpreterToolResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCodeInterpreterToolResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CodeInterpreterToolResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CodeInterpreterToolResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CodeInterpreterToolResource FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCodeInterpreterToolResource(document.RootElement);
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
