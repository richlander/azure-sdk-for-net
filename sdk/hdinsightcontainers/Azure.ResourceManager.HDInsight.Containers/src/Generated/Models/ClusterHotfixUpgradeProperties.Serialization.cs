// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterHotfixUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterHotfixUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterHotfixUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterHotfixUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterHotfixUpgradeProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ClusterHotfixUpgradeProperties IJsonModel<ClusterHotfixUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterHotfixUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterHotfixUpgradeProperties(document.RootElement, options);
        }

        internal static ClusterHotfixUpgradeProperties DeserializeClusterHotfixUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetOssVersion = default;
            string targetClusterVersion = default;
            string targetBuildNumber = default;
            string componentName = default;
            ClusterUpgradeType upgradeType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetOssVersion"u8))
                {
                    targetOssVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetClusterVersion"u8))
                {
                    targetClusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBuildNumber"u8))
                {
                    targetBuildNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentName"u8))
                {
                    componentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterUpgradeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterHotfixUpgradeProperties(
                upgradeType,
                serializedAdditionalRawData,
                targetOssVersion,
                targetClusterVersion,
                targetBuildNumber,
                componentName);
        }

        BinaryData IPersistableModel<ClusterHotfixUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterHotfixUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterHotfixUpgradeProperties IPersistableModel<ClusterHotfixUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterHotfixUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterHotfixUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterHotfixUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterHotfixUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
