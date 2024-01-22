// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Hardware specifications for the Dev Box. </summary>
    public partial class DevBoxHardwareProfile
    {
        /// <summary> Initializes a new instance of <see cref="DevBoxHardwareProfile"/>. </summary>
        public DevBoxHardwareProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevBoxHardwareProfile"/>. </summary>
        /// <param name="skuName"> The name of the SKU. </param>
        /// <param name="vCpus"> The number of vCPUs available for the Dev Box. </param>
        /// <param name="memoryGb"> The amount of memory available for the Dev Box. </param>
        internal DevBoxHardwareProfile(SkuName? skuName, int? vCpus, int? memoryGb)
        {
            SkuName = skuName;
            VCpus = vCpus;
            MemoryGb = memoryGb;
        }

        /// <summary> The name of the SKU. </summary>
        public SkuName? SkuName { get; }
        /// <summary> The number of vCPUs available for the Dev Box. </summary>
        public int? VCpus { get; }
        /// <summary> The amount of memory available for the Dev Box. </summary>
        public int? MemoryGb { get; }
    }
}
