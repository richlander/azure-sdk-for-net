// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    public partial class AwsCloudProfile : IUtf8JsonSerializable, IJsonModel<AwsCloudProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AwsCloudProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AwsCloudProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsCloudProfile)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("accountId"u8);
            writer.WriteStringValue(AccountId);
            if (Optional.IsCollectionDefined(ExcludedAccounts))
            {
                writer.WritePropertyName("excludedAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedAccounts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsOrganizationalAccount))
            {
                writer.WritePropertyName("isOrganizationalAccount"u8);
                writer.WriteBooleanValue(IsOrganizationalAccount.Value);
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

        AwsCloudProfile IJsonModel<AwsCloudProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsCloudProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsCloudProfile(document.RootElement, options);
        }

        internal static AwsCloudProfile DeserializeAwsCloudProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountId = default;
            IList<string> excludedAccounts = default;
            bool? isOrganizationalAccount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludedAccounts = array;
                    continue;
                }
                if (property.NameEquals("isOrganizationalAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOrganizationalAccount = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AwsCloudProfile(accountId, excludedAccounts ?? new ChangeTrackingList<string>(), isOrganizationalAccount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AwsCloudProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AwsCloudProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AwsCloudProfile IPersistableModel<AwsCloudProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsCloudProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAwsCloudProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AwsCloudProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AwsCloudProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
