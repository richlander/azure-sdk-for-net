// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteCrossConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ExpressRouteCrossConnectionListByResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionListByResourceGroup.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCrossConnectionResource
            ExpressRouteCrossConnectionCollection collection = resourceGroupResource.GetExpressRouteCrossConnections();

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteCrossConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCrossConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExpressRouteCrossConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCrossConnectionResource
            ExpressRouteCrossConnectionCollection collection = resourceGroupResource.GetExpressRouteCrossConnections();

            // invoke the operation
            string crossConnectionName = "<circuitServiceKey>";
            ExpressRouteCrossConnectionResource result = await collection.GetAsync(crossConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCrossConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetExpressRouteCrossConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCrossConnectionResource
            ExpressRouteCrossConnectionCollection collection = resourceGroupResource.GetExpressRouteCrossConnections();

            // invoke the operation
            string crossConnectionName = "<circuitServiceKey>";
            bool result = await collection.ExistsAsync(crossConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetExpressRouteCrossConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionGet.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCrossConnectionResource
            ExpressRouteCrossConnectionCollection collection = resourceGroupResource.GetExpressRouteCrossConnections();

            // invoke the operation
            string crossConnectionName = "<circuitServiceKey>";
            NullableResponse<ExpressRouteCrossConnectionResource> response = await collection.GetIfExistsAsync(crossConnectionName);
            ExpressRouteCrossConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCrossConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateExpressRouteCrossConnection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ExpressRouteCrossConnectionUpdate.json
            // this example is just showing the usage of "ExpressRouteCrossConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "CrossConnection-SiliconValley";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCrossConnectionResource
            ExpressRouteCrossConnectionCollection collection = resourceGroupResource.GetExpressRouteCrossConnections();

            // invoke the operation
            string crossConnectionName = "<circuitServiceKey>";
            ExpressRouteCrossConnectionData data = new ExpressRouteCrossConnectionData()
            {
                ServiceProviderProvisioningState = ServiceProviderProvisioningState.NotProvisioned,
            };
            ArmOperation<ExpressRouteCrossConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, crossConnectionName, data);
            ExpressRouteCrossConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCrossConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
