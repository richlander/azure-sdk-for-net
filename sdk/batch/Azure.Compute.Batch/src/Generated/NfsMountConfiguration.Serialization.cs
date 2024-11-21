// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class NfsMountConfiguration : IUtf8JsonSerializable, IJsonModel<NfsMountConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NfsMountConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NfsMountConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NfsMountConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStringValue(MountOptions);
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

        NfsMountConfiguration IJsonModel<NfsMountConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NfsMountConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNfsMountConfiguration(document.RootElement, options);
        }

        internal static NfsMountConfiguration DeserializeNfsMountConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string source = default;
            string relativeMountPath = default;
            string mountOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    mountOptions = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NfsMountConfiguration(source, relativeMountPath, mountOptions, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NfsMountConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NfsMountConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        NfsMountConfiguration IPersistableModel<NfsMountConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NfsMountConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNfsMountConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NfsMountConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NfsMountConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static NfsMountConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeNfsMountConfiguration(document.RootElement);
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
