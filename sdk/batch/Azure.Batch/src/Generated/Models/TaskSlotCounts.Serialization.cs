// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    public partial class TaskSlotCounts
    {
        internal static TaskSlotCounts DeserializeTaskSlotCounts(JsonElement element)
        {
            int active = default;
            int running = default;
            int completed = default;
            int succeeded = default;
            int failed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("active"))
                {
                    active = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("running"))
                {
                    running = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("completed"))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("succeeded"))
                {
                    succeeded = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
            }
            return new TaskSlotCounts(active, running, completed, succeeded, failed);
        }
    }
}
