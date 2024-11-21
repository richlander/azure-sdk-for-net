// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class ReservationOrderAliasRequestPropertiesReservedResourceProperties : IUtf8JsonSerializable, IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
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

        ReservationOrderAliasRequestPropertiesReservedResourceProperties IJsonModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(document.RootElement, options);
        }

        internal static ReservationOrderAliasRequestPropertiesReservedResourceProperties DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsInstanceFlexibility? instanceFlexibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceFlexibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceFlexibility = new BillingBenefitsInstanceFlexibility(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReservationOrderAliasRequestPropertiesReservedResourceProperties(instanceFlexibility, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ReservationOrderAliasRequestPropertiesReservedResourceProperties IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationOrderAliasRequestPropertiesReservedResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationOrderAliasRequestPropertiesReservedResourceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationOrderAliasRequestPropertiesReservedResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
