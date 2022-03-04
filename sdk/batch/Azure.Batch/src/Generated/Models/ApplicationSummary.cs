// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Batch.Service.Models
{
    /// <summary> Contains information about an application in an Azure Batch Account. </summary>
    public partial class ApplicationSummary
    {
        /// <summary> Initializes a new instance of ApplicationSummary. </summary>
        /// <param name="id"> A string that uniquely identifies the application within the Account. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="versions"> The list of available versions of the application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="displayName"/> or <paramref name="versions"/> is null. </exception>
        internal ApplicationSummary(string id, string displayName, IEnumerable<string> versions)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }
            if (versions == null)
            {
                throw new ArgumentNullException(nameof(versions));
            }

            Id = id;
            DisplayName = displayName;
            Versions = versions.ToList();
        }

        /// <summary> Initializes a new instance of ApplicationSummary. </summary>
        /// <param name="id"> A string that uniquely identifies the application within the Account. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="versions"> The list of available versions of the application. </param>
        internal ApplicationSummary(string id, string displayName, IReadOnlyList<string> versions)
        {
            Id = id;
            DisplayName = displayName;
            Versions = versions;
        }

        /// <summary> A string that uniquely identifies the application within the Account. </summary>
        public string Id { get; }
        /// <summary> The display name for the application. </summary>
        public string DisplayName { get; }
        /// <summary> The list of available versions of the application. </summary>
        public IReadOnlyList<string> Versions { get; }
    }
}
