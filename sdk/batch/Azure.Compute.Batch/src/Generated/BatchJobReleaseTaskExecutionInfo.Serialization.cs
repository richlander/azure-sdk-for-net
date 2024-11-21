// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchJobReleaseTaskExecutionInfo : IUtf8JsonSerializable, IJsonModel<BatchJobReleaseTaskExecutionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchJobReleaseTaskExecutionInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchJobReleaseTaskExecutionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobReleaseTaskExecutionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobReleaseTaskExecutionInfo)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndTime.Value, "O");
            }
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToString());
            if (Optional.IsDefined(TaskRootDirectory))
            {
                writer.WritePropertyName("taskRootDirectory"u8);
                writer.WriteStringValue(TaskRootDirectory);
            }
            if (Optional.IsDefined(TaskRootDirectoryUrl))
            {
                writer.WritePropertyName("taskRootDirectoryUrl"u8);
                writer.WriteStringValue(TaskRootDirectoryUrl);
            }
            if (Optional.IsDefined(ExitCode))
            {
                writer.WritePropertyName("exitCode"u8);
                writer.WriteNumberValue(ExitCode.Value);
            }
            if (Optional.IsDefined(ContainerInfo))
            {
                writer.WritePropertyName("containerInfo"u8);
                writer.WriteObjectValue(ContainerInfo, options);
            }
            if (Optional.IsDefined(FailureInfo))
            {
                writer.WritePropertyName("failureInfo"u8);
                writer.WriteObjectValue(FailureInfo, options);
            }
            if (Optional.IsDefined(Result))
            {
                writer.WritePropertyName("result"u8);
                writer.WriteStringValue(Result.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BatchJobReleaseTaskExecutionInfo IJsonModel<BatchJobReleaseTaskExecutionInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobReleaseTaskExecutionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchJobReleaseTaskExecutionInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchJobReleaseTaskExecutionInfo(document.RootElement, options);
        }

        internal static BatchJobReleaseTaskExecutionInfo DeserializeBatchJobReleaseTaskExecutionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset? endTime = default;
            BatchJobReleaseTaskState state = default;
            string taskRootDirectory = default;
            string taskRootDirectoryUrl = default;
            int? exitCode = default;
            BatchTaskContainerExecutionInfo containerInfo = default;
            BatchTaskFailureInfo failureInfo = default;
            BatchTaskExecutionResult? result = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = new BatchJobReleaseTaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskRootDirectory"u8))
                {
                    taskRootDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskRootDirectoryUrl"u8))
                {
                    taskRootDirectoryUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exitCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exitCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("containerInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerInfo = BatchTaskContainerExecutionInfo.DeserializeBatchTaskContainerExecutionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("failureInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureInfo = BatchTaskFailureInfo.DeserializeBatchTaskFailureInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = new BatchTaskExecutionResult(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchJobReleaseTaskExecutionInfo(
                startTime,
                endTime,
                state,
                taskRootDirectory,
                taskRootDirectoryUrl,
                exitCode,
                containerInfo,
                failureInfo,
                result,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchJobReleaseTaskExecutionInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobReleaseTaskExecutionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchJobReleaseTaskExecutionInfo)} does not support writing '{options.Format}' format.");
            }
        }

        BatchJobReleaseTaskExecutionInfo IPersistableModel<BatchJobReleaseTaskExecutionInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchJobReleaseTaskExecutionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchJobReleaseTaskExecutionInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchJobReleaseTaskExecutionInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchJobReleaseTaskExecutionInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchJobReleaseTaskExecutionInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchJobReleaseTaskExecutionInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
