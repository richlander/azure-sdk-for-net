// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerSecurityContextDefinition : IUtf8JsonSerializable, IJsonModel<ContainerSecurityContextDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerSecurityContextDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerSecurityContextDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsPrivileged))
            {
                writer.WritePropertyName("privileged"u8);
                writer.WriteBooleanValue(IsPrivileged.Value);
            }
            if (Optional.IsDefined(AllowPrivilegeEscalation))
            {
                writer.WritePropertyName("allowPrivilegeEscalation"u8);
                writer.WriteBooleanValue(AllowPrivilegeEscalation.Value);
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities, options);
            }
            if (Optional.IsDefined(RunAsGroup))
            {
                writer.WritePropertyName("runAsGroup"u8);
                writer.WriteNumberValue(RunAsGroup.Value);
            }
            if (Optional.IsDefined(RunAsUser))
            {
                writer.WritePropertyName("runAsUser"u8);
                writer.WriteNumberValue(RunAsUser.Value);
            }
            if (Optional.IsDefined(SeccompProfile))
            {
                writer.WritePropertyName("seccompProfile"u8);
                writer.WriteStringValue(SeccompProfile);
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

        ContainerSecurityContextDefinition IJsonModel<ContainerSecurityContextDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerSecurityContextDefinition(document.RootElement, options);
        }

        internal static ContainerSecurityContextDefinition DeserializeContainerSecurityContextDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? privileged = default;
            bool? allowPrivilegeEscalation = default;
            ContainerSecurityContextCapabilitiesDefinition capabilities = default;
            int? runAsGroup = default;
            int? runAsUser = default;
            string seccompProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privileged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privileged = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPrivilegeEscalation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowPrivilegeEscalation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = ContainerSecurityContextCapabilitiesDefinition.DeserializeContainerSecurityContextCapabilitiesDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("runAsGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runAsGroup = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("runAsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runAsUser = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("seccompProfile"u8))
                {
                    seccompProfile = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerSecurityContextDefinition(
                privileged,
                allowPrivilegeEscalation,
                capabilities,
                runAsGroup,
                runAsUser,
                seccompProfile,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerSecurityContextDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerSecurityContextDefinition IPersistableModel<ContainerSecurityContextDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerSecurityContextDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerSecurityContextDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerSecurityContextDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerSecurityContextDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
