// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudAgentPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetKubernetesClusterAgentPool()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2024-07-01/examples/AgentPools_Get.json
            // this example is just showing the usage of "AgentPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudAgentPoolResource created on azure
            // for more information of creating NetworkCloudAgentPoolResource, please refer to the document of NetworkCloudAgentPoolResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            string agentPoolName = "agentPoolName";
            ResourceIdentifier networkCloudAgentPoolResourceId = NetworkCloudAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName, agentPoolName);
            NetworkCloudAgentPoolResource networkCloudAgentPool = client.GetNetworkCloudAgentPoolResource(networkCloudAgentPoolResourceId);

            // invoke the operation
            NetworkCloudAgentPoolResource result = await networkCloudAgentPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchKubernetesClusterAgentPool()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2024-07-01/examples/AgentPools_Patch.json
            // this example is just showing the usage of "AgentPools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudAgentPoolResource created on azure
            // for more information of creating NetworkCloudAgentPoolResource, please refer to the document of NetworkCloudAgentPoolResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string kubernetesClusterName = "kubernetesClusterName";
            string agentPoolName = "agentPoolName";
            ResourceIdentifier networkCloudAgentPoolResourceId = NetworkCloudAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, kubernetesClusterName, agentPoolName);
            NetworkCloudAgentPoolResource networkCloudAgentPool = client.GetNetworkCloudAgentPoolResource(networkCloudAgentPoolResourceId);

            // invoke the operation
            NetworkCloudAgentPoolPatch patch = new NetworkCloudAgentPoolPatch
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2"
},
                AdministratorSshPublicKeys = { new NetworkCloudSshPublicKey("ssh-rsa AAtsE3njSONzDYRIZv/WLjVuMfrUSByHp+jfaaOLHTIIB4fJvo6dQUZxE20w2iDHV3tEkmnTo84eba97VMueQD6OzJPEyWZMRpz8UYWOd0IXeRqiFu1lawNblZhwNT/ojNZfpB3af/YDzwQCZgTcTRyNNhL4o/blKUmug0daSsSXISTRnIDpcf5qytjs1Xo+yYyJMvzLL59mhAyb3p/cD+Y3/s3WhAx+l0XOKpzXnblrv9d3q4c2tWmm/SyFqthaqd0= admin@vm") },
                Count = 3L,
                UpgradeSettings = new AgentPoolUpgradeSettings
                {
                    DrainTimeout = 1800L,
                    MaxSurge = "1",
                    MaxUnavailable = "0",
                },
            };
            ArmOperation<NetworkCloudAgentPoolResource> lro = await networkCloudAgentPool.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudAgentPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
