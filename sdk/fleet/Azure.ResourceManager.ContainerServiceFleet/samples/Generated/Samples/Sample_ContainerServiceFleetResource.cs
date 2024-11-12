// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerServiceFleet.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerServiceFleet.Samples
{
    public partial class Sample_ContainerServiceFleetResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetContainerServiceFleets_ListsTheFleetResourcesInASubscription()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_ListBySub.json
            // this example is just showing the usage of "Fleets_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid1";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceFleetResource item in subscriptionResource.GetContainerServiceFleetsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceFleetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsAFleetResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_Get.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // invoke the operation
            ContainerServiceFleetResource result = await containerServiceFleet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAFleet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_PatchTags.json
            // this example is just showing the usage of "Fleets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // invoke the operation
            ContainerServiceFleetPatch patch = new ContainerServiceFleetPatch()
            {
                Tags =
{
["env"] = "prod",
["tier"] = "secure",
},
            };
            string ifMatch = "dfjkwelr7384";
            ArmOperation<ContainerServiceFleetResource> lro = await containerServiceFleet.UpdateAsync(WaitUntil.Completed, patch, ifMatch: ifMatch);
            ContainerServiceFleetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceFleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesAFleetResourceAsynchronouslyWithALongRunningOperation()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_Delete.json
            // this example is just showing the usage of "Fleets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // invoke the operation
            await containerServiceFleet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCredentials_ListsTheUserCredentialsOfAFleet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_ListCredentialsResult.json
            // this example is just showing the usage of "Fleets_ListCredentials" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceFleetResource created on azure
            // for more information of creating ContainerServiceFleetResource, please refer to the document of ContainerServiceFleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet";
            ResourceIdentifier containerServiceFleetResourceId = ContainerServiceFleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            ContainerServiceFleetResource containerServiceFleet = client.GetContainerServiceFleetResource(containerServiceFleetResourceId);

            // invoke the operation
            FleetCredentialResults result = await containerServiceFleet.GetCredentialsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
