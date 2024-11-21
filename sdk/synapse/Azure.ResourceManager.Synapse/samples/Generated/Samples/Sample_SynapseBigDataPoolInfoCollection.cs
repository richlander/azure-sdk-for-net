// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseBigDataPoolInfoCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/GetBigDataPool.json
            // this example is just showing the usage of "BigDataPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseBigDataPoolInfoResource
            SynapseBigDataPoolInfoCollection collection = synapseWorkspace.GetSynapseBigDataPoolInfos();

            // invoke the operation
            string bigDataPoolName = "ExamplePool";
            SynapseBigDataPoolInfoResource result = await collection.GetAsync(bigDataPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseBigDataPoolInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/GetBigDataPool.json
            // this example is just showing the usage of "BigDataPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseBigDataPoolInfoResource
            SynapseBigDataPoolInfoCollection collection = synapseWorkspace.GetSynapseBigDataPoolInfos();

            // invoke the operation
            string bigDataPoolName = "ExamplePool";
            bool result = await collection.ExistsAsync(bigDataPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/GetBigDataPool.json
            // this example is just showing the usage of "BigDataPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseBigDataPoolInfoResource
            SynapseBigDataPoolInfoCollection collection = synapseWorkspace.GetSynapseBigDataPoolInfos();

            // invoke the operation
            string bigDataPoolName = "ExamplePool";
            NullableResponse<SynapseBigDataPoolInfoResource> response = await collection.GetIfExistsAsync(bigDataPoolName);
            SynapseBigDataPoolInfoResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseBigDataPoolInfoData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateABigDataPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/CreateOrUpdateBigDataPool.json
            // this example is just showing the usage of "BigDataPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseBigDataPoolInfoResource
            SynapseBigDataPoolInfoCollection collection = synapseWorkspace.GetSynapseBigDataPoolInfos();

            // invoke the operation
            string bigDataPoolName = "ExamplePool";
            SynapseBigDataPoolInfoData info = new SynapseBigDataPoolInfoData(new AzureLocation("West US 2"))
            {
                AutoScale = new BigDataPoolAutoScaleProperties()
                {
                    MinNodeCount = 3,
                    IsEnabled = true,
                    MaxNodeCount = 50,
                },
                AutoPause = new BigDataPoolAutoPauseProperties()
                {
                    DelayInMinutes = 15,
                    IsEnabled = true,
                },
                IsAutotuneEnabled = false,
                SparkEventsFolder = "/events",
                NodeCount = 4,
                LibraryRequirements = new BigDataPoolLibraryRequirements()
                {
                    Content = "",
                    Filename = "requirements.txt",
                },
                SparkVersion = "2.4",
                DefaultSparkLogFolder = "/logs",
                NodeSize = BigDataPoolNodeSize.Medium,
                NodeSizeFamily = BigDataPoolNodeSizeFamily.MemoryOptimized,
                Tags =
{
["key"] = "value",
},
            };
            ArmOperation<SynapseBigDataPoolInfoResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, bigDataPoolName, info);
            SynapseBigDataPoolInfoResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseBigDataPoolInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListBigDataPoolsInAWorkspace()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/ListBigDataPoolsInWorkspace.json
            // this example is just showing the usage of "BigDataPools_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "01234567-89ab-4def-0123-456789abcdef";
            string resourceGroupName = "ExampleResourceGroup";
            string workspaceName = "ExampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseBigDataPoolInfoResource
            SynapseBigDataPoolInfoCollection collection = synapseWorkspace.GetSynapseBigDataPoolInfos();

            // invoke the operation and iterate over the result
            await foreach (SynapseBigDataPoolInfoResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseBigDataPoolInfoData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
