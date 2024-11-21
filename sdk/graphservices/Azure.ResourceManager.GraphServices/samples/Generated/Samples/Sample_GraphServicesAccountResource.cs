// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.GraphServices.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.GraphServices.Samples
{
    public partial class Sample_GraphServicesAccountResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetGraphServicesAccountResources_GetListOfAccountsBySubscription()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_List_Sub.json
            // this example is just showing the usage of "Accounts_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (GraphServicesAccountResource item in subscriptionResource.GetGraphServicesAccountResourcesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GraphServicesAccountResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAccounts()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Get.json
            // this example is just showing the usage of "Accounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GraphServicesAccountResource created on azure
            // for more information of creating GraphServicesAccountResource, please refer to the document of GraphServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            string resourceName = "11111111-aaaa-1111-bbbb-111111111111";
            ResourceIdentifier graphServicesAccountResourceId = GraphServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            GraphServicesAccountResource graphServicesAccountResource = client.GetGraphServicesAccountResource(graphServicesAccountResourceId);

            // invoke the operation
            GraphServicesAccountResource result = await graphServicesAccountResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GraphServicesAccountResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateAccountResource()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Update.json
            // this example is just showing the usage of "Accounts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GraphServicesAccountResource created on azure
            // for more information of creating GraphServicesAccountResource, please refer to the document of GraphServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testResourceGroupGRAM";
            string resourceName = "11111111-aaaa-1111-bbbb-111111111111";
            ResourceIdentifier graphServicesAccountResourceId = GraphServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            GraphServicesAccountResource graphServicesAccountResource = client.GetGraphServicesAccountResource(graphServicesAccountResourceId);

            // invoke the operation
            GraphServicesAccountResourcePatch patch = new GraphServicesAccountResourcePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            GraphServicesAccountResource result = await graphServicesAccountResource.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GraphServicesAccountResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAccountResource()
        {
            // Generated from example definition: specification/graphservicesprod/resource-manager/Microsoft.GraphServices/stable/2023-04-13/examples/Accounts_Delete.json
            // this example is just showing the usage of "Accounts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GraphServicesAccountResource created on azure
            // for more information of creating GraphServicesAccountResource, please refer to the document of GraphServicesAccountResource
            string subscriptionId = "11111111-aaaa-1111-bbbb-111111111111";
            string resourceGroupName = "testResourceGroupGRAM";
            string resourceName = "11111111-aaaa-1111-bbbb-111111111111";
            ResourceIdentifier graphServicesAccountResourceId = GraphServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            GraphServicesAccountResource graphServicesAccountResource = client.GetGraphServicesAccountResource(graphServicesAccountResourceId);

            // invoke the operation
            await graphServicesAccountResource.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
