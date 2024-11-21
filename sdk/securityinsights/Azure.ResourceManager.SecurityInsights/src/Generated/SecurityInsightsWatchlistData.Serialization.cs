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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsWatchlistData : IUtf8JsonSerializable, IJsonModel<SecurityInsightsWatchlistData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsWatchlistData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsWatchlistData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WatchlistId))
            {
                writer.WritePropertyName("watchlistId"u8);
                writer.WriteStringValue(WatchlistId.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(SourceString))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(SourceString);
            }
            if (Optional.IsDefined(SourceType))
            {
                writer.WritePropertyName("sourceType"u8);
                writer.WriteStringValue(SourceType.Value.ToString());
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteObjectValue(CreatedBy, options);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteObjectValue(UpdatedBy, options);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(WatchlistType))
            {
                writer.WritePropertyName("watchlistType"u8);
                writer.WriteStringValue(WatchlistType);
            }
            if (Optional.IsDefined(WatchlistAlias))
            {
                writer.WritePropertyName("watchlistAlias"u8);
                writer.WriteStringValue(WatchlistAlias);
            }
            if (Optional.IsDefined(IsDeleted))
            {
                writer.WritePropertyName("isDeleted"u8);
                writer.WriteBooleanValue(IsDeleted.Value);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultDuration))
            {
                writer.WritePropertyName("defaultDuration"u8);
                writer.WriteStringValue(DefaultDuration.Value, "P");
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(NumberOfLinesToSkip))
            {
                writer.WritePropertyName("numberOfLinesToSkip"u8);
                writer.WriteNumberValue(NumberOfLinesToSkip.Value);
            }
            if (Optional.IsDefined(RawContent))
            {
                writer.WritePropertyName("rawContent"u8);
                writer.WriteStringValue(RawContent);
            }
            if (Optional.IsDefined(ItemsSearchKey))
            {
                writer.WritePropertyName("itemsSearchKey"u8);
                writer.WriteStringValue(ItemsSearchKey);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(UploadStatus))
            {
                writer.WritePropertyName("uploadStatus"u8);
                writer.WriteStringValue(UploadStatus);
            }
            writer.WriteEndObject();
        }

        SecurityInsightsWatchlistData IJsonModel<SecurityInsightsWatchlistData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsWatchlistData(document.RootElement, options);
        }

        internal static SecurityInsightsWatchlistData DeserializeSecurityInsightsWatchlistData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Guid? watchlistId = default;
            string displayName = default;
            string provider = default;
            string source = default;
            WatchlistSourceType? sourceType = default;
            DateTimeOffset? created = default;
            DateTimeOffset? updated = default;
            SecurityInsightsUserInfo createdBy = default;
            SecurityInsightsUserInfo updatedBy = default;
            string description = default;
            string watchlistType = default;
            string watchlistAlias = default;
            bool? isDeleted = default;
            IList<string> labels = default;
            TimeSpan? defaultDuration = default;
            Guid? tenantId = default;
            int? numberOfLinesToSkip = default;
            string rawContent = default;
            string itemsSearchKey = default;
            string contentType = default;
            string uploadStatus = default;
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
                        if (property0.NameEquals("watchlistId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            watchlistId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceType = new WatchlistSourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistType"u8))
                        {
                            watchlistType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistAlias"u8))
                        {
                            watchlistAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDeleted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("numberOfLinesToSkip"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfLinesToSkip = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rawContent"u8))
                        {
                            rawContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("itemsSearchKey"u8))
                        {
                            itemsSearchKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentType"u8))
                        {
                            contentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uploadStatus"u8))
                        {
                            uploadStatus = property0.Value.GetString();
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
            return new SecurityInsightsWatchlistData(
                id,
                name,
                type,
                systemData,
                watchlistId,
                displayName,
                provider,
                source,
                sourceType,
                created,
                updated,
                createdBy,
                updatedBy,
                description,
                watchlistType,
                watchlistAlias,
                isDeleted,
                labels ?? new ChangeTrackingList<string>(),
                defaultDuration,
                tenantId,
                numberOfLinesToSkip,
                rawContent,
                itemsSearchKey,
                contentType,
                uploadStatus,
                etag,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WatchlistId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    watchlistId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WatchlistId))
                {
                    builder.Append("    watchlistId: ");
                    builder.AppendLine($"'{WatchlistId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Provider), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provider: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Provider))
                {
                    builder.Append("    provider: ");
                    if (Provider.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Provider}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Provider}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    source: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceString))
                {
                    builder.Append("    source: ");
                    if (SourceString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SourceString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SourceString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sourceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceType))
                {
                    builder.Append("    sourceType: ");
                    builder.AppendLine($"'{SourceType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    created: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("    created: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    updated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdatedOn))
                {
                    builder.Append("    updated: ");
                    var formattedDateTimeString = TypeFormatters.ToString(UpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createdBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedBy))
                {
                    builder.Append("    createdBy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CreatedBy, options, 4, false, "    createdBy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdatedBy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    updatedBy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdatedBy))
                {
                    builder.Append("    updatedBy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, UpdatedBy, options, 4, false, "    updatedBy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WatchlistType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    watchlistType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WatchlistType))
                {
                    builder.Append("    watchlistType: ");
                    if (WatchlistType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WatchlistType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WatchlistType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WatchlistAlias), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    watchlistAlias: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WatchlistAlias))
                {
                    builder.Append("    watchlistAlias: ");
                    if (WatchlistAlias.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WatchlistAlias}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WatchlistAlias}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDeleted), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isDeleted: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDeleted))
                {
                    builder.Append("    isDeleted: ");
                    var boolValue = IsDeleted.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Labels), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    labels: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Labels))
                {
                    if (Labels.Any())
                    {
                        builder.Append("    labels: ");
                        builder.AppendLine("[");
                        foreach (var item in Labels)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultDuration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    defaultDuration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultDuration))
                {
                    builder.Append("    defaultDuration: ");
                    var formattedTimeSpan = TypeFormatters.ToString(DefaultDuration.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    tenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TenantId))
                {
                    builder.Append("    tenantId: ");
                    builder.AppendLine($"'{TenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NumberOfLinesToSkip), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    numberOfLinesToSkip: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NumberOfLinesToSkip))
                {
                    builder.Append("    numberOfLinesToSkip: ");
                    builder.AppendLine($"{NumberOfLinesToSkip.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RawContent), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    rawContent: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RawContent))
                {
                    builder.Append("    rawContent: ");
                    if (RawContent.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RawContent}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RawContent}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ItemsSearchKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    itemsSearchKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ItemsSearchKey))
                {
                    builder.Append("    itemsSearchKey: ");
                    if (ItemsSearchKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ItemsSearchKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ItemsSearchKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContentType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    contentType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContentType))
                {
                    builder.Append("    contentType: ");
                    if (ContentType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContentType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContentType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UploadStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    uploadStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UploadStatus))
                {
                    builder.Append("    uploadStatus: ");
                    if (UploadStatus.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UploadStatus}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UploadStatus}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsWatchlistData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsWatchlistData IPersistableModel<SecurityInsightsWatchlistData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsWatchlistData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsWatchlistData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsWatchlistData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsWatchlistData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
