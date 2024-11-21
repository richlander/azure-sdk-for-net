// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchApplicationPackageData : IUtf8JsonSerializable, IJsonModel<BatchApplicationPackageData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchApplicationPackageData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchApplicationPackageData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchApplicationPackageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchApplicationPackageData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageUri))
            {
                writer.WritePropertyName("storageUrl"u8);
                writer.WriteStringValue(StorageUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageUriExpireOn))
            {
                writer.WritePropertyName("storageUrlExpiry"u8);
                writer.WriteStringValue(StorageUriExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastActivatedOn))
            {
                writer.WritePropertyName("lastActivationTime"u8);
                writer.WriteStringValue(LastActivatedOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        BatchApplicationPackageData IJsonModel<BatchApplicationPackageData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchApplicationPackageData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchApplicationPackageData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchApplicationPackageData(document.RootElement, options);
        }

        internal static BatchApplicationPackageData DeserializeBatchApplicationPackageData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            BatchApplicationPackageState? state = default;
            string format = default;
            Uri storageUrl = default;
            DateTimeOffset? storageUrlExpiry = default;
            DateTimeOffset? lastActivationTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToBatchApplicationPackageState();
                            continue;
                        }
                        if (property0.NameEquals("format"u8))
                        {
                            format = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageUrlExpiry"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageUrlExpiry = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastActivationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastActivationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchApplicationPackageData(
                id,
                name,
                type,
                systemData,
                state,
                format,
                storageUrl,
                storageUrlExpiry,
                lastActivationTime,
                etag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchApplicationPackageData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchApplicationPackageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchApplicationPackageData)} does not support writing '{options.Format}' format.");
            }
        }

        BatchApplicationPackageData IPersistableModel<BatchApplicationPackageData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchApplicationPackageData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchApplicationPackageData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchApplicationPackageData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchApplicationPackageData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
