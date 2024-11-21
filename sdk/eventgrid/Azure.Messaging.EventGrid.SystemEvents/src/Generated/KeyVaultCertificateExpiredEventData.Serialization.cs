// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class KeyVaultCertificateExpiredEventData : IUtf8JsonSerializable, IJsonModel<KeyVaultCertificateExpiredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultCertificateExpiredEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KeyVaultCertificateExpiredEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultCertificateExpiredEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("Id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("VaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("ObjectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            if (Optional.IsDefined(ObjectName))
            {
                writer.WritePropertyName("ObjectName"u8);
                writer.WriteStringValue(ObjectName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("Version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(NBF))
            {
                writer.WritePropertyName("NBF"u8);
                writer.WriteNumberValue(NBF.Value);
            }
            if (Optional.IsDefined(EXP))
            {
                writer.WritePropertyName("EXP"u8);
                writer.WriteNumberValue(EXP.Value);
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

        KeyVaultCertificateExpiredEventData IJsonModel<KeyVaultCertificateExpiredEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultCertificateExpiredEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultCertificateExpiredEventData(document.RootElement, options);
        }

        internal static KeyVaultCertificateExpiredEventData DeserializeKeyVaultCertificateExpiredEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string vaultName = default;
            string objectType = default;
            string objectName = default;
            string version = default;
            float? nbf = default;
            float? exp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KeyVaultCertificateExpiredEventData(
                id,
                vaultName,
                objectType,
                objectName,
                version,
                nbf,
                exp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultCertificateExpiredEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultCertificateExpiredEventData)} does not support writing '{options.Format}' format.");
            }
        }

        KeyVaultCertificateExpiredEventData IPersistableModel<KeyVaultCertificateExpiredEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultCertificateExpiredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultCertificateExpiredEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultCertificateExpiredEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultCertificateExpiredEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static KeyVaultCertificateExpiredEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeKeyVaultCertificateExpiredEventData(document.RootElement);
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
