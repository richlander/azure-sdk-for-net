// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    /// <summary> Batch will retry Tasks when a recovery operation is triggered on a Node. Examples of recovery operations include (but are not limited to) when an unhealthy Node is rebooted or a Compute Node disappeared due to host failure. Retries due to recovery operations are independent of and are not counted against the maxTaskRetryCount. Even if the maxTaskRetryCount is 0, an internal retry due to a recovery operation may occur. Because of this, all Tasks should be idempotent. This means Tasks need to tolerate being interrupted and restarted without causing any corruption or duplicate data. The best practice for long running Tasks is to use some form of checkpointing. In some cases the StartTask may be re-run even though the Compute Node was not rebooted. Special care should be taken to avoid StartTasks which create breakaway process or install/launch services from the StartTask working directory, as this will block Batch from being able to re-run the StartTask. </summary>
    public partial class StartTask
    {
        /// <summary> Initializes a new instance of StartTask. </summary>
        /// <param name="commandLine"> The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using &quot;cmd /c MyCommand&quot; in Windows or &quot;/bin/sh -c MyCommand&quot; in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commandLine"/> is null. </exception>
        public StartTask(string commandLine)
        {
            if (commandLine == null)
            {
                throw new ArgumentNullException(nameof(commandLine));
            }

            CommandLine = commandLine;
            ResourceFiles = new ChangeTrackingList<ResourceFile>();
            EnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
        }

        /// <summary> Initializes a new instance of StartTask. </summary>
        /// <param name="commandLine"> The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using &quot;cmd /c MyCommand&quot; in Windows or &quot;/bin/sh -c MyCommand&quot; in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <param name="containerSettings"> When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </param>
        /// <param name="resourceFiles"> Files listed under this element are located in the Task&apos;s working directory. </param>
        /// <param name="environmentSettings"> A list of environment variable settings for the StartTask. </param>
        /// <param name="userIdentity"> If omitted, the Task runs as a non-administrative user unique to the Task. </param>
        /// <param name="maxTaskRetryCount"> The Batch service retries a Task if its exit code is nonzero. Note that this value specifically controls the number of retries. The Batch service will try the Task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries the Task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry the Task. If the maximum retry count is -1, the Batch service retries the Task without limit, however this is not recommended for a start task or any task. The default value is 0 (no retries). </param>
        /// <param name="waitForSuccess"> If true and the StartTask fails on a Node, the Batch service retries the StartTask up to its maximum retry count (maxTaskRetryCount). If the Task has still not completed successfully after all retries, then the Batch service marks the Node unusable, and will not schedule Tasks to it. This condition can be detected via the Compute Node state and failure info details. If false, the Batch service will not wait for the StartTask to complete. In this case, other Tasks can start executing on the Compute Node while the StartTask is still running; and even if the StartTask fails, new Tasks will continue to be scheduled on the Compute Node. The default is true. </param>
        internal StartTask(string commandLine, TaskContainerSettings containerSettings, IList<ResourceFile> resourceFiles, IList<EnvironmentSetting> environmentSettings, UserIdentity userIdentity, int? maxTaskRetryCount, bool? waitForSuccess)
        {
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            UserIdentity = userIdentity;
            MaxTaskRetryCount = maxTaskRetryCount;
            WaitForSuccess = waitForSuccess;
        }

        /// <summary> The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using &quot;cmd /c MyCommand&quot; in Windows or &quot;/bin/sh -c MyCommand&quot; in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </summary>
        public string CommandLine { get; set; }
        /// <summary> When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </summary>
        public TaskContainerSettings ContainerSettings { get; set; }
        /// <summary> Files listed under this element are located in the Task&apos;s working directory. </summary>
        public IList<ResourceFile> ResourceFiles { get; }
        /// <summary> A list of environment variable settings for the StartTask. </summary>
        public IList<EnvironmentSetting> EnvironmentSettings { get; }
        /// <summary> If omitted, the Task runs as a non-administrative user unique to the Task. </summary>
        public UserIdentity UserIdentity { get; set; }
        /// <summary> The Batch service retries a Task if its exit code is nonzero. Note that this value specifically controls the number of retries. The Batch service will try the Task once, and may then retry up to this limit. For example, if the maximum retry count is 3, Batch tries the Task up to 4 times (one initial try and 3 retries). If the maximum retry count is 0, the Batch service does not retry the Task. If the maximum retry count is -1, the Batch service retries the Task without limit, however this is not recommended for a start task or any task. The default value is 0 (no retries). </summary>
        public int? MaxTaskRetryCount { get; set; }
        /// <summary> If true and the StartTask fails on a Node, the Batch service retries the StartTask up to its maximum retry count (maxTaskRetryCount). If the Task has still not completed successfully after all retries, then the Batch service marks the Node unusable, and will not schedule Tasks to it. This condition can be detected via the Compute Node state and failure info details. If false, the Batch service will not wait for the StartTask to complete. In this case, other Tasks can start executing on the Compute Node while the StartTask is still running; and even if the StartTask fails, new Tasks will continue to be scheduled on the Compute Node. The default is true. </summary>
        public bool? WaitForSuccess { get; set; }
    }
}
