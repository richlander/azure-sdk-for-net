// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class NodeRemoveParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nodeList");
            writer.WriteStartArray();
            foreach (var item in NodeList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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
