// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class DiskEncryptionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Targets))
            {
                writer.WritePropertyName("targets");
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DiskEncryptionConfiguration DeserializeDiskEncryptionConfiguration(JsonElement element)
        {
            Optional<IList<DiskEncryptionTarget>> targets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DiskEncryptionTarget> array = new List<DiskEncryptionTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDiskEncryptionTarget());
                    }
                    targets = array;
                    continue;
                }
            }
            return new DiskEncryptionConfiguration(Optional.ToList(targets));
        }
    }
}
