// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    internal partial class PublicCloudConnectorPropertiesUpdate : IUtf8JsonSerializable, IJsonModel<PublicCloudConnectorPropertiesUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicCloudConnectorPropertiesUpdate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PublicCloudConnectorPropertiesUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicCloudConnectorPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicCloudConnectorPropertiesUpdate)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AwsCloudProfile))
            {
                writer.WritePropertyName("awsCloudProfile"u8);
                writer.WriteObjectValue(AwsCloudProfile, options);
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

        PublicCloudConnectorPropertiesUpdate IJsonModel<PublicCloudConnectorPropertiesUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicCloudConnectorPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicCloudConnectorPropertiesUpdate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicCloudConnectorPropertiesUpdate(document.RootElement, options);
        }

        internal static PublicCloudConnectorPropertiesUpdate DeserializePublicCloudConnectorPropertiesUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AwsCloudProfileUpdate awsCloudProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("awsCloudProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    awsCloudProfile = AwsCloudProfileUpdate.DeserializeAwsCloudProfileUpdate(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PublicCloudConnectorPropertiesUpdate(awsCloudProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PublicCloudConnectorPropertiesUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicCloudConnectorPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PublicCloudConnectorPropertiesUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        PublicCloudConnectorPropertiesUpdate IPersistableModel<PublicCloudConnectorPropertiesUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicCloudConnectorPropertiesUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePublicCloudConnectorPropertiesUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublicCloudConnectorPropertiesUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublicCloudConnectorPropertiesUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
