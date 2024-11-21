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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class SparkProfile : IUtf8JsonSerializable, IJsonModel<SparkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SparkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DefaultStorageUriString))
            {
                writer.WritePropertyName("defaultStorageUrl"u8);
                writer.WriteStringValue(DefaultStorageUriString);
            }
            if (Optional.IsDefined(MetastoreSpec))
            {
                writer.WritePropertyName("metastoreSpec"u8);
                writer.WriteObjectValue(MetastoreSpec, options);
            }
            if (Optional.IsDefined(UserPluginsSpec))
            {
                writer.WritePropertyName("userPluginsSpec"u8);
                writer.WriteObjectValue(UserPluginsSpec, options);
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

        SparkProfile IJsonModel<SparkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkProfile(document.RootElement, options);
        }

        internal static SparkProfile DeserializeSparkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string defaultStorageUrl = default;
            SparkMetastoreSpec metastoreSpec = default;
            SparkUserPluginListResult userPluginsSpec = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultStorageUrl"u8))
                {
                    defaultStorageUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metastoreSpec = SparkMetastoreSpec.DeserializeSparkMetastoreSpec(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userPluginsSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userPluginsSpec = SparkUserPluginListResult.DeserializeSparkUserPluginListResult(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SparkProfile(defaultStorageUrl, metastoreSpec, userPluginsSpec, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultStorageUriString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultStorageUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultStorageUriString))
                {
                    builder.Append("  defaultStorageUrl: ");
                    if (DefaultStorageUriString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DefaultStorageUriString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DefaultStorageUriString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MetastoreSpec), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metastoreSpec: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MetastoreSpec))
                {
                    builder.Append("  metastoreSpec: ");
                    BicepSerializationHelpers.AppendChildObject(builder, MetastoreSpec, options, 2, false, "  metastoreSpec: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("Plugins", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userPluginsSpec: ");
                builder.AppendLine("{");
                builder.Append("    plugins: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(UserPluginsSpec))
                {
                    builder.Append("  userPluginsSpec: ");
                    BicepSerializationHelpers.AppendChildObject(builder, UserPluginsSpec, options, 2, false, "  userPluginsSpec: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SparkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SparkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        SparkProfile IPersistableModel<SparkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSparkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SparkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SparkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
