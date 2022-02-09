// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StackHci;

namespace Azure.ResourceManager.StackHci.Models
{
    internal partial class ExtensionList
    {
        internal static ExtensionList DeserializeExtensionList(JsonElement element)
        {
            Optional<IReadOnlyList<ArcExtensionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ArcExtensionData> array = new List<ArcExtensionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArcExtensionData.DeserializeArcExtensionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ExtensionList(Optional.ToList(value), nextLink.Value);
        }
    }
}
