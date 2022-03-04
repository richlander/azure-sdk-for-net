// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Service.Models
{
    /// <summary> Options for changing the size of a Pool. </summary>
    public partial class PoolResizeParameter
    {
        /// <summary> Initializes a new instance of PoolResizeParameter. </summary>
        public PoolResizeParameter()
        {
        }

        /// <summary> The desired number of dedicated Compute Nodes in the Pool. </summary>
        public int? TargetDedicatedNodes { get; set; }
        /// <summary> The desired number of Spot/Low-priority Compute Nodes in the Pool. </summary>
        public int? TargetLowPriorityNodes { get; set; }
        /// <summary> The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? ResizeTimeout { get; set; }
        /// <summary> The default value is requeue. </summary>
        public ComputeNodeDeallocationOption? NodeDeallocationOption { get; set; }
    }
}
