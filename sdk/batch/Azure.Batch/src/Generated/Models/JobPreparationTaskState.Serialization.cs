// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Service.Models
{
    internal static partial class JobPreparationTaskStateExtensions
    {
        public static string ToSerialString(this JobPreparationTaskState value) => value switch
        {
            JobPreparationTaskState.Running => "running",
            JobPreparationTaskState.Completed => "completed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobPreparationTaskState value.")
        };

        public static JobPreparationTaskState ToJobPreparationTaskState(this string value)
        {
            if (string.Equals(value, "running", StringComparison.InvariantCultureIgnoreCase)) return JobPreparationTaskState.Running;
            if (string.Equals(value, "completed", StringComparison.InvariantCultureIgnoreCase)) return JobPreparationTaskState.Completed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobPreparationTaskState value.");
        }
    }
}
