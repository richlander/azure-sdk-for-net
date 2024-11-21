// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    public partial class BatchAccountPoolData : IUtf8JsonSerializable, IJsonModel<BatchAccountPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountPoolData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchAccountPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModified"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStateTransitOn))
            {
                writer.WritePropertyName("provisioningStateTransitionTime"u8);
                writer.WriteStringValue(ProvisioningStateTransitOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationState))
            {
                writer.WritePropertyName("allocationState"u8);
                writer.WriteStringValue(AllocationState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(AllocationStateTransitionOn))
            {
                writer.WritePropertyName("allocationStateTransitionTime"u8);
                writer.WriteStringValue(AllocationStateTransitionOn.Value, "O");
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(DeploymentConfiguration))
            {
                writer.WritePropertyName("deploymentConfiguration"u8);
                writer.WriteObjectValue<BatchDeploymentConfiguration>(DeploymentConfiguration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentDedicatedNodes))
            {
                writer.WritePropertyName("currentDedicatedNodes"u8);
                writer.WriteNumberValue(CurrentDedicatedNodes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentLowPriorityNodes))
            {
                writer.WritePropertyName("currentLowPriorityNodes"u8);
                writer.WriteNumberValue(CurrentLowPriorityNodes.Value);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings"u8);
                writer.WriteObjectValue(ScaleSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AutoScaleRun))
            {
                writer.WritePropertyName("autoScaleRun"u8);
                writer.WriteObjectValue(AutoScaleRun, options);
            }
            if (Optional.IsDefined(InterNodeCommunication))
            {
                writer.WritePropertyName("interNodeCommunication"u8);
                writer.WriteStringValue(InterNodeCommunication.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration, options);
            }
            if (Optional.IsDefined(TaskSlotsPerNode))
            {
                writer.WritePropertyName("taskSlotsPerNode"u8);
                writer.WriteNumberValue(TaskSlotsPerNode.Value);
            }
            if (Optional.IsDefined(TaskSchedulingPolicy))
            {
                writer.WritePropertyName("taskSchedulingPolicy"u8);
                writer.WriteObjectValue(TaskSchedulingPolicy, options);
            }
            if (Optional.IsCollectionDefined(UserAccounts))
            {
                writer.WritePropertyName("userAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in UserAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StartTask))
            {
                writer.WritePropertyName("startTask"u8);
                writer.WriteObjectValue(StartTask, options);
            }
            if (Optional.IsCollectionDefined(Certificates))
            {
                writer.WritePropertyName("certificates"u8);
                writer.WriteStartArray();
                foreach (var item in Certificates)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationPackages))
            {
                writer.WritePropertyName("applicationPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackages)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationLicenses))
            {
                writer.WritePropertyName("applicationLicenses"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationLicenses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ResizeOperationStatus))
            {
                writer.WritePropertyName("resizeOperationStatus"u8);
                writer.WriteObjectValue(ResizeOperationStatus, options);
            }
            if (Optional.IsCollectionDefined(MountConfiguration))
            {
                writer.WritePropertyName("mountConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in MountConfiguration)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TargetNodeCommunicationMode))
            {
                writer.WritePropertyName("targetNodeCommunicationMode"u8);
                writer.WriteStringValue(TargetNodeCommunicationMode.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentNodeCommunicationMode))
            {
                if (CurrentNodeCommunicationMode != null)
                {
                    writer.WritePropertyName("currentNodeCommunicationMode"u8);
                    writer.WriteStringValue(CurrentNodeCommunicationMode.Value.ToSerialString());
                }
                else
                {
                    writer.WriteNull("currentNodeCommunicationMode");
                }
            }
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                writer.WriteObjectValue(UpgradePolicy, options);
            }
            if (Optional.IsCollectionDefined(ResourceTags))
            {
                writer.WritePropertyName("resourceTags"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        BatchAccountPoolData IJsonModel<BatchAccountPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountPoolData(document.RootElement, options);
        }

        internal static BatchAccountPoolData DeserializeBatchAccountPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentity identity = default;
            ETag? etag = default;
            IDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            DateTimeOffset? lastModified = default;
            DateTimeOffset? creationTime = default;
            BatchAccountPoolProvisioningState? provisioningState = default;
            DateTimeOffset? provisioningStateTransitionTime = default;
            BatchAccountPoolAllocationState? allocationState = default;
            DateTimeOffset? allocationStateTransitionTime = default;
            string vmSize = default;
            BatchDeploymentConfiguration deploymentConfiguration = default;
            int? currentDedicatedNodes = default;
            int? currentLowPriorityNodes = default;
            BatchAccountPoolScaleSettings scaleSettings = default;
            BatchAccountPoolAutoScaleRun autoScaleRun = default;
            InterNodeCommunicationState? interNodeCommunication = default;
            BatchNetworkConfiguration networkConfiguration = default;
            int? taskSlotsPerNode = default;
            TaskSchedulingPolicy taskSchedulingPolicy = default;
            IList<BatchUserAccount> userAccounts = default;
            IList<BatchAccountPoolMetadataItem> metadata = default;
            BatchAccountPoolStartTask startTask = default;
            IList<BatchCertificateReference> certificates = default;
            IList<BatchApplicationPackageReference> applicationPackages = default;
            IList<string> applicationLicenses = default;
            BatchResizeOperationStatus resizeOperationStatus = default;
            IList<BatchMountConfiguration> mountConfiguration = default;
            NodeCommunicationMode? targetNodeCommunicationMode = default;
            NodeCommunicationMode? currentNodeCommunicationMode = default;
            UpgradePolicy upgradePolicy = default;
            IDictionary<string, string> resourceTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BatchAccountPoolProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allocationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationState = property0.Value.GetString().ToBatchAccountPoolAllocationState();
                            continue;
                        }
                        if (property0.NameEquals("allocationStateTransitionTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allocationStateTransitionTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("vmSize"u8))
                        {
                            vmSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deploymentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentConfiguration = BatchDeploymentConfiguration.DeserializeBatchDeploymentConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("currentDedicatedNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentDedicatedNodes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentLowPriorityNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentLowPriorityNodes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("scaleSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scaleSettings = BatchAccountPoolScaleSettings.DeserializeBatchAccountPoolScaleSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("autoScaleRun"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScaleRun = BatchAccountPoolAutoScaleRun.DeserializeBatchAccountPoolAutoScaleRun(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("interNodeCommunication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interNodeCommunication = property0.Value.GetString().ToInterNodeCommunicationState();
                            continue;
                        }
                        if (property0.NameEquals("networkConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkConfiguration = BatchNetworkConfiguration.DeserializeBatchNetworkConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("taskSlotsPerNode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskSlotsPerNode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("taskSchedulingPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            taskSchedulingPolicy = TaskSchedulingPolicy.DeserializeTaskSchedulingPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("userAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchUserAccount> array = new List<BatchUserAccount>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchUserAccount.DeserializeBatchUserAccount(item, options));
                            }
                            userAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchAccountPoolMetadataItem> array = new List<BatchAccountPoolMetadataItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchAccountPoolMetadataItem.DeserializeBatchAccountPoolMetadataItem(item, options));
                            }
                            metadata = array;
                            continue;
                        }
                        if (property0.NameEquals("startTask"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTask = BatchAccountPoolStartTask.DeserializeBatchAccountPoolStartTask(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("certificates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchCertificateReference> array = new List<BatchCertificateReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchCertificateReference.DeserializeBatchCertificateReference(item, options));
                            }
                            certificates = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationPackages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchApplicationPackageReference> array = new List<BatchApplicationPackageReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchApplicationPackageReference.DeserializeBatchApplicationPackageReference(item, options));
                            }
                            applicationPackages = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationLicenses"u8))
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
                            applicationLicenses = array;
                            continue;
                        }
                        if (property0.NameEquals("resizeOperationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resizeOperationStatus = BatchResizeOperationStatus.DeserializeBatchResizeOperationStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("mountConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BatchMountConfiguration> array = new List<BatchMountConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BatchMountConfiguration.DeserializeBatchMountConfiguration(item, options));
                            }
                            mountConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("targetNodeCommunicationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetNodeCommunicationMode = property0.Value.GetString().ToNodeCommunicationMode();
                            continue;
                        }
                        if (property0.NameEquals("currentNodeCommunicationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                currentNodeCommunicationMode = null;
                                continue;
                            }
                            currentNodeCommunicationMode = property0.Value.GetString().ToNodeCommunicationMode();
                            continue;
                        }
                        if (property0.NameEquals("upgradePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePolicy = UpgradePolicy.DeserializeUpgradePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("resourceTags"u8))
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
                            resourceTags = dictionary;
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
            return new BatchAccountPoolData(
                id,
                name,
                type,
                systemData,
                identity,
                displayName,
                lastModified,
                creationTime,
                provisioningState,
                provisioningStateTransitionTime,
                allocationState,
                allocationStateTransitionTime,
                vmSize,
                deploymentConfiguration,
                currentDedicatedNodes,
                currentLowPriorityNodes,
                scaleSettings,
                autoScaleRun,
                interNodeCommunication,
                networkConfiguration,
                taskSlotsPerNode,
                taskSchedulingPolicy,
                userAccounts ?? new ChangeTrackingList<BatchUserAccount>(),
                metadata ?? new ChangeTrackingList<BatchAccountPoolMetadataItem>(),
                startTask,
                certificates ?? new ChangeTrackingList<BatchCertificateReference>(),
                applicationPackages ?? new ChangeTrackingList<BatchApplicationPackageReference>(),
                applicationLicenses ?? new ChangeTrackingList<string>(),
                resizeOperationStatus,
                mountConfiguration ?? new ChangeTrackingList<BatchMountConfiguration>(),
                targetNodeCommunicationMode,
                currentNodeCommunicationMode,
                upgradePolicy,
                resourceTags ?? new ChangeTrackingDictionary<string, string>(),
                etag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support writing '{options.Format}' format.");
            }
        }

        BatchAccountPoolData IPersistableModel<BatchAccountPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountPoolData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
