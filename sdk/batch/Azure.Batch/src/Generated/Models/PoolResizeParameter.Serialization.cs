// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class PoolResizeParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetDedicatedNodes))
            {
                writer.WritePropertyName("targetDedicatedNodes");
                writer.WriteNumberValue(TargetDedicatedNodes.Value);
            }
            if (Optional.IsDefined(TargetLowPriorityNodes))
            {
                writer.WritePropertyName("targetLowPriorityNodes");
                writer.WriteNumberValue(TargetLowPriorityNodes.Value);
            }
            if (Optional.IsDefined(ResizeTimeout))
            {
                writer.WritePropertyName("resizeTimeout");
                writer.WriteStringValue(ResizeTimeout.Value, "P");
            }
            if (Optional.IsDefined(NodeDeallocationOption))
            {
                writer.WritePropertyName("nodeDeallocationOption");
                writer.WriteStringValue(NodeDeallocationOption.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }
    }
}
