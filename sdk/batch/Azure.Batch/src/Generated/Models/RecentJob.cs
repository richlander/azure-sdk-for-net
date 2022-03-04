// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> Information about the most recent Job to run under the Job Schedule. </summary>
    public partial class RecentJob
    {
        /// <summary> Initializes a new instance of RecentJob. </summary>
        internal RecentJob()
        {
        }

        /// <summary> Initializes a new instance of RecentJob. </summary>
        /// <param name="id"> The ID of the Job. </param>
        /// <param name="url"> The URL of the Job. </param>
        internal RecentJob(string id, string url)
        {
            Id = id;
            Url = url;
        }

        /// <summary> The ID of the Job. </summary>
        public string Id { get; }
        /// <summary> The URL of the Job. </summary>
        public string Url { get; }
    }
}
