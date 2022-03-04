// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    /// <summary> The result of a listing the usage metrics for an Account. </summary>
    internal partial class PoolListUsageMetricsResult
    {
        /// <summary> Initializes a new instance of PoolListUsageMetricsResult. </summary>
        internal PoolListUsageMetricsResult()
        {
            Value = new ChangeTrackingList<PoolUsageMetrics>();
        }

        /// <summary> Initializes a new instance of PoolListUsageMetricsResult. </summary>
        /// <param name="value"> The Pool usage metrics data. </param>
        /// <param name="odataNextLink"> The URL to get the next set of results. </param>
        internal PoolListUsageMetricsResult(IReadOnlyList<PoolUsageMetrics> value, string odataNextLink)
        {
            Value = value;
            OdataNextLink = odataNextLink;
        }

        /// <summary> The Pool usage metrics data. </summary>
        public IReadOnlyList<PoolUsageMetrics> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string OdataNextLink { get; }
    }
}
