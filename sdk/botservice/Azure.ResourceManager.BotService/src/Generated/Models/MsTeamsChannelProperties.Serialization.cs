// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class MsTeamsChannelProperties : IUtf8JsonSerializable, IJsonModel<MsTeamsChannelProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MsTeamsChannelProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MsTeamsChannelProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsTeamsChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsTeamsChannelProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsCallingEnabled))
            {
                writer.WritePropertyName("enableCalling"u8);
                writer.WriteBooleanValue(IsCallingEnabled.Value);
            }
            if (Optional.IsDefined(CallingWebhook))
            {
                writer.WritePropertyName("callingWebhook"u8);
                writer.WriteStringValue(CallingWebhook);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(IncomingCallRoute))
            {
                writer.WritePropertyName("incomingCallRoute"u8);
                writer.WriteStringValue(IncomingCallRoute);
            }
            if (Optional.IsDefined(DeploymentEnvironment))
            {
                writer.WritePropertyName("deploymentEnvironment"u8);
                writer.WriteStringValue(DeploymentEnvironment);
            }
            if (Optional.IsDefined(AcceptedTerms))
            {
                if (AcceptedTerms != null)
                {
                    writer.WritePropertyName("acceptedTerms"u8);
                    writer.WriteBooleanValue(AcceptedTerms.Value);
                }
                else
                {
                    writer.WriteNull("acceptedTerms");
                }
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

        MsTeamsChannelProperties IJsonModel<MsTeamsChannelProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsTeamsChannelProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MsTeamsChannelProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMsTeamsChannelProperties(document.RootElement, options);
        }

        internal static MsTeamsChannelProperties DeserializeMsTeamsChannelProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableCalling = default;
            string callingWebhook = default;
            bool isEnabled = default;
            string incomingCallRoute = default;
            string deploymentEnvironment = default;
            bool? acceptedTerms = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableCalling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCalling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("callingWebhook"u8))
                {
                    callingWebhook = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("incomingCallRoute"u8))
                {
                    incomingCallRoute = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentEnvironment"u8))
                {
                    deploymentEnvironment = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceptedTerms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        acceptedTerms = null;
                        continue;
                    }
                    acceptedTerms = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MsTeamsChannelProperties(
                enableCalling,
                callingWebhook,
                isEnabled,
                incomingCallRoute,
                deploymentEnvironment,
                acceptedTerms,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MsTeamsChannelProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsTeamsChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MsTeamsChannelProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MsTeamsChannelProperties IPersistableModel<MsTeamsChannelProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MsTeamsChannelProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMsTeamsChannelProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MsTeamsChannelProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MsTeamsChannelProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
