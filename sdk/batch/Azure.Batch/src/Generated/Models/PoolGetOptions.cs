// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Service.Models
{
    /// <summary> Parameter group. </summary>
    public partial class PoolGetOptions
    {
        /// <summary> Initializes a new instance of PoolGetOptions. </summary>
        public PoolGetOptions()
        {
        }

        /// <summary> An OData $select clause. </summary>
        public string Select { get; set; }
        /// <summary> An OData $expand clause. </summary>
        public string Expand { get; set; }
        /// <summary> The maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </summary>
        public int? Timeout { get; set; }
        /// <summary> The caller-generated request identity, in the form of a GUID with no decoration such as curly braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0. </summary>
        public Guid? ClientRequestId { get; set; }
        /// <summary> Whether the server should return the client-request-id in the response. </summary>
        public bool? ReturnClientRequestId { get; set; }
        /// <summary> The time the request was issued. Client libraries typically set this to the current system clock time; set it explicitly if you are calling the REST API directly. </summary>
        public DateTimeOffset? OcpDate { get; set; }
        /// <summary> An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource&apos;s current ETag on the service exactly matches the value specified by the client. </summary>
        public string IfMatch { get; set; }
        /// <summary> An ETag value associated with the version of the resource known to the client. The operation will be performed only if the resource&apos;s current ETag on the service does not match the value specified by the client. </summary>
        public string IfNoneMatch { get; set; }
        /// <summary> A timestamp indicating the last modified time of the resource known to the client. The operation will be performed only if the resource on the service has been modified since the specified time. </summary>
        public DateTimeOffset? IfModifiedSince { get; set; }
        /// <summary> A timestamp indicating the last modified time of the resource known to the client. The operation will be performed only if the resource on the service has not been modified since the specified time. </summary>
        public DateTimeOffset? IfUnmodifiedSince { get; set; }
    }
}
