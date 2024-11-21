// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.BotService.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.BotService.Samples
{
    public partial class Sample_BotResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateBot()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/UpdateBot.json
            // this example is just showing the usage of "Bots_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "subscription-id";
            string resourceGroupName = "OneResourceGroupName";
            string resourceName = "samplebotname";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation
            BotData data = new BotData(new AzureLocation("West US"))
            {
                Properties = new BotProperties("The Name of the bot", new Uri("http://mybot.coffee"), "msaappid")
                {
                    Description = "The description of the bot",
                    IconUri = new Uri("http://myicon"),
                    MsaAppType = BotMsaAppType.UserAssignedMSI,
                    MsaAppTenantId = "msaapptenantid",
                    MsaAppMSIResourceId = new ResourceIdentifier("/subscriptions/foo/resourcegroups/bar/providers/microsoft.managedidentity/userassignedidentities/sampleId"),
                    DeveloperAppInsightKey = "appinsightskey",
                    DeveloperAppInsightsApiKey = "appinsightsapikey",
                    DeveloperAppInsightsApplicationId = "appinsightsappid",
                    LuisAppIds =
{
"luisappid1","luisappid2"
},
                    LuisKey = "luiskey",
                    IsCmekEnabled = true,
                    CmekKeyVaultUri = new Uri("https://myCmekKey"),
                    PublicNetworkAccess = BotServicePublicNetworkAccess.Enabled,
                    IsLocalAuthDisabled = true,
                    SchemaTransformationVersion = "1.0",
                },
                Sku = new BotServiceSku(BotServiceSkuName.S1),
                Kind = BotServiceKind.Sdk,
                ETag = new ETag("etag1"),
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            BotResource result = await bot.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteBot()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/DeleteBot.json
            // this example is just showing the usage of "Bots_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "subscription-id";
            string resourceGroupName = "OneResourceGroupName";
            string resourceName = "samplebotname";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation
            await bot.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetBot()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/GetBot.json
            // this example is just showing the usage of "Bots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "subscription-id";
            string resourceGroupName = "OneResourceGroupName";
            string resourceName = "samplebotname";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation
            BotResource result = await bot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBots_ListBotsBySubscription()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/ListBotsBySubscription.json
            // this example is just showing the usage of "Bots_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subscription-id";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (BotResource item in subscriptionResource.GetBotsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckBotServiceNameAvailability_CheckNameAvailability()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/CheckNameAvailability.json
            // this example is just showing the usage of "Bots_GetCheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            BotServiceNameAvailabilityContent content = new BotServiceNameAvailabilityContent()
            {
                Name = "testbotname",
                ResourceType = new ResourceType("string"),
            };
            BotServiceNameAvailabilityResult result = await tenantResource.CheckBotServiceNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBotChannelWithRegenerateKeys_RegenerateKeysForDirectLineChannelSite()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/DirectlineRegenerateKeys.json
            // this example is just showing the usage of "DirectLine_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "subscription-id";
            string resourceGroupName = "OneResourceGroupName";
            string resourceName = "samplebotname";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation
            RegenerateKeysBotChannelName channelName = RegenerateKeysBotChannelName.DirectLineChannel;
            BotChannelRegenerateKeysContent content = new BotChannelRegenerateKeysContent("testSiteName", BotServiceKey.Key1);
            BotChannelResource result = await bot.GetBotChannelWithRegenerateKeysAsync(channelName, content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBotChannelWithRegenerateKeys_RegenerateKeysForWebChatChannelSite()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/WebChatRegenerateKeys.json
            // this example is just showing the usage of "DirectLine_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "subscription-id";
            string resourceGroupName = "OneResourceGroupName";
            string resourceName = "samplebotname";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation
            RegenerateKeysBotChannelName channelName = RegenerateKeysBotChannelName.WebChatChannel;
            BotChannelRegenerateKeysContent content = new BotChannelRegenerateKeysContent("testSiteName", BotServiceKey.Key1);
            BotChannelResource result = await bot.GetBotChannelWithRegenerateKeysAsync(channelName, content);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BotChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateEmailSignInUri_CreateUrl()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/CreateEmailSignInUrl.json
            // this example is just showing the usage of "Email_CreateSignInUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "subscription-id";
            string resourceGroupName = "OneResourceGroupName";
            string resourceName = "samplebotname";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation
            BotCreateEmailSignInUriResult result = await bot.CreateEmailSignInUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPrivateLinkResourcesByBotResource_ListPrivateLinkResources()
        {
            // Generated from example definition: specification/botservice/resource-manager/Microsoft.BotService/stable/2022-09-15/examples/ListPrivateLinkResources.json
            // this example is just showing the usage of "PrivateLinkResources_ListByBotResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BotResource created on azure
            // for more information of creating BotResource, please refer to the document of BotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string resourceName = "sto2527";
            ResourceIdentifier botResourceId = BotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            BotResource bot = client.GetBotResource(botResourceId);

            // invoke the operation and iterate over the result
            await foreach (BotServicePrivateLinkResourceData item in bot.GetPrivateLinkResourcesByBotResourceAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
