// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersGcpOffering : IUtf8JsonSerializable, IJsonModel<DefenderForContainersGcpOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForContainersGcpOffering>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForContainersGcpOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersGcpOffering)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(NativeCloudConnection))
            {
                writer.WritePropertyName("nativeCloudConnection"u8);
                writer.WriteObjectValue(NativeCloudConnection, options);
            }
            if (Optional.IsDefined(DataPipelineNativeCloudConnection))
            {
                writer.WritePropertyName("dataPipelineNativeCloudConnection"u8);
                writer.WriteObjectValue(DataPipelineNativeCloudConnection, options);
            }
            if (Optional.IsDefined(IsAuditLogsAutoProvisioningEnabled))
            {
                writer.WritePropertyName("auditLogsAutoProvisioningFlag"u8);
                writer.WriteBooleanValue(IsAuditLogsAutoProvisioningEnabled.Value);
            }
            if (Optional.IsDefined(IsDefenderAgentAutoProvisioningEnabled))
            {
                writer.WritePropertyName("defenderAgentAutoProvisioningFlag"u8);
                writer.WriteBooleanValue(IsDefenderAgentAutoProvisioningEnabled.Value);
            }
            if (Optional.IsDefined(IsPolicyAgentAutoProvisioningEnabled))
            {
                writer.WritePropertyName("policyAgentAutoProvisioningFlag"u8);
                writer.WriteBooleanValue(IsPolicyAgentAutoProvisioningEnabled.Value);
            }
            if (Optional.IsDefined(MdcContainersImageAssessment))
            {
                writer.WritePropertyName("mdcContainersImageAssessment"u8);
                writer.WriteObjectValue(MdcContainersImageAssessment, options);
            }
            if (Optional.IsDefined(MdcContainersAgentlessDiscoveryK8S))
            {
                writer.WritePropertyName("mdcContainersAgentlessDiscoveryK8s"u8);
                writer.WriteObjectValue(MdcContainersAgentlessDiscoveryK8S, options);
            }
        }

        DefenderForContainersGcpOffering IJsonModel<DefenderForContainersGcpOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersGcpOffering)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersGcpOffering(document.RootElement, options);
        }

        internal static DefenderForContainersGcpOffering DeserializeDefenderForContainersGcpOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderForContainersGcpOfferingNativeCloudConnection nativeCloudConnection = default;
            DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection dataPipelineNativeCloudConnection = default;
            bool? auditLogsAutoProvisioningFlag = default;
            bool? defenderAgentAutoProvisioningFlag = default;
            bool? policyAgentAutoProvisioningFlag = default;
            DefenderForContainersGcpOfferingMdcContainersImageAssessment mdcContainersImageAssessment = default;
            DefenderForContainersGcpOfferingMdcContainersAgentlessDiscoveryK8S mdcContainersAgentlessDiscoveryK8S = default;
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nativeCloudConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nativeCloudConnection = DefenderForContainersGcpOfferingNativeCloudConnection.DeserializeDefenderForContainersGcpOfferingNativeCloudConnection(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataPipelineNativeCloudConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPipelineNativeCloudConnection = DefenderForContainersGcpOfferingDataPipelineNativeCloudConnection.DeserializeDefenderForContainersGcpOfferingDataPipelineNativeCloudConnection(property.Value, options);
                    continue;
                }
                if (property.NameEquals("auditLogsAutoProvisioningFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    auditLogsAutoProvisioningFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defenderAgentAutoProvisioningFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defenderAgentAutoProvisioningFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyAgentAutoProvisioningFlag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyAgentAutoProvisioningFlag = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mdcContainersImageAssessment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersImageAssessment = DefenderForContainersGcpOfferingMdcContainersImageAssessment.DeserializeDefenderForContainersGcpOfferingMdcContainersImageAssessment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdcContainersAgentlessDiscoveryK8s"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdcContainersAgentlessDiscoveryK8S = DefenderForContainersGcpOfferingMdcContainersAgentlessDiscoveryK8S.DeserializeDefenderForContainersGcpOfferingMdcContainersAgentlessDiscoveryK8S(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForContainersGcpOffering(
                offeringType,
                description,
                serializedAdditionalRawData,
                nativeCloudConnection,
                dataPipelineNativeCloudConnection,
                auditLogsAutoProvisioningFlag,
                defenderAgentAutoProvisioningFlag,
                policyAgentAutoProvisioningFlag,
                mdcContainersImageAssessment,
                mdcContainersAgentlessDiscoveryK8S);
        }

        BinaryData IPersistableModel<DefenderForContainersGcpOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersGcpOffering)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForContainersGcpOffering IPersistableModel<DefenderForContainersGcpOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForContainersGcpOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersGcpOffering)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForContainersGcpOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
