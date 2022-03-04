// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> The conditions under which a Task output file or set of files should be uploaded. </summary>
    public enum OutputFileUploadCondition
    {
        /// <summary> Upload the file(s) only after the Task process exits with an exit code of 0. </summary>
        TaskSuccess,
        /// <summary> Upload the file(s) only after the Task process exits with a nonzero exit code. </summary>
        TaskFailure,
        /// <summary> Upload the file(s) after the Task process exits, no matter what the exit code was. </summary>
        TaskCompletion
    }
}
