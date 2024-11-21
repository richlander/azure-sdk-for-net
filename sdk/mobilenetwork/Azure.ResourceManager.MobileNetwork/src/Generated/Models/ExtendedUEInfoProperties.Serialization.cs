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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    [PersistableModelProxy(typeof(UnknownExtendedUEInfoProperties))]
    public partial class ExtendedUEInfoProperties : IUtf8JsonSerializable, IJsonModel<ExtendedUEInfoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedUEInfoProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtendedUEInfoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedUEInfoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedUEInfoProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("ratType"u8);
            writer.WriteStringValue(RatType.ToString());
            if (Optional.IsDefined(LastReadOn))
            {
                writer.WritePropertyName("lastReadAt"u8);
                writer.WriteStringValue(LastReadOn.Value, "O");
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

        ExtendedUEInfoProperties IJsonModel<ExtendedUEInfoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedUEInfoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedUEInfoProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedUEInfoProperties(document.RootElement, options);
        }

        internal static ExtendedUEInfoProperties DeserializeExtendedUEInfoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ratType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "4G": return UEInfo4G.DeserializeUEInfo4G(element, options);
                    case "5G": return UEInfo5G.DeserializeUEInfo5G(element, options);
                }
            }
            return UnknownExtendedUEInfoProperties.DeserializeUnknownExtendedUEInfoProperties(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RatType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ratType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  ratType: ");
                builder.AppendLine($"'{RatType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastReadOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastReadAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastReadOn))
                {
                    builder.Append("  lastReadAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastReadOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExtendedUEInfoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedUEInfoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedUEInfoProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedUEInfoProperties IPersistableModel<ExtendedUEInfoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedUEInfoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedUEInfoProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedUEInfoProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedUEInfoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
