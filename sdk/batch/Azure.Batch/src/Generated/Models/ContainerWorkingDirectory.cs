// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> The default is &apos;taskWorkingDirectory&apos;. </summary>
    public enum ContainerWorkingDirectory
    {
        /// <summary> Use the standard Batch service Task working directory, which will contain the Task Resource Files populated by Batch. </summary>
        TaskWorkingDirectory,
        /// <summary> Use the working directory defined in the container Image. Beware that this directory will not contain the Resource Files downloaded by Batch. </summary>
        ContainerImageDefault
    }
}
