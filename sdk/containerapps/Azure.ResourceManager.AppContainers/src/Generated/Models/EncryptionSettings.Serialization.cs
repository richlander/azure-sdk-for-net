// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class EncryptionSettings : IUtf8JsonSerializable, IJsonModel<EncryptionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EncryptionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ContainerAppAuthEncryptionSecretName))
            {
                writer.WritePropertyName("containerAppAuthEncryptionSecretName"u8);
                writer.WriteStringValue(ContainerAppAuthEncryptionSecretName);
            }
            if (Optional.IsDefined(ContainerAppAuthSigningSecretName))
            {
                writer.WritePropertyName("containerAppAuthSigningSecretName"u8);
                writer.WriteStringValue(ContainerAppAuthSigningSecretName);
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

        EncryptionSettings IJsonModel<EncryptionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncryptionSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionSettings(document.RootElement, options);
        }

        internal static EncryptionSettings DeserializeEncryptionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string containerAppAuthEncryptionSecretName = default;
            string containerAppAuthSigningSecretName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerAppAuthEncryptionSecretName"u8))
                {
                    containerAppAuthEncryptionSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerAppAuthSigningSecretName"u8))
                {
                    containerAppAuthSigningSecretName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EncryptionSettings(containerAppAuthEncryptionSecretName, containerAppAuthSigningSecretName, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerAppAuthEncryptionSecretName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  containerAppAuthEncryptionSecretName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContainerAppAuthEncryptionSecretName))
                {
                    builder.Append("  containerAppAuthEncryptionSecretName: ");
                    if (ContainerAppAuthEncryptionSecretName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContainerAppAuthEncryptionSecretName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContainerAppAuthEncryptionSecretName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerAppAuthSigningSecretName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  containerAppAuthSigningSecretName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContainerAppAuthSigningSecretName))
                {
                    builder.Append("  containerAppAuthSigningSecretName: ");
                    if (ContainerAppAuthSigningSecretName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContainerAppAuthSigningSecretName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContainerAppAuthSigningSecretName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EncryptionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EncryptionSettings)} does not support writing '{options.Format}' format.");
            }
        }

        EncryptionSettings IPersistableModel<EncryptionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncryptionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEncryptionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EncryptionSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncryptionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
