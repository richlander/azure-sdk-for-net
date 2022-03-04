// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> Contains information about the container which a Task is executing. </summary>
    public partial class TaskContainerExecutionInformation
    {
        /// <summary> Initializes a new instance of TaskContainerExecutionInformation. </summary>
        internal TaskContainerExecutionInformation()
        {
        }

        /// <summary> Initializes a new instance of TaskContainerExecutionInformation. </summary>
        /// <param name="containerId"> The ID of the container. </param>
        /// <param name="state"> This is the state of the container according to the Docker service. It is equivalent to the status field returned by &quot;docker inspect&quot;. </param>
        /// <param name="error"> This is the detailed error string from the Docker service, if available. It is equivalent to the error field returned by &quot;docker inspect&quot;. </param>
        internal TaskContainerExecutionInformation(string containerId, string state, string error)
        {
            ContainerId = containerId;
            State = state;
            Error = error;
        }

        /// <summary> The ID of the container. </summary>
        public string ContainerId { get; }
        /// <summary> This is the state of the container according to the Docker service. It is equivalent to the status field returned by &quot;docker inspect&quot;. </summary>
        public string State { get; }
        /// <summary> This is the detailed error string from the Docker service, if available. It is equivalent to the error field returned by &quot;docker inspect&quot;. </summary>
        public string Error { get; }
    }
}
