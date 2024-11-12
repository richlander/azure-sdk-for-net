// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CustomerInsights.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CustomerInsights.Samples
{
    public partial class Sample_InteractionResourceFormatCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_InteractionsCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/InteractionsCreateOrUpdate.json
            // this example is just showing the usage of "Interactions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this InteractionResourceFormatResource
            InteractionResourceFormatCollection collection = hub.GetInteractionResourceFormats();

            // invoke the operation
            string interactionName = "TestProfileType396";
            InteractionResourceFormatData data = new InteractionResourceFormatData()
            {
                SmallImage = "\\\\Images\\\\smallImage",
                MediumImage = "\\\\Images\\\\MediumImage",
                LargeImage = "\\\\Images\\\\LargeImage",
                ApiEntitySetName = "TestInteractionType6358",
                Fields =
{
new PropertyDefinition("TestInteractionType6358","Edm.String")
{
IsArray = false,
IsRequired = true,
},new PropertyDefinition("profile1","Edm.String")
},
                IdPropertyNames =
{
"TestInteractionType6358"
},
                PrimaryParticipantProfilePropertyName = "profile1",
            };
            ArmOperation<InteractionResourceFormatResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, interactionName, data);
            InteractionResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InteractionResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_InteractionsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/InteractionsGet.json
            // this example is just showing the usage of "Interactions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this InteractionResourceFormatResource
            InteractionResourceFormatCollection collection = hub.GetInteractionResourceFormats();

            // invoke the operation
            string interactionName = "TestInteractionType6358";
            InteractionResourceFormatResource result = await collection.GetAsync(interactionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            InteractionResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_InteractionsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/InteractionsGet.json
            // this example is just showing the usage of "Interactions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this InteractionResourceFormatResource
            InteractionResourceFormatCollection collection = hub.GetInteractionResourceFormats();

            // invoke the operation
            string interactionName = "TestInteractionType6358";
            bool result = await collection.ExistsAsync(interactionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_InteractionsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/InteractionsGet.json
            // this example is just showing the usage of "Interactions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this InteractionResourceFormatResource
            InteractionResourceFormatCollection collection = hub.GetInteractionResourceFormats();

            // invoke the operation
            string interactionName = "TestInteractionType6358";
            NullableResponse<InteractionResourceFormatResource> response = await collection.GetIfExistsAsync(interactionName);
            InteractionResourceFormatResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InteractionResourceFormatData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_InteractionsListByHub()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/InteractionsListByHub.json
            // this example is just showing the usage of "Interactions_ListByHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this InteractionResourceFormatResource
            InteractionResourceFormatCollection collection = hub.GetInteractionResourceFormats();

            // invoke the operation and iterate over the result
            await foreach (InteractionResourceFormatResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                InteractionResourceFormatData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
