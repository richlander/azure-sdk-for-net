// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> VMAttributes that will be used to filter VMSizes which will be used to build Fleet. </summary>
    public partial class ComputeFleetVmAttributes
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmAttributes"/>. </summary>
        /// <param name="vCpuCount"> The range of vCpuCount specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required if specified. </param>
        /// <param name="memoryInGiB"> The range of memory specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required if specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vCpuCount"/> or <paramref name="memoryInGiB"/> is null. </exception>
        public ComputeFleetVmAttributes(ComputeFleetVmAttributeMinMaxInteger vCpuCount, ComputeFleetVmAttributeMinMaxDouble memoryInGiB)
        {
            Argument.AssertNotNull(vCpuCount, nameof(vCpuCount));
            Argument.AssertNotNull(memoryInGiB, nameof(memoryInGiB));

            VCpuCount = vCpuCount;
            MemoryInGiB = memoryInGiB;
            LocalStorageDiskTypes = new ChangeTrackingList<LocalStorageDiskType>();
            AcceleratorManufacturers = new ChangeTrackingList<AcceleratorManufacturer>();
            AcceleratorTypes = new ChangeTrackingList<AcceleratorType>();
            VmCategories = new ChangeTrackingList<ComputeFleetVmCategory>();
            ArchitectureTypes = new ChangeTrackingList<ArchitectureType>();
            CpuManufacturers = new ChangeTrackingList<CpuManufacturer>();
            ExcludedVmSizes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmAttributes"/>. </summary>
        /// <param name="vCpuCount"> The range of vCpuCount specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required if specified. </param>
        /// <param name="memoryInGiB"> The range of memory specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required if specified. </param>
        /// <param name="memoryInGiBPerVCpu"> The range of memory in GiB per vCPU specified from min to max. Optional parameter. Either Min or Max is required if specified. </param>
        /// <param name="localStorageSupport">
        /// Specifies whether the VMSize supporting local storage should be used to build Fleet or not.
        /// Included - Default if not specified as most Azure VMs support local storage.
        /// </param>
        /// <param name="localStorageInGiB">
        /// LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="localStorageDiskTypes">
        /// The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="dataDiskCount"> The range of data disk count specified from Min to Max. Optional parameter. Either Min or Max is required if specified. </param>
        /// <param name="networkInterfaceCount"> The range of network interface count specified from Min to Max. Optional parameter. Either Min or Max is required if specified. </param>
        /// <param name="networkBandwidthInMbps"> The range of network bandwidth in Mbps specified from Min to Max. Optional parameter. Either Min or Max is required if specified. </param>
        /// <param name="rdmaSupport"> Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build Fleet or not. </param>
        /// <param name="rdmaNetworkInterfaceCount">
        /// The range of RDMA (Remote Direct Memory Access) network interface count specified from Min to Max. Optional parameter. Either Min or Max is required if specified.
        /// rdmaSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If rdmaSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="acceleratorSupport">
        /// Specifies whether the VMSize supporting accelerator should be used to build Fleet or not.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="acceleratorManufacturers">
        /// The accelerator manufacturers specified as a list.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="acceleratorTypes">
        /// The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="acceleratorCount">
        /// The range of accelerator count specified from min to max. Optional parameter. Either Min or Max is required if specified.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </param>
        /// <param name="vmCategories"> The VM category specified as a list. Optional parameter. </param>
        /// <param name="architectureTypes"> The VM architecture types specified as a list. Optional parameter. </param>
        /// <param name="cpuManufacturers"> The VM CPU manufacturers specified as a list. Optional parameter. </param>
        /// <param name="burstableSupport"> Specifies whether the VMSize supporting burstable capability should be used to build Fleet or not. </param>
        /// <param name="excludedVmSizes"> Specifies which VMSizes should be excluded while building Fleet. Optional parameter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetVmAttributes(ComputeFleetVmAttributeMinMaxInteger vCpuCount, ComputeFleetVmAttributeMinMaxDouble memoryInGiB, ComputeFleetVmAttributeMinMaxDouble memoryInGiBPerVCpu, ComputeFleetVmAttributeSupport? localStorageSupport, ComputeFleetVmAttributeMinMaxDouble localStorageInGiB, IList<LocalStorageDiskType> localStorageDiskTypes, ComputeFleetVmAttributeMinMaxInteger dataDiskCount, ComputeFleetVmAttributeMinMaxInteger networkInterfaceCount, ComputeFleetVmAttributeMinMaxDouble networkBandwidthInMbps, ComputeFleetVmAttributeSupport? rdmaSupport, ComputeFleetVmAttributeMinMaxInteger rdmaNetworkInterfaceCount, ComputeFleetVmAttributeSupport? acceleratorSupport, IList<AcceleratorManufacturer> acceleratorManufacturers, IList<AcceleratorType> acceleratorTypes, ComputeFleetVmAttributeMinMaxInteger acceleratorCount, IList<ComputeFleetVmCategory> vmCategories, IList<ArchitectureType> architectureTypes, IList<CpuManufacturer> cpuManufacturers, ComputeFleetVmAttributeSupport? burstableSupport, IList<string> excludedVmSizes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VCpuCount = vCpuCount;
            MemoryInGiB = memoryInGiB;
            MemoryInGiBPerVCpu = memoryInGiBPerVCpu;
            LocalStorageSupport = localStorageSupport;
            LocalStorageInGiB = localStorageInGiB;
            LocalStorageDiskTypes = localStorageDiskTypes;
            DataDiskCount = dataDiskCount;
            NetworkInterfaceCount = networkInterfaceCount;
            NetworkBandwidthInMbps = networkBandwidthInMbps;
            RdmaSupport = rdmaSupport;
            RdmaNetworkInterfaceCount = rdmaNetworkInterfaceCount;
            AcceleratorSupport = acceleratorSupport;
            AcceleratorManufacturers = acceleratorManufacturers;
            AcceleratorTypes = acceleratorTypes;
            AcceleratorCount = acceleratorCount;
            VmCategories = vmCategories;
            ArchitectureTypes = architectureTypes;
            CpuManufacturers = cpuManufacturers;
            BurstableSupport = burstableSupport;
            ExcludedVmSizes = excludedVmSizes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmAttributes"/> for deserialization. </summary>
        internal ComputeFleetVmAttributes()
        {
        }

        /// <summary> The range of vCpuCount specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required if specified. </summary>
        public ComputeFleetVmAttributeMinMaxInteger VCpuCount { get; set; }
        /// <summary> The range of memory specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required if specified. </summary>
        public ComputeFleetVmAttributeMinMaxDouble MemoryInGiB { get; set; }
        /// <summary> The range of memory in GiB per vCPU specified from min to max. Optional parameter. Either Min or Max is required if specified. </summary>
        public ComputeFleetVmAttributeMinMaxDouble MemoryInGiBPerVCpu { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting local storage should be used to build Fleet or not.
        /// Included - Default if not specified as most Azure VMs support local storage.
        /// </summary>
        public ComputeFleetVmAttributeSupport? LocalStorageSupport { get; set; }
        /// <summary>
        /// LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public ComputeFleetVmAttributeMinMaxDouble LocalStorageInGiB { get; set; }
        /// <summary>
        /// The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public IList<LocalStorageDiskType> LocalStorageDiskTypes { get; }
        /// <summary> The range of data disk count specified from Min to Max. Optional parameter. Either Min or Max is required if specified. </summary>
        public ComputeFleetVmAttributeMinMaxInteger DataDiskCount { get; set; }
        /// <summary> The range of network interface count specified from Min to Max. Optional parameter. Either Min or Max is required if specified. </summary>
        public ComputeFleetVmAttributeMinMaxInteger NetworkInterfaceCount { get; set; }
        /// <summary> The range of network bandwidth in Mbps specified from Min to Max. Optional parameter. Either Min or Max is required if specified. </summary>
        public ComputeFleetVmAttributeMinMaxDouble NetworkBandwidthInMbps { get; set; }
        /// <summary> Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build Fleet or not. </summary>
        public ComputeFleetVmAttributeSupport? RdmaSupport { get; set; }
        /// <summary>
        /// The range of RDMA (Remote Direct Memory Access) network interface count specified from Min to Max. Optional parameter. Either Min or Max is required if specified.
        /// rdmaSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If rdmaSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public ComputeFleetVmAttributeMinMaxInteger RdmaNetworkInterfaceCount { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting accelerator should be used to build Fleet or not.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public ComputeFleetVmAttributeSupport? AcceleratorSupport { get; set; }
        /// <summary>
        /// The accelerator manufacturers specified as a list.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public IList<AcceleratorManufacturer> AcceleratorManufacturers { get; }
        /// <summary>
        /// The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public IList<AcceleratorType> AcceleratorTypes { get; }
        /// <summary>
        /// The range of accelerator count specified from min to max. Optional parameter. Either Min or Max is required if specified.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        public ComputeFleetVmAttributeMinMaxInteger AcceleratorCount { get; set; }
        /// <summary> The VM category specified as a list. Optional parameter. </summary>
        public IList<ComputeFleetVmCategory> VmCategories { get; }
        /// <summary> The VM architecture types specified as a list. Optional parameter. </summary>
        public IList<ArchitectureType> ArchitectureTypes { get; }
        /// <summary> The VM CPU manufacturers specified as a list. Optional parameter. </summary>
        public IList<CpuManufacturer> CpuManufacturers { get; }
        /// <summary> Specifies whether the VMSize supporting burstable capability should be used to build Fleet or not. </summary>
        public ComputeFleetVmAttributeSupport? BurstableSupport { get; set; }
        /// <summary> Specifies which VMSizes should be excluded while building Fleet. Optional parameter. </summary>
        public IList<string> ExcludedVmSizes { get; }
    }
}
