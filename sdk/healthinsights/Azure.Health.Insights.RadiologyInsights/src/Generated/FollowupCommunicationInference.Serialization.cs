// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FollowupCommunicationInference : IUtf8JsonSerializable, IJsonModel<FollowupCommunicationInference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FollowupCommunicationInference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FollowupCommunicationInference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupCommunicationInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FollowupCommunicationInference)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(CommunicatedAt))
            {
                writer.WritePropertyName("communicatedAt"u8);
                writer.WriteStartArray();
                foreach (var item in CommunicatedAt)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Recipient))
            {
                writer.WritePropertyName("recipient"u8);
                writer.WriteStartArray();
                foreach (var item in Recipient)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("wasAcknowledged"u8);
            writer.WriteBooleanValue(WasAcknowledged);
        }

        FollowupCommunicationInference IJsonModel<FollowupCommunicationInference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupCommunicationInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FollowupCommunicationInference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFollowupCommunicationInference(document.RootElement, options);
        }

        internal static FollowupCommunicationInference DeserializeFollowupCommunicationInference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DateTimeOffset> communicatedAt = default;
            IReadOnlyList<MedicalProfessionalType> recipient = default;
            bool wasAcknowledged = default;
            RadiologyInsightsInferenceType kind = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("communicatedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    communicatedAt = array;
                    continue;
                }
                if (property.NameEquals("recipient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MedicalProfessionalType> array = new List<MedicalProfessionalType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MedicalProfessionalType(item.GetString()));
                    }
                    recipient = array;
                    continue;
                }
                if (property.NameEquals("wasAcknowledged"u8))
                {
                    wasAcknowledged = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new RadiologyInsightsInferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FollowupCommunicationInference(
                kind,
                extension ?? new ChangeTrackingList<FhirR4Extension>(),
                serializedAdditionalRawData,
                communicatedAt ?? new ChangeTrackingList<DateTimeOffset>(),
                recipient ?? new ChangeTrackingList<MedicalProfessionalType>(),
                wasAcknowledged);
        }

        BinaryData IPersistableModel<FollowupCommunicationInference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupCommunicationInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FollowupCommunicationInference)} does not support writing '{options.Format}' format.");
            }
        }

        FollowupCommunicationInference IPersistableModel<FollowupCommunicationInference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FollowupCommunicationInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFollowupCommunicationInference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FollowupCommunicationInference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FollowupCommunicationInference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FollowupCommunicationInference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFollowupCommunicationInference(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
