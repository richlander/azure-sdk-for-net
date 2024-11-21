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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteConfigPropertiesDictionary : IUtf8JsonSerializable, IJsonModel<SiteConfigPropertiesDictionary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteConfigPropertiesDictionary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteConfigPropertiesDictionary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteConfigPropertiesDictionary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteConfigPropertiesDictionary)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Use32BitWorkerProcess))
            {
                writer.WritePropertyName("use32BitWorkerProcess"u8);
                writer.WriteBooleanValue(Use32BitWorkerProcess.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LinuxFxVersion))
            {
                writer.WritePropertyName("linuxFxVersion"u8);
                writer.WriteStringValue(LinuxFxVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(JavaVersion))
            {
                writer.WritePropertyName("javaVersion"u8);
                writer.WriteStringValue(JavaVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(PowerShellVersion))
            {
                writer.WritePropertyName("powerShellVersion"u8);
                writer.WriteStringValue(PowerShellVersion);
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

        SiteConfigPropertiesDictionary IJsonModel<SiteConfigPropertiesDictionary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteConfigPropertiesDictionary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteConfigPropertiesDictionary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteConfigPropertiesDictionary(document.RootElement, options);
        }

        internal static SiteConfigPropertiesDictionary DeserializeSiteConfigPropertiesDictionary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? use32BitWorkerProcess = default;
            string linuxFxVersion = default;
            string javaVersion = default;
            string powerShellVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("use32BitWorkerProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    use32BitWorkerProcess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linuxFxVersion"u8))
                {
                    linuxFxVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("javaVersion"u8))
                {
                    javaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerShellVersion"u8))
                {
                    powerShellVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteConfigPropertiesDictionary(use32BitWorkerProcess, linuxFxVersion, javaVersion, powerShellVersion, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Use32BitWorkerProcess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  use32BitWorkerProcess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Use32BitWorkerProcess))
                {
                    builder.Append("  use32BitWorkerProcess: ");
                    var boolValue = Use32BitWorkerProcess.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LinuxFxVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  linuxFxVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LinuxFxVersion))
                {
                    builder.Append("  linuxFxVersion: ");
                    if (LinuxFxVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LinuxFxVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LinuxFxVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JavaVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  javaVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(JavaVersion))
                {
                    builder.Append("  javaVersion: ");
                    if (JavaVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{JavaVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{JavaVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PowerShellVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  powerShellVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PowerShellVersion))
                {
                    builder.Append("  powerShellVersion: ");
                    if (PowerShellVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PowerShellVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PowerShellVersion}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SiteConfigPropertiesDictionary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteConfigPropertiesDictionary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteConfigPropertiesDictionary)} does not support writing '{options.Format}' format.");
            }
        }

        SiteConfigPropertiesDictionary IPersistableModel<SiteConfigPropertiesDictionary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteConfigPropertiesDictionary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteConfigPropertiesDictionary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteConfigPropertiesDictionary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteConfigPropertiesDictionary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
