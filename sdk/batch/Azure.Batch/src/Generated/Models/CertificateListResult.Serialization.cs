// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    internal partial class CertificateListResult
    {
        internal static CertificateListResult DeserializeCertificateListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Certificate>> value = default;
            Optional<string> odataNextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Certificate> array = new List<Certificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Certificate.DeserializeCertificate(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("odata.nextLink"))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CertificateListResult(Optional.ToList(value), odataNextLink.Value);
        }
    }
}
