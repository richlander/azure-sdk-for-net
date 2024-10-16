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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class NrtAlertRuleTemplate : IUtf8JsonSerializable, IJsonModel<NrtAlertRuleTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NrtAlertRuleTemplate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NrtAlertRuleTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NrtAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NrtAlertRuleTemplate)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
            {
                writer.WritePropertyName("alertRulesCreatedByTemplateCount"u8);
                writer.WriteNumberValue(AlertRulesCreatedByTemplateCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedDateUTC"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDateUTC"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(RequiredDataConnectors))
            {
                writer.WritePropertyName("requiredDataConnectors"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredDataConnectors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsCollectionDefined(CustomDetails))
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteStartObject();
                foreach (var item in CustomDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(EntityMappings))
            {
                writer.WritePropertyName("entityMappings"u8);
                writer.WriteStartArray();
                foreach (var item in EntityMappings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AlertDetailsOverride))
            {
                writer.WritePropertyName("alertDetailsOverride"u8);
                writer.WriteObjectValue(AlertDetailsOverride, options);
            }
            if (Optional.IsDefined(EventGroupingSettings))
            {
                writer.WritePropertyName("eventGroupingSettings"u8);
                writer.WriteObjectValue(EventGroupingSettings, options);
            }
            if (Optional.IsCollectionDefined(SentinelEntitiesMappings))
            {
                writer.WritePropertyName("sentinelEntitiesMappings"u8);
                writer.WriteStartArray();
                foreach (var item in SentinelEntitiesMappings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        NrtAlertRuleTemplate IJsonModel<NrtAlertRuleTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NrtAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NrtAlertRuleTemplate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNrtAlertRuleTemplate(document.RootElement, options);
        }

        internal static NrtAlertRuleTemplate DeserializeNrtAlertRuleTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? alertRulesCreatedByTemplateCount = default;
            DateTimeOffset? lastUpdatedDateUTC = default;
            DateTimeOffset? createdDateUTC = default;
            string description = default;
            string displayName = default;
            IList<AlertRuleTemplateDataSource> requiredDataConnectors = default;
            SecurityInsightsAlertRuleTemplateStatus? status = default;
            IList<SecurityInsightsAttackTactic> tactics = default;
            IList<string> techniques = default;
            string query = default;
            SecurityInsightsAlertSeverity? severity = default;
            string version = default;
            IDictionary<string, string> customDetails = default;
            IList<SecurityInsightsAlertRuleEntityMapping> entityMappings = default;
            SecurityInsightsAlertDetailsOverride alertDetailsOverride = default;
            EventGroupingSettings eventGroupingSettings = default;
            IList<SentinelEntityMapping> sentinelEntitiesMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
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
                        if (property0.NameEquals("alertRulesCreatedByTemplateCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertRulesCreatedByTemplateCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdDateUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDateUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredDataConnectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AlertRuleTemplateDataSource> array = new List<AlertRuleTemplateDataSource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AlertRuleTemplateDataSource.DeserializeAlertRuleTemplateDataSource(item, options));
                            }
                            requiredDataConnectors = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SecurityInsightsAlertRuleTemplateStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
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
                            techniques = array;
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customDetails = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("entityMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertRuleEntityMapping> array = new List<SecurityInsightsAlertRuleEntityMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAlertRuleEntityMapping.DeserializeSecurityInsightsAlertRuleEntityMapping(item, options));
                            }
                            entityMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("alertDetailsOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertDetailsOverride = SecurityInsightsAlertDetailsOverride.DeserializeSecurityInsightsAlertDetailsOverride(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventGroupingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventGroupingSettings = EventGroupingSettings.DeserializeEventGroupingSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sentinelEntitiesMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SentinelEntityMapping> array = new List<SentinelEntityMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SentinelEntityMapping.DeserializeSentinelEntityMapping(item, options));
                            }
                            sentinelEntitiesMappings = array;
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
            return new NrtAlertRuleTemplate(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                alertRulesCreatedByTemplateCount,
                lastUpdatedDateUTC,
                createdDateUTC,
                description,
                displayName,
                requiredDataConnectors ?? new ChangeTrackingList<AlertRuleTemplateDataSource>(),
                status,
                tactics ?? new ChangeTrackingList<SecurityInsightsAttackTactic>(),
                techniques ?? new ChangeTrackingList<string>(),
                query,
                severity,
                version,
                customDetails ?? new ChangeTrackingDictionary<string, string>(),
                entityMappings ?? new ChangeTrackingList<SecurityInsightsAlertRuleEntityMapping>(),
                alertDetailsOverride,
                eventGroupingSettings,
                sentinelEntitiesMappings ?? new ChangeTrackingList<SentinelEntityMapping>());
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
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertRulesCreatedByTemplateCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    alertRulesCreatedByTemplateCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertRulesCreatedByTemplateCount))
                {
                    builder.Append("    alertRulesCreatedByTemplateCount: ");
                    builder.AppendLine($"{AlertRulesCreatedByTemplateCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastUpdatedDateUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdatedOn))
                {
                    builder.Append("    lastUpdatedDateUTC: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createdDateUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("    createdDateUTC: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiredDataConnectors), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    requiredDataConnectors: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(RequiredDataConnectors))
                {
                    if (RequiredDataConnectors.Any())
                    {
                        builder.Append("    requiredDataConnectors: ");
                        builder.AppendLine("[");
                        foreach (var item in RequiredDataConnectors)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    requiredDataConnectors: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("    status: ");
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tactics), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    tactics: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tactics))
                {
                    if (Tactics.Any())
                    {
                        builder.Append("    tactics: ");
                        builder.AppendLine("[");
                        foreach (var item in Tactics)
                        {
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Techniques), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    techniques: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Techniques))
                {
                    if (Techniques.Any())
                    {
                        builder.Append("    techniques: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Query), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    query: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Query))
                {
                    builder.Append("    query: ");
                    if (Query.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Query}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Query}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Severity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    severity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Severity))
                {
                    builder.Append("    severity: ");
                    builder.AppendLine($"'{Severity.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Version))
                {
                    builder.Append("    version: ");
                    if (Version.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Version}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Version}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    customDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CustomDetails))
                {
                    if (CustomDetails.Any())
                    {
                        builder.Append("    customDetails: ");
                        builder.AppendLine("{");
                        foreach (var item in CustomDetails)
                        {
                            builder.Append($"        '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("    }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EntityMappings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    entityMappings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EntityMappings))
                {
                    if (EntityMappings.Any())
                    {
                        builder.Append("    entityMappings: ");
                        builder.AppendLine("[");
                        foreach (var item in EntityMappings)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    entityMappings: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlertDetailsOverride), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    alertDetailsOverride: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AlertDetailsOverride))
                {
                    builder.Append("    alertDetailsOverride: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AlertDetailsOverride, options, 4, false, "    alertDetailsOverride: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("EventGroupingAggregationKind", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    eventGroupingSettings: ");
                builder.AppendLine("{");
                builder.AppendLine("      eventGroupingSettings: {");
                builder.Append("        aggregationKind: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(EventGroupingSettings))
                {
                    builder.Append("    eventGroupingSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EventGroupingSettings, options, 4, false, "    eventGroupingSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SentinelEntitiesMappings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sentinelEntitiesMappings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SentinelEntitiesMappings))
                {
                    if (SentinelEntitiesMappings.Any())
                    {
                        builder.Append("    sentinelEntitiesMappings: ");
                        builder.AppendLine("[");
                        foreach (var item in SentinelEntitiesMappings)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    sentinelEntitiesMappings: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NrtAlertRuleTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NrtAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NrtAlertRuleTemplate)} does not support writing '{options.Format}' format.");
            }
        }

        NrtAlertRuleTemplate IPersistableModel<NrtAlertRuleTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NrtAlertRuleTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNrtAlertRuleTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NrtAlertRuleTemplate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NrtAlertRuleTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
