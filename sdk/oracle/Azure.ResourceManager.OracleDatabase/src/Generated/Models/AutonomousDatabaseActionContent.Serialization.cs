// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class AutonomousDatabaseActionContent : IUtf8JsonSerializable, IJsonModel<AutonomousDatabaseActionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutonomousDatabaseActionContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutonomousDatabaseActionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutonomousDatabaseActionContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PeerDBId))
            {
                writer.WritePropertyName("peerDbId"u8);
                writer.WriteStringValue(PeerDBId);
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

        AutonomousDatabaseActionContent IJsonModel<AutonomousDatabaseActionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseActionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutonomousDatabaseActionContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutonomousDatabaseActionContent(document.RootElement, options);
        }

        internal static AutonomousDatabaseActionContent DeserializeAutonomousDatabaseActionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string peerDBId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peerDbId"u8))
                {
                    peerDBId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutonomousDatabaseActionContent(peerDBId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutonomousDatabaseActionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutonomousDatabaseActionContent)} does not support writing '{options.Format}' format.");
            }
        }

        AutonomousDatabaseActionContent IPersistableModel<AutonomousDatabaseActionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutonomousDatabaseActionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutonomousDatabaseActionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutonomousDatabaseActionContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutonomousDatabaseActionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
