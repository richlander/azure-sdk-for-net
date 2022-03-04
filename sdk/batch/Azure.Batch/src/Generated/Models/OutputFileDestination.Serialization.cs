// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class OutputFileDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container");
                writer.WriteObjectValue(Container);
            }
            writer.WriteEndObject();
        }

        internal static OutputFileDestination DeserializeOutputFileDestination(JsonElement element)
        {
            Optional<OutputFileBlobContainerDestination> container = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("container"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    container = OutputFileBlobContainerDestination.DeserializeOutputFileBlobContainerDestination(property.Value);
                    continue;
                }
            }
            return new OutputFileDestination(container.Value);
        }
    }
}
