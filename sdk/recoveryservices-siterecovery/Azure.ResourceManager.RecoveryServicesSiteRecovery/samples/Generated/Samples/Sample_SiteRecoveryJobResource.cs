// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryJobResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsTheJobDetails()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationJobs_Get.json
            // this example is just showing the usage of "ReplicationJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryJobResource created on azure
            // for more information of creating SiteRecoveryJobResource, please refer to the document of SiteRecoveryJobResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string jobName = "58776d0b-3141-48b2-a377-9ad863eb160d";
            ResourceIdentifier siteRecoveryJobResourceId = SiteRecoveryJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, jobName);
            SiteRecoveryJobResource siteRecoveryJob = client.GetSiteRecoveryJobResource(siteRecoveryJobResourceId);

            // invoke the operation
            SiteRecoveryJobResource result = await siteRecoveryJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Cancel_CancelsTheSpecifiedJob()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationJobs_Cancel.json
            // this example is just showing the usage of "ReplicationJobs_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryJobResource created on azure
            // for more information of creating SiteRecoveryJobResource, please refer to the document of SiteRecoveryJobResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string jobName = "2653c648-fc72-4316-86f3-fdf8eaa0066b";
            ResourceIdentifier siteRecoveryJobResourceId = SiteRecoveryJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, jobName);
            SiteRecoveryJobResource siteRecoveryJob = client.GetSiteRecoveryJobResource(siteRecoveryJobResourceId);

            // invoke the operation
            ArmOperation<SiteRecoveryJobResource> lro = await siteRecoveryJob.CancelAsync(WaitUntil.Completed);
            SiteRecoveryJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Restart_RestartsTheSpecifiedJob()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationJobs_Restart.json
            // this example is just showing the usage of "ReplicationJobs_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryJobResource created on azure
            // for more information of creating SiteRecoveryJobResource, please refer to the document of SiteRecoveryJobResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string jobName = "0664564c-353e-401a-ab0c-722257c10e25";
            ResourceIdentifier siteRecoveryJobResourceId = SiteRecoveryJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, jobName);
            SiteRecoveryJobResource siteRecoveryJob = client.GetSiteRecoveryJobResource(siteRecoveryJobResourceId);

            // invoke the operation
            ArmOperation<SiteRecoveryJobResource> lro = await siteRecoveryJob.RestartAsync(WaitUntil.Completed);
            SiteRecoveryJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Resume_ResumesTheSpecifiedJob()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-08-01/examples/ReplicationJobs_Resume.json
            // this example is just showing the usage of "ReplicationJobs_Resume" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryJobResource created on azure
            // for more information of creating SiteRecoveryJobResource, please refer to the document of SiteRecoveryJobResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string jobName = "58776d0b-3141-48b2-a377-9ad863eb160d";
            ResourceIdentifier siteRecoveryJobResourceId = SiteRecoveryJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, jobName);
            SiteRecoveryJobResource siteRecoveryJob = client.GetSiteRecoveryJobResource(siteRecoveryJobResourceId);

            // invoke the operation
            ReplicationResumeJobContent content = new ReplicationResumeJobContent()
            {
                ReplicationResumeJobComments = " ",
            };
            ArmOperation<SiteRecoveryJobResource> lro = await siteRecoveryJob.ResumeAsync(WaitUntil.Completed, content);
            SiteRecoveryJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
