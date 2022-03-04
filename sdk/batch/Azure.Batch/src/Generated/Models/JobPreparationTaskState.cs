// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> The current state of the Job Preparation Task on the Compute Node. </summary>
    public enum JobPreparationTaskState
    {
        /// <summary> The Task is currently running (including retrying). </summary>
        Running,
        /// <summary> The Task has exited with exit code 0, or the Task has exhausted its retry limit, or the Batch service was unable to start the Task due to Task preparation errors (such as resource file download failures). </summary>
        Completed
    }
}
