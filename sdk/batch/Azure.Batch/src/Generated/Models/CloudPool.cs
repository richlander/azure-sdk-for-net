// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    /// <summary> A Pool in the Azure Batch service. </summary>
    public partial class CloudPool
    {
        /// <summary> Initializes a new instance of CloudPool. </summary>
        internal CloudPool()
        {
            ResizeErrors = new ChangeTrackingList<ResizeError>();
            CertificateReferences = new ChangeTrackingList<CertificateReference>();
            ApplicationPackageReferences = new ChangeTrackingList<ApplicationPackageReference>();
            ApplicationLicenses = new ChangeTrackingList<string>();
            UserAccounts = new ChangeTrackingList<UserAccount>();
            Metadata = new ChangeTrackingList<MetadataItem>();
            MountConfiguration = new ChangeTrackingList<MountConfiguration>();
        }

        /// <summary> Initializes a new instance of CloudPool. </summary>
        /// <param name="id"> The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </param>
        /// <param name="displayName"> The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="url"> The URL of the Pool. </param>
        /// <param name="eTag"> This is an opaque string. You can use it to detect whether the Pool has changed between requests. In particular, you can be pass the ETag when updating a Pool to specify that your changes should take effect only if nobody else has modified the Pool in the meantime. </param>
        /// <param name="lastModified"> This is the last time at which the Pool level data, such as the targetDedicatedNodes or enableAutoscale settings, changed. It does not factor in node-level changes such as a Compute Node changing state. </param>
        /// <param name="creationTime"> The creation time of the Pool. </param>
        /// <param name="state"> The current state of the Pool. </param>
        /// <param name="stateTransitionTime"> The time at which the Pool entered its current state. </param>
        /// <param name="allocationState"> Whether the Pool is resizing. </param>
        /// <param name="allocationStateTransitionTime"> The time at which the Pool entered its current allocation state. </param>
        /// <param name="vmSize"> For information about available sizes of virtual machines in Pools, see Choose a VM size for Compute Nodes in an Azure Batch Pool (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes). </param>
        /// <param name="cloudServiceConfiguration"> This property and virtualMachineConfiguration are mutually exclusive and one of the properties must be specified. This property cannot be specified if the Batch Account was created with its poolAllocationMode property set to &apos;UserSubscription&apos;. </param>
        /// <param name="virtualMachineConfiguration"> This property and cloudServiceConfiguration are mutually exclusive and one of the properties must be specified. </param>
        /// <param name="resizeTimeout"> This is the timeout for the most recent resize operation. (The initial sizing when the Pool is created counts as a resize.) The default value is 15 minutes. </param>
        /// <param name="resizeErrors"> This property is set only if one or more errors occurred during the last Pool resize, and only when the Pool allocationState is Steady. </param>
        /// <param name="currentDedicatedNodes"> The number of dedicated Compute Nodes currently in the Pool. </param>
        /// <param name="currentLowPriorityNodes"> Spot/Low-priority Compute Nodes which have been preempted are included in this count. </param>
        /// <param name="targetDedicatedNodes"> The desired number of dedicated Compute Nodes in the Pool. </param>
        /// <param name="targetLowPriorityNodes"> The desired number of Spot/Low-priority Compute Nodes in the Pool. </param>
        /// <param name="enableAutoScale"> If false, at least one of targetDedicatedNodes and targetLowPriorityNodes must be specified. If true, the autoScaleFormula property is required and the Pool automatically resizes according to the formula. The default value is false. </param>
        /// <param name="autoScaleFormula"> This property is set only if the Pool automatically scales, i.e. enableAutoScale is true. </param>
        /// <param name="autoScaleEvaluationInterval"> This property is set only if the Pool automatically scales, i.e. enableAutoScale is true. </param>
        /// <param name="autoScaleRun"> This property is set only if the Pool automatically scales, i.e. enableAutoScale is true. </param>
        /// <param name="enableInterNodeCommunication"> This imposes restrictions on which Compute Nodes can be assigned to the Pool. Specifying this value can reduce the chance of the requested number of Compute Nodes to be allocated in the Pool. </param>
        /// <param name="networkConfiguration"> The network configuration for a Pool. </param>
        /// <param name="startTask"> Batch will retry Tasks when a recovery operation is triggered on a Node. Examples of recovery operations include (but are not limited to) when an unhealthy Node is rebooted or a Compute Node disappeared due to host failure. Retries due to recovery operations are independent of and are not counted against the maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal retry due to a recovery operation may occur. Because of this, all Tasks should be idempotent. This means Tasks need to tolerate being interrupted and restarted without causing any corruption or duplicate data. The best practice for long running Tasks is to use some form of checkpointing. In some cases the StartTask may be re-run even though the Compute Node was not rebooted. Special care should be taken to avoid StartTasks which create breakaway process or install/launch services from the StartTask working directory, as this will block Batch from being able to re-run the StartTask. </param>
        /// <param name="certificateReferences"> For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location. For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location. For Certificates with visibility of &apos;remoteUser&apos;, a &apos;certs&apos; directory is created in the user&apos;s home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory. </param>
        /// <param name="applicationPackageReferences"> Changes to Package references affect all new Nodes joining the Pool, but do not affect Compute Nodes that are already in the Pool until they are rebooted or reimaged. There is a maximum of 10 Package references on any given Pool. </param>
        /// <param name="applicationLicenses"> The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, Pool creation will fail. </param>
        /// <param name="taskSlotsPerNode"> The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </param>
        /// <param name="taskSchedulingPolicy"> If not specified, the default is spread. </param>
        /// <param name="userAccounts"> The list of user Accounts to be created on each Compute Node in the Pool. </param>
        /// <param name="metadata"> A list of name-value pairs associated with the Pool as metadata. </param>
        /// <param name="stats"> This property is populated only if the CloudPool was retrieved with an expand clause including the &apos;stats&apos; attribute; otherwise it is null. The statistics may not be immediately available. The Batch service performs periodic roll-up of statistics. The typical delay is about 30 minutes. </param>
        /// <param name="mountConfiguration"> This supports Azure Files, NFS, CIFS/SMB, and Blobfuse. </param>
        /// <param name="identity"> The list of user identities associated with the Batch pool. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </param>
        internal CloudPool(string id, string displayName, string url, string eTag, DateTimeOffset? lastModified, DateTimeOffset? creationTime, PoolState? state, DateTimeOffset? stateTransitionTime, AllocationState? allocationState, DateTimeOffset? allocationStateTransitionTime, string vmSize, CloudServiceConfiguration cloudServiceConfiguration, VirtualMachineConfiguration virtualMachineConfiguration, TimeSpan? resizeTimeout, IReadOnlyList<ResizeError> resizeErrors, int? currentDedicatedNodes, int? currentLowPriorityNodes, int? targetDedicatedNodes, int? targetLowPriorityNodes, bool? enableAutoScale, string autoScaleFormula, TimeSpan? autoScaleEvaluationInterval, AutoScaleRun autoScaleRun, bool? enableInterNodeCommunication, NetworkConfiguration networkConfiguration, StartTask startTask, IReadOnlyList<CertificateReference> certificateReferences, IReadOnlyList<ApplicationPackageReference> applicationPackageReferences, IReadOnlyList<string> applicationLicenses, int? taskSlotsPerNode, TaskSchedulingPolicy taskSchedulingPolicy, IReadOnlyList<UserAccount> userAccounts, IReadOnlyList<MetadataItem> metadata, PoolStatistics stats, IReadOnlyList<MountConfiguration> mountConfiguration, BatchPoolIdentity identity)
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            ResizeTimeout = resizeTimeout;
            ResizeErrors = resizeErrors;
            CurrentDedicatedNodes = currentDedicatedNodes;
            CurrentLowPriorityNodes = currentLowPriorityNodes;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            AutoScaleRun = autoScaleRun;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            ApplicationLicenses = applicationLicenses;
            TaskSlotsPerNode = taskSlotsPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            UserAccounts = userAccounts;
            Metadata = metadata;
            Stats = stats;
            MountConfiguration = mountConfiguration;
            Identity = identity;
        }

        /// <summary> The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </summary>
        public string Id { get; }
        /// <summary> The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; }
        /// <summary> The URL of the Pool. </summary>
        public string Url { get; }
        /// <summary> This is an opaque string. You can use it to detect whether the Pool has changed between requests. In particular, you can be pass the ETag when updating a Pool to specify that your changes should take effect only if nobody else has modified the Pool in the meantime. </summary>
        public string ETag { get; }
        /// <summary> This is the last time at which the Pool level data, such as the targetDedicatedNodes or enableAutoscale settings, changed. It does not factor in node-level changes such as a Compute Node changing state. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> The creation time of the Pool. </summary>
        public DateTimeOffset? CreationTime { get; }
        /// <summary> The current state of the Pool. </summary>
        public PoolState? State { get; }
        /// <summary> The time at which the Pool entered its current state. </summary>
        public DateTimeOffset? StateTransitionTime { get; }
        /// <summary> Whether the Pool is resizing. </summary>
        public AllocationState? AllocationState { get; }
        /// <summary> The time at which the Pool entered its current allocation state. </summary>
        public DateTimeOffset? AllocationStateTransitionTime { get; }
        /// <summary> For information about available sizes of virtual machines in Pools, see Choose a VM size for Compute Nodes in an Azure Batch Pool (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes). </summary>
        public string VmSize { get; }
        /// <summary> This property and virtualMachineConfiguration are mutually exclusive and one of the properties must be specified. This property cannot be specified if the Batch Account was created with its poolAllocationMode property set to &apos;UserSubscription&apos;. </summary>
        public CloudServiceConfiguration CloudServiceConfiguration { get; }
        /// <summary> This property and cloudServiceConfiguration are mutually exclusive and one of the properties must be specified. </summary>
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; }
        /// <summary> This is the timeout for the most recent resize operation. (The initial sizing when the Pool is created counts as a resize.) The default value is 15 minutes. </summary>
        public TimeSpan? ResizeTimeout { get; }
        /// <summary> This property is set only if one or more errors occurred during the last Pool resize, and only when the Pool allocationState is Steady. </summary>
        public IReadOnlyList<ResizeError> ResizeErrors { get; }
        /// <summary> The number of dedicated Compute Nodes currently in the Pool. </summary>
        public int? CurrentDedicatedNodes { get; }
        /// <summary> Spot/Low-priority Compute Nodes which have been preempted are included in this count. </summary>
        public int? CurrentLowPriorityNodes { get; }
        /// <summary> The desired number of dedicated Compute Nodes in the Pool. </summary>
        public int? TargetDedicatedNodes { get; }
        /// <summary> The desired number of Spot/Low-priority Compute Nodes in the Pool. </summary>
        public int? TargetLowPriorityNodes { get; }
        /// <summary> If false, at least one of targetDedicatedNodes and targetLowPriorityNodes must be specified. If true, the autoScaleFormula property is required and the Pool automatically resizes according to the formula. The default value is false. </summary>
        public bool? EnableAutoScale { get; }
        /// <summary> This property is set only if the Pool automatically scales, i.e. enableAutoScale is true. </summary>
        public string AutoScaleFormula { get; }
        /// <summary> This property is set only if the Pool automatically scales, i.e. enableAutoScale is true. </summary>
        public TimeSpan? AutoScaleEvaluationInterval { get; }
        /// <summary> This property is set only if the Pool automatically scales, i.e. enableAutoScale is true. </summary>
        public AutoScaleRun AutoScaleRun { get; }
        /// <summary> This imposes restrictions on which Compute Nodes can be assigned to the Pool. Specifying this value can reduce the chance of the requested number of Compute Nodes to be allocated in the Pool. </summary>
        public bool? EnableInterNodeCommunication { get; }
        /// <summary> The network configuration for a Pool. </summary>
        public NetworkConfiguration NetworkConfiguration { get; }
        /// <summary> Batch will retry Tasks when a recovery operation is triggered on a Node. Examples of recovery operations include (but are not limited to) when an unhealthy Node is rebooted or a Compute Node disappeared due to host failure. Retries due to recovery operations are independent of and are not counted against the maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal retry due to a recovery operation may occur. Because of this, all Tasks should be idempotent. This means Tasks need to tolerate being interrupted and restarted without causing any corruption or duplicate data. The best practice for long running Tasks is to use some form of checkpointing. In some cases the StartTask may be re-run even though the Compute Node was not rebooted. Special care should be taken to avoid StartTasks which create breakaway process or install/launch services from the StartTask working directory, as this will block Batch from being able to re-run the StartTask. </summary>
        public StartTask StartTask { get; }
        /// <summary> For Windows Nodes, the Batch service installs the Certificates to the specified Certificate store and location. For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location. For Certificates with visibility of &apos;remoteUser&apos;, a &apos;certs&apos; directory is created in the user&apos;s home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory. </summary>
        public IReadOnlyList<CertificateReference> CertificateReferences { get; }
        /// <summary> Changes to Package references affect all new Nodes joining the Pool, but do not affect Compute Nodes that are already in the Pool until they are rebooted or reimaged. There is a maximum of 10 Package references on any given Pool. </summary>
        public IReadOnlyList<ApplicationPackageReference> ApplicationPackageReferences { get; }
        /// <summary> The list of application licenses must be a subset of available Batch service application licenses. If a license is requested which is not supported, Pool creation will fail. </summary>
        public IReadOnlyList<string> ApplicationLicenses { get; }
        /// <summary> The default value is 1. The maximum value is the smaller of 4 times the number of cores of the vmSize of the pool or 256. </summary>
        public int? TaskSlotsPerNode { get; }
        /// <summary> If not specified, the default is spread. </summary>
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; }
        /// <summary> The list of user Accounts to be created on each Compute Node in the Pool. </summary>
        public IReadOnlyList<UserAccount> UserAccounts { get; }
        /// <summary> A list of name-value pairs associated with the Pool as metadata. </summary>
        public IReadOnlyList<MetadataItem> Metadata { get; }
        /// <summary> This property is populated only if the CloudPool was retrieved with an expand clause including the &apos;stats&apos; attribute; otherwise it is null. The statistics may not be immediately available. The Batch service performs periodic roll-up of statistics. The typical delay is about 30 minutes. </summary>
        public PoolStatistics Stats { get; }
        /// <summary> This supports Azure Files, NFS, CIFS/SMB, and Blobfuse. </summary>
        public IReadOnlyList<MountConfiguration> MountConfiguration { get; }
        /// <summary> The list of user identities associated with the Batch pool. The user identity dictionary key references will be ARM resource ids in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;. </summary>
        public BatchPoolIdentity Identity { get; }
    }
}
