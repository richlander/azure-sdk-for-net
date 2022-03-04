// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> The state of the subtask. </summary>
    public enum SubtaskState
    {
        /// <summary> The Task has been assigned to a Compute Node, but is waiting for a required Job Preparation Task to complete on the Compute Node. If the Job Preparation Task succeeds, the Task will move to running. If the Job Preparation Task fails, the Task will return to active and will be eligible to be assigned to a different Compute Node. </summary>
        Preparing,
        /// <summary> The Task is running on a Compute Node. This includes task-level preparation such as downloading resource files or deploying Packages specified on the Task - it does not necessarily mean that the Task command line has started executing. </summary>
        Running,
        /// <summary> The Task is no longer eligible to run, usually because the Task has finished successfully, or the Task has finished unsuccessfully and has exhausted its retry limit. A Task is also marked as completed if an error occurred launching the Task, or when the Task has been terminated. </summary>
        Completed
    }
}
