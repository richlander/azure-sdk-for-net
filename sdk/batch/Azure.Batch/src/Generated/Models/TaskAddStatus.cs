// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> The status of the add Task request. </summary>
    public enum TaskAddStatus
    {
        /// <summary> The Task was added successfully. </summary>
        Success,
        /// <summary> The Task failed to add due to a client error and should not be retried without modifying the request as appropriate. </summary>
        ClientError,
        /// <summary> Task failed to add due to a server error and can be retried without modification. </summary>
        ServerError
    }
}
