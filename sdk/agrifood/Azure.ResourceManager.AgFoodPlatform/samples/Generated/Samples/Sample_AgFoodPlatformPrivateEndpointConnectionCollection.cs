// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AgFoodPlatform.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AgFoodPlatform.Samples
{
    public partial class Sample_AgFoodPlatformPrivateEndpointConnectionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionsCreateOrUpdate()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/PrivateEndpointConnections_CreateOrUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmbeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // get the collection of this AgFoodPlatformPrivateEndpointConnectionResource
            AgFoodPlatformPrivateEndpointConnectionCollection collection = farmBeat.GetAgFoodPlatformPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            AgFoodPlatformPrivateEndpointConnectionData data = new AgFoodPlatformPrivateEndpointConnectionData
            {
                ConnectionState = new AgFoodPlatformPrivateLinkServiceConnectionState
                {
                    Status = AgFoodPlatformPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Approved by johndoe@contoso.com",
                },
            };
            ArmOperation<AgFoodPlatformPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            AgFoodPlatformPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AgFoodPlatformPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmbeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // get the collection of this AgFoodPlatformPrivateEndpointConnectionResource
            AgFoodPlatformPrivateEndpointConnectionCollection collection = farmBeat.GetAgFoodPlatformPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            AgFoodPlatformPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AgFoodPlatformPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_PrivateEndpointConnectionsListByResource()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/PrivateEndpointConnections_ListByResource.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmbeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // get the collection of this AgFoodPlatformPrivateEndpointConnectionResource
            AgFoodPlatformPrivateEndpointConnectionCollection collection = farmBeat.GetAgFoodPlatformPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (AgFoodPlatformPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AgFoodPlatformPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmbeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // get the collection of this AgFoodPlatformPrivateEndpointConnectionResource
            AgFoodPlatformPrivateEndpointConnectionCollection collection = farmBeat.GetAgFoodPlatformPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/agrifood/resource-manager/Microsoft.AgFoodPlatform/preview/2021-09-01-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FarmBeatResource created on azure
            // for more information of creating FarmBeatResource, please refer to the document of FarmBeatResource
            string subscriptionId = "11111111-2222-3333-4444-555555555555";
            string resourceGroupName = "examples-rg";
            string farmBeatsResourceName = "examples-farmbeatsResourceName";
            ResourceIdentifier farmBeatResourceId = FarmBeatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, farmBeatsResourceName);
            FarmBeatResource farmBeat = client.GetFarmBeatResource(farmBeatResourceId);

            // get the collection of this AgFoodPlatformPrivateEndpointConnectionResource
            AgFoodPlatformPrivateEndpointConnectionCollection collection = farmBeat.GetAgFoodPlatformPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            NullableResponse<AgFoodPlatformPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            AgFoodPlatformPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AgFoodPlatformPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
