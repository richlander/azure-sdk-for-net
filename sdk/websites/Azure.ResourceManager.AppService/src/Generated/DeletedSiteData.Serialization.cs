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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class DeletedSiteData : IUtf8JsonSerializable, IJsonModel<DeletedSiteData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeletedSiteData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeletedSiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedSiteData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeletedSiteData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DeletedSiteId))
            {
                writer.WritePropertyName("deletedSiteId"u8);
                writer.WriteNumberValue(DeletedSiteId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DeletedTimestamp))
            {
                writer.WritePropertyName("deletedTimestamp"u8);
                writer.WriteStringValue(DeletedTimestamp);
            }
            if (options.Format != "W" && Optional.IsDefined(Subscription))
            {
                writer.WritePropertyName("subscription"u8);
                writer.WriteStringValue(Subscription);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(DeletedSiteName))
            {
                writer.WritePropertyName("deletedSiteName"u8);
                writer.WriteStringValue(DeletedSiteName);
            }
            if (options.Format != "W" && Optional.IsDefined(Slot))
            {
                writer.WritePropertyName("slot"u8);
                writer.WriteStringValue(Slot);
            }
            if (options.Format != "W" && Optional.IsDefined(KindPropertiesKind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(KindPropertiesKind);
            }
            if (options.Format != "W" && Optional.IsDefined(GeoRegionName))
            {
                writer.WritePropertyName("geoRegionName"u8);
                writer.WriteStringValue(GeoRegionName);
            }
            writer.WriteEndObject();
        }

        DeletedSiteData IJsonModel<DeletedSiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedSiteData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeletedSiteData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeletedSiteData(document.RootElement, options);
        }

        internal static DeletedSiteData DeserializeDeletedSiteData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? deletedSiteId = default;
            string deletedTimestamp = default;
            string subscription = default;
            string resourceGroup = default;
            string deletedSiteName = default;
            string slot = default;
            string kind0 = default;
            string geoRegionName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("deletedSiteId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deletedSiteId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("deletedTimestamp"u8))
                        {
                            deletedTimestamp = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscription"u8))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deletedSiteName"u8))
                        {
                            deletedSiteName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("slot"u8))
                        {
                            slot = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kind"u8))
                        {
                            kind0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geoRegionName"u8))
                        {
                            geoRegionName = property0.Value.GetString();
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
            return new DeletedSiteData(
                id,
                name,
                type,
                systemData,
                deletedSiteId,
                deletedTimestamp,
                subscription,
                resourceGroup,
                deletedSiteName,
                slot,
                kind0,
                geoRegionName,
                kind,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
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
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeletedSiteId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deletedSiteId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeletedSiteId))
                {
                    builder.Append("    deletedSiteId: ");
                    builder.AppendLine($"{DeletedSiteId.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeletedTimestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deletedTimestamp: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeletedTimestamp))
                {
                    builder.Append("    deletedTimestamp: ");
                    if (DeletedTimestamp.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DeletedTimestamp}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DeletedTimestamp}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Subscription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    subscription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Subscription))
                {
                    builder.Append("    subscription: ");
                    if (Subscription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Subscription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Subscription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceGroup), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceGroup: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceGroup))
                {
                    builder.Append("    resourceGroup: ");
                    if (ResourceGroup.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ResourceGroup}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ResourceGroup}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeletedSiteName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deletedSiteName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeletedSiteName))
                {
                    builder.Append("    deletedSiteName: ");
                    if (DeletedSiteName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DeletedSiteName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DeletedSiteName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Slot), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    slot: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Slot))
                {
                    builder.Append("    slot: ");
                    if (Slot.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Slot}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Slot}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KindPropertiesKind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KindPropertiesKind))
                {
                    builder.Append("    kind: ");
                    if (KindPropertiesKind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KindPropertiesKind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KindPropertiesKind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GeoRegionName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    geoRegionName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GeoRegionName))
                {
                    builder.Append("    geoRegionName: ");
                    if (GeoRegionName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GeoRegionName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GeoRegionName}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeletedSiteData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedSiteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeletedSiteData)} does not support writing '{options.Format}' format.");
            }
        }

        DeletedSiteData IPersistableModel<DeletedSiteData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedSiteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeletedSiteData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeletedSiteData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeletedSiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
