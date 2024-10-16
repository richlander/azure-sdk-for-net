// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ScheduledEventsPolicy : IUtf8JsonSerializable, IJsonModel<ScheduledEventsPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScheduledEventsPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScheduledEventsPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledEventsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledEventsPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UserInitiatedRedeploy))
            {
                writer.WritePropertyName("userInitiatedRedeploy"u8);
                writer.WriteObjectValue(UserInitiatedRedeploy, options);
            }
            if (Optional.IsDefined(UserInitiatedReboot))
            {
                writer.WritePropertyName("userInitiatedReboot"u8);
                writer.WriteObjectValue(UserInitiatedReboot, options);
            }
            if (Optional.IsDefined(ScheduledEventsAdditionalPublishingTargets))
            {
                writer.WritePropertyName("scheduledEventsAdditionalPublishingTargets"u8);
                writer.WriteObjectValue(ScheduledEventsAdditionalPublishingTargets, options);
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

        ScheduledEventsPolicy IJsonModel<ScheduledEventsPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledEventsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScheduledEventsPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledEventsPolicy(document.RootElement, options);
        }

        internal static ScheduledEventsPolicy DeserializeScheduledEventsPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UserInitiatedRedeploy userInitiatedRedeploy = default;
            UserInitiatedReboot userInitiatedReboot = default;
            ScheduledEventsAdditionalPublishingTargets scheduledEventsAdditionalPublishingTargets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userInitiatedRedeploy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userInitiatedRedeploy = UserInitiatedRedeploy.DeserializeUserInitiatedRedeploy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userInitiatedReboot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userInitiatedReboot = UserInitiatedReboot.DeserializeUserInitiatedReboot(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scheduledEventsAdditionalPublishingTargets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledEventsAdditionalPublishingTargets = ScheduledEventsAdditionalPublishingTargets.DeserializeScheduledEventsAdditionalPublishingTargets(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ScheduledEventsPolicy(userInitiatedRedeploy, userInitiatedReboot, scheduledEventsAdditionalPublishingTargets, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScheduledEventsPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledEventsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScheduledEventsPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ScheduledEventsPolicy IPersistableModel<ScheduledEventsPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScheduledEventsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScheduledEventsPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScheduledEventsPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScheduledEventsPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
