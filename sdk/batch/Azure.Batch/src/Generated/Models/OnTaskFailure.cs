// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> A Task is considered to have failed if has a failureInfo. A failureInfo is set if the Task completes with a non-zero exit code after exhausting its retry count, or if there was an error starting the Task, for example due to a resource file download error. The default is noaction. </summary>
    public enum OnTaskFailure
    {
        /// <summary> Do nothing. The Job remains active unless terminated or disabled by some other means. </summary>
        NoAction,
        /// <summary> Take the action associated with the Task exit condition in the Task&apos;s exitConditions collection. (This may still result in no action being taken, if that is what the Task specifies.). </summary>
        PerformExitOptionsJobAction
    }
}
