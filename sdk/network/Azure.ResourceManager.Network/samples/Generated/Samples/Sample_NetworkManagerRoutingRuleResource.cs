// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkManagerRoutingRuleResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetsRoutingRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingRuleGet.json
            // this example is just showing the usage of "RoutingRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRuleResource created on azure
            // for more information of creating NetworkManagerRoutingRuleResource, please refer to the document of NetworkManagerRoutingRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "SampleRoutingRule";
            ResourceIdentifier networkManagerRoutingRuleResourceId = NetworkManagerRoutingRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerRoutingRuleResource networkManagerRoutingRule = client.GetNetworkManagerRoutingRuleResource(networkManagerRoutingRuleResourceId);

            // invoke the operation
            NetworkManagerRoutingRuleResource result = await networkManagerRoutingRule.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateADefaultRoutingRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingRulePut.json
            // this example is just showing the usage of "RoutingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRuleResource created on azure
            // for more information of creating NetworkManagerRoutingRuleResource, please refer to the document of NetworkManagerRoutingRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "SampleRoutingRule";
            ResourceIdentifier networkManagerRoutingRuleResourceId = NetworkManagerRoutingRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerRoutingRuleResource networkManagerRoutingRule = client.GetNetworkManagerRoutingRuleResource(networkManagerRoutingRuleResourceId);

            // invoke the operation
            NetworkManagerRoutingRuleData data = new NetworkManagerRoutingRuleData()
            {
                Description = "This is Sample Routing Rule",
                Destination = new RoutingRuleRouteDestination(RoutingRuleDestinationType.AddressPrefix, "10.0.0.0/16"),
                NextHop = new RoutingRuleNextHop(RoutingRuleNextHopType.VirtualNetworkGateway),
            };
            ArmOperation<NetworkManagerRoutingRuleResource> lro = await networkManagerRoutingRule.UpdateAsync(WaitUntil.Completed, data);
            NetworkManagerRoutingRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateAnRoutingRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingRulePut.json
            // this example is just showing the usage of "RoutingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRuleResource created on azure
            // for more information of creating NetworkManagerRoutingRuleResource, please refer to the document of NetworkManagerRoutingRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "SampleRoutingRule";
            ResourceIdentifier networkManagerRoutingRuleResourceId = NetworkManagerRoutingRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerRoutingRuleResource networkManagerRoutingRule = client.GetNetworkManagerRoutingRuleResource(networkManagerRoutingRuleResourceId);

            // invoke the operation
            NetworkManagerRoutingRuleData data = new NetworkManagerRoutingRuleData()
            {
                Description = "This is Sample Routing Rule",
                Destination = new RoutingRuleRouteDestination(RoutingRuleDestinationType.AddressPrefix, "10.0.0.0/16"),
                NextHop = new RoutingRuleNextHop(RoutingRuleNextHopType.VirtualNetworkGateway),
            };
            ArmOperation<NetworkManagerRoutingRuleResource> lro = await networkManagerRoutingRule.UpdateAsync(WaitUntil.Completed, data);
            NetworkManagerRoutingRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeletesARoutingRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerRoutingRuleDelete.json
            // this example is just showing the usage of "RoutingRules_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRuleResource created on azure
            // for more information of creating NetworkManagerRoutingRuleResource, please refer to the document of NetworkManagerRoutingRuleResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            string ruleCollectionName = "testRuleCollection";
            string ruleName = "sampleRule";
            ResourceIdentifier networkManagerRoutingRuleResourceId = NetworkManagerRoutingRuleResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName, ruleName);
            NetworkManagerRoutingRuleResource networkManagerRoutingRule = client.GetNetworkManagerRoutingRuleResource(networkManagerRoutingRuleResourceId);

            // invoke the operation
            bool? force = false;
            await networkManagerRoutingRule.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine("Succeeded");
        }
    }
}
