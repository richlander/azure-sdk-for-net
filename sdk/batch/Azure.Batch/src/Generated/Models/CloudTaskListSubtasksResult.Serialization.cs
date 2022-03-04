// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class CloudTaskListSubtasksResult
    {
        internal static CloudTaskListSubtasksResult DeserializeCloudTaskListSubtasksResult(JsonElement element)
        {
            Optional<IReadOnlyList<SubtaskInformation>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SubtaskInformation> array = new List<SubtaskInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubtaskInformation.DeserializeSubtaskInformation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CloudTaskListSubtasksResult(Optional.ToList(value));
        }
    }
}
