// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class JobSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(AllowTaskPreemption))
            {
                writer.WritePropertyName("allowTaskPreemption");
                writer.WriteBooleanValue(AllowTaskPreemption.Value);
            }
            if (Optional.IsDefined(MaxParallelTasks))
            {
                writer.WritePropertyName("maxParallelTasks");
                writer.WriteNumberValue(MaxParallelTasks.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(UsesTaskDependencies))
            {
                writer.WritePropertyName("usesTaskDependencies");
                writer.WriteBooleanValue(UsesTaskDependencies.Value);
            }
            if (Optional.IsDefined(OnAllTasksComplete))
            {
                writer.WritePropertyName("onAllTasksComplete");
                writer.WriteStringValue(OnAllTasksComplete.Value.ToSerialString());
            }
            if (Optional.IsDefined(OnTaskFailure))
            {
                writer.WritePropertyName("onTaskFailure");
                writer.WriteStringValue(OnTaskFailure.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration");
                writer.WriteObjectValue(NetworkConfiguration);
            }
            if (Optional.IsDefined(Constraints))
            {
                writer.WritePropertyName("constraints");
                writer.WriteObjectValue(Constraints);
            }
            if (Optional.IsDefined(JobManagerTask))
            {
                writer.WritePropertyName("jobManagerTask");
                writer.WriteObjectValue(JobManagerTask);
            }
            if (Optional.IsDefined(JobPreparationTask))
            {
                writer.WritePropertyName("jobPreparationTask");
                writer.WriteObjectValue(JobPreparationTask);
            }
            if (Optional.IsDefined(JobReleaseTask))
            {
                writer.WritePropertyName("jobReleaseTask");
                writer.WriteObjectValue(JobReleaseTask);
            }
            if (Optional.IsCollectionDefined(CommonEnvironmentSettings))
            {
                writer.WritePropertyName("commonEnvironmentSettings");
                writer.WriteStartArray();
                foreach (var item in CommonEnvironmentSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("poolInfo");
            writer.WriteObjectValue(PoolInfo);
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static JobSpecification DeserializeJobSpecification(JsonElement element)
        {
            Optional<int> priority = default;
            Optional<bool> allowTaskPreemption = default;
            Optional<int> maxParallelTasks = default;
            Optional<string> displayName = default;
            Optional<bool> usesTaskDependencies = default;
            Optional<OnAllTasksComplete> onAllTasksComplete = default;
            Optional<OnTaskFailure> onTaskFailure = default;
            Optional<JobNetworkConfiguration> networkConfiguration = default;
            Optional<JobConstraints> constraints = default;
            Optional<JobManagerTask> jobManagerTask = default;
            Optional<JobPreparationTask> jobPreparationTask = default;
            Optional<JobReleaseTask> jobReleaseTask = default;
            Optional<IList<EnvironmentSetting>> commonEnvironmentSettings = default;
            PoolInformation poolInfo = default;
            Optional<IList<MetadataItem>> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowTaskPreemption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    allowTaskPreemption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxParallelTasks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxParallelTasks = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usesTaskDependencies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    usesTaskDependencies = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("onAllTasksComplete"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    onAllTasksComplete = property.Value.GetString().ToOnAllTasksComplete();
                    continue;
                }
                if (property.NameEquals("onTaskFailure"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    onTaskFailure = property.Value.GetString().ToOnTaskFailure();
                    continue;
                }
                if (property.NameEquals("networkConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkConfiguration = JobNetworkConfiguration.DeserializeJobNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("constraints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    constraints = JobConstraints.DeserializeJobConstraints(property.Value);
                    continue;
                }
                if (property.NameEquals("jobManagerTask"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobManagerTask = JobManagerTask.DeserializeJobManagerTask(property.Value);
                    continue;
                }
                if (property.NameEquals("jobPreparationTask"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobPreparationTask = JobPreparationTask.DeserializeJobPreparationTask(property.Value);
                    continue;
                }
                if (property.NameEquals("jobReleaseTask"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobReleaseTask = JobReleaseTask.DeserializeJobReleaseTask(property.Value);
                    continue;
                }
                if (property.NameEquals("commonEnvironmentSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EnvironmentSetting> array = new List<EnvironmentSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnvironmentSetting.DeserializeEnvironmentSetting(item));
                    }
                    commonEnvironmentSettings = array;
                    continue;
                }
                if (property.NameEquals("poolInfo"))
                {
                    poolInfo = PoolInformation.DeserializePoolInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetadataItem> array = new List<MetadataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataItem.DeserializeMetadataItem(item));
                    }
                    metadata = array;
                    continue;
                }
            }
            return new JobSpecification(Optional.ToNullable(priority), Optional.ToNullable(allowTaskPreemption), Optional.ToNullable(maxParallelTasks), displayName.Value, Optional.ToNullable(usesTaskDependencies), Optional.ToNullable(onAllTasksComplete), Optional.ToNullable(onTaskFailure), networkConfiguration.Value, constraints.Value, jobManagerTask.Value, jobPreparationTask.Value, jobReleaseTask.Value, Optional.ToList(commonEnvironmentSettings), poolInfo, Optional.ToList(metadata));
        }
    }
}
