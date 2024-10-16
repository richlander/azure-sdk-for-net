// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerVirtualNetworkSubnetUsageResult : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(DelegatedSubnetsUsage))
            {
                writer.WritePropertyName("delegatedSubnetsUsage"u8);
                writer.WriteStartArray();
                foreach (var item in DelegatedSubnetsUsage)
                {
                    writer.WriteObjectValue(item, options);
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

        MySqlFlexibleServerVirtualNetworkSubnetUsageResult IJsonModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(document.RootElement, options);
        }

        internal static MySqlFlexibleServerVirtualNetworkSubnetUsageResult DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            string subscriptionId = default;
            IReadOnlyList<MySqlFlexibleServerDelegatedSubnetUsage> delegatedSubnetsUsage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delegatedSubnetsUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerDelegatedSubnetUsage> array = new List<MySqlFlexibleServerDelegatedSubnetUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerDelegatedSubnetUsage.DeserializeMySqlFlexibleServerDelegatedSubnetUsage(item, options));
                    }
                    delegatedSubnetsUsage = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MySqlFlexibleServerVirtualNetworkSubnetUsageResult(location, subscriptionId, delegatedSubnetsUsage ?? new ChangeTrackingList<MySqlFlexibleServerDelegatedSubnetUsage>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerVirtualNetworkSubnetUsageResult IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerVirtualNetworkSubnetUsageResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerVirtualNetworkSubnetUsageResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerVirtualNetworkSubnetUsageResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
