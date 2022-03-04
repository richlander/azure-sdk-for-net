// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Service.Models
{
    internal static partial class OSTypeExtensions
    {
        public static string ToSerialString(this OSType value) => value switch
        {
            OSType.Linux => "linux",
            OSType.Windows => "windows",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OSType value.")
        };

        public static OSType ToOSType(this string value)
        {
            if (string.Equals(value, "linux", StringComparison.InvariantCultureIgnoreCase)) return OSType.Linux;
            if (string.Equals(value, "windows", StringComparison.InvariantCultureIgnoreCase)) return OSType.Windows;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OSType value.");
        }
    }
}
