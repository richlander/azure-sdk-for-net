// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class InsightsTableResult : IUtf8JsonSerializable, IJsonModel<InsightsTableResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InsightsTableResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InsightsTableResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightsTableResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InsightsTableResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Rows))
            {
                writer.WritePropertyName("rows"u8);
                writer.WriteStartArray();
                foreach (var item in Rows)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
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

        InsightsTableResult IJsonModel<InsightsTableResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightsTableResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InsightsTableResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInsightsTableResult(document.RootElement, options);
        }

        internal static InsightsTableResult DeserializeInsightsTableResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InsightsTableResultColumnsItem> columns = default;
            IReadOnlyList<IList<string>> rows = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InsightsTableResultColumnsItem> array = new List<InsightsTableResultColumnsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InsightsTableResultColumnsItem.DeserializeInsightsTableResultColumnsItem(item, options));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("rows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<string>> array = new List<IList<string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<string> array0 = new List<string>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(item0.GetString());
                            }
                            array.Add(array0);
                        }
                    }
                    rows = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InsightsTableResult(columns ?? new ChangeTrackingList<InsightsTableResultColumnsItem>(), rows ?? new ChangeTrackingList<IList<string>>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Columns), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  columns: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Columns))
                {
                    if (Columns.Any())
                    {
                        builder.Append("  columns: ");
                        builder.AppendLine("[");
                        foreach (var item in Columns)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  columns: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rows), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rows: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Rows))
                {
                    if (Rows.Any())
                    {
                        builder.Append("  rows: ");
                        builder.AppendLine("[");
                        foreach (var item in Rows)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item)
                            {
                                if (item0 == null)
                                {
                                    builder.Append("null");
                                    continue;
                                }
                                if (item0.Contains(Environment.NewLine))
                                {
                                    builder.AppendLine("    '''");
                                    builder.AppendLine($"{item0}'''");
                                }
                                else
                                {
                                    builder.AppendLine($"    '{item0}'");
                                }
                            }
                            builder.AppendLine("  ]");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<InsightsTableResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightsTableResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InsightsTableResult)} does not support writing '{options.Format}' format.");
            }
        }

        InsightsTableResult IPersistableModel<InsightsTableResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InsightsTableResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInsightsTableResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InsightsTableResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InsightsTableResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
