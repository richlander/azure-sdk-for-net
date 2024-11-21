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
    public partial class SecurityAlertTimelineItem : IUtf8JsonSerializable, IJsonModel<SecurityAlertTimelineItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAlertTimelineItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityAlertTimelineItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertTimelineItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAlertTimelineItem)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("azureResourceId"u8);
            writer.WriteStringValue(AzureResourceId);
            if (Optional.IsDefined(ProductName))
            {
                writer.WritePropertyName("productName"u8);
                writer.WriteStringValue(ProductName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("severity"u8);
            writer.WriteStringValue(Severity.ToString());
            writer.WritePropertyName("endTimeUtc"u8);
            writer.WriteStringValue(EndOn, "O");
            writer.WritePropertyName("startTimeUtc"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("timeGenerated"u8);
            writer.WriteStringValue(GeneratedOn, "O");
            writer.WritePropertyName("alertType"u8);
            writer.WriteStringValue(AlertType);
            if (options.Format != "W" && Optional.IsDefined(Intent))
            {
                writer.WritePropertyName("intent"u8);
                writer.WriteStringValue(Intent.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
        }

        SecurityAlertTimelineItem IJsonModel<SecurityAlertTimelineItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertTimelineItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAlertTimelineItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAlertTimelineItem(document.RootElement, options);
        }

        internal static SecurityAlertTimelineItem DeserializeSecurityAlertTimelineItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier azureResourceId = default;
            string productName = default;
            string description = default;
            string displayName = default;
            SecurityInsightsAlertSeverity severity = default;
            DateTimeOffset endTimeUtc = default;
            DateTimeOffset startTimeUtc = default;
            DateTimeOffset timeGenerated = default;
            string alertType = default;
            SecurityInsightsKillChainIntent? intent = default;
            IReadOnlyList<string> techniques = default;
            EntityTimelineKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureResourceId"u8))
                {
                    azureResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("productName"u8))
                {
                    productName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = new SecurityInsightsAlertSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endTimeUtc"u8))
                {
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    startTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeGenerated"u8))
                {
                    timeGenerated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("alertType"u8))
                {
                    alertType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intent = new SecurityInsightsKillChainIntent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("techniques"u8))
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
                    techniques = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EntityTimelineKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityAlertTimelineItem(
                kind,
                serializedAdditionalRawData,
                azureResourceId,
                productName,
                description,
                displayName,
                severity,
                endTimeUtc,
                startTimeUtc,
                timeGenerated,
                alertType,
                intent,
                techniques ?? new ChangeTrackingList<string>());
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureResourceId))
                {
                    builder.Append("  azureResourceId: ");
                    builder.AppendLine($"'{AzureResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProductName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  productName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProductName))
                {
                    builder.Append("  productName: ");
                    if (ProductName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProductName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProductName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Severity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  severity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  severity: ");
                builder.AppendLine($"'{Severity.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  endTimeUtc: ");
                var formattedDateTimeString = TypeFormatters.ToString(EndOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTimeUtc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  startTimeUtc: ");
                var formattedDateTimeString = TypeFormatters.ToString(StartOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeneratedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeGenerated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  timeGenerated: ");
                var formattedDateTimeString = TypeFormatters.ToString(GeneratedOn, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alertType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertType))
                {
                    builder.Append("  alertType: ");
                    if (AlertType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AlertType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AlertType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Intent), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  intent: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Intent))
                {
                    builder.Append("  intent: ");
                    builder.AppendLine($"'{Intent.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Techniques), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  techniques: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Techniques))
                {
                    if (Techniques.Any())
                    {
                        builder.Append("  techniques: ");
                        builder.AppendLine("[");
                        foreach (var item in Techniques)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityAlertTimelineItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertTimelineItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAlertTimelineItem)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAlertTimelineItem IPersistableModel<SecurityAlertTimelineItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAlertTimelineItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAlertTimelineItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAlertTimelineItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAlertTimelineItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
