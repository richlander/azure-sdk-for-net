// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridConnectivity.Samples
{
    public partial class Sample_SolutionTypeResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSolutionTypeResources_SolutionTypesListBySubscription()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/SolutionTypes_ListBySubscription.json
            // this example is just showing the usage of "SolutionTypes_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SolutionTypeResource item in subscriptionResource.GetSolutionTypeResourcesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SolutionTypeResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SolutionTypesGet()
        {
            // Generated from example definition: specification/hybridconnectivity/resource-manager/Microsoft.HybridConnectivity/PublicCloud/stable/2024-12-01/examples/SolutionTypes_Get.json
            // this example is just showing the usage of "SolutionTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SolutionTypeResource created on azure
            // for more information of creating SolutionTypeResource, please refer to the document of SolutionTypeResource
            string subscriptionId = "5ACC4579-DB34-4C2F-8F8C-25061168F342";
            string resourceGroupName = "rgpublicCloud";
            string solutionType = "lulzqllpu";
            ResourceIdentifier solutionTypeResourceId = SolutionTypeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, solutionType);
            SolutionTypeResource solutionTypeResource = client.GetSolutionTypeResource(solutionTypeResourceId);

            // invoke the operation
            SolutionTypeResource result = await solutionTypeResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SolutionTypeResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
