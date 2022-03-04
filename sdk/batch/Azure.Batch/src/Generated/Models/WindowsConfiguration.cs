// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> Windows operating system settings to apply to the virtual machine. </summary>
    public partial class WindowsConfiguration
    {
        /// <summary> Initializes a new instance of WindowsConfiguration. </summary>
        public WindowsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of WindowsConfiguration. </summary>
        /// <param name="enableAutomaticUpdates"> If omitted, the default value is true. </param>
        internal WindowsConfiguration(bool? enableAutomaticUpdates)
        {
            EnableAutomaticUpdates = enableAutomaticUpdates;
        }

        /// <summary> If omitted, the default value is true. </summary>
        public bool? EnableAutomaticUpdates { get; set; }
    }
}
