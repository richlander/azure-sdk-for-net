// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class JobAddParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(MaxParallelTasks))
            {
                writer.WritePropertyName("maxParallelTasks");
                writer.WriteNumberValue(MaxParallelTasks.Value);
            }
            if (Optional.IsDefined(AllowTaskPreemption))
            {
                writer.WritePropertyName("allowTaskPreemption");
                writer.WriteBooleanValue(AllowTaskPreemption.Value);
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
            if (Optional.IsDefined(UsesTaskDependencies))
            {
                writer.WritePropertyName("usesTaskDependencies");
                writer.WriteBooleanValue(UsesTaskDependencies.Value);
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration");
                writer.WriteObjectValue(NetworkConfiguration);
            }
            writer.WriteEndObject();
        }
    }
}
