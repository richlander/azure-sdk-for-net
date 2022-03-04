// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    /// <summary> An error encountered by a Compute Node. </summary>
    public partial class ComputeNodeError
    {
        /// <summary> Initializes a new instance of ComputeNodeError. </summary>
        internal ComputeNodeError()
        {
            ErrorDetails = new ChangeTrackingList<NameValuePair>();
        }

        /// <summary> Initializes a new instance of ComputeNodeError. </summary>
        /// <param name="code"> An identifier for the Compute Node error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the Compute Node error, intended to be suitable for display in a user interface. </param>
        /// <param name="errorDetails"> The list of additional error details related to the Compute Node error. </param>
        internal ComputeNodeError(string code, string message, IReadOnlyList<NameValuePair> errorDetails)
        {
            Code = code;
            Message = message;
            ErrorDetails = errorDetails;
        }

        /// <summary> An identifier for the Compute Node error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the Compute Node error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
        /// <summary> The list of additional error details related to the Compute Node error. </summary>
        public IReadOnlyList<NameValuePair> ErrorDetails { get; }
    }
}
