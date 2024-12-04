// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Relay.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Relay.Samples
{
    public partial class Sample_RelayHybridConnectionAuthorizationRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RelayHybridConnectionAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionAuthorizationRuleCreate.json
            // this example is just showing the usage of "HybridConnections_CreateOrUpdateAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // get the collection of this RelayHybridConnectionAuthorizationRuleResource
            RelayHybridConnectionAuthorizationRuleCollection collection = relayHybridConnection.GetRelayHybridConnectionAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "example-RelayAuthRules-01";
            RelayAuthorizationRuleData data = new RelayAuthorizationRuleData
            {
                Rights = { RelayAccessRight.Listen, RelayAccessRight.Send },
            };
            ArmOperation<RelayHybridConnectionAuthorizationRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationRuleName, data);
            RelayHybridConnectionAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RelayHybridConnectionAuthorizationRuleGet()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionAuthorizationRuleGet.json
            // this example is just showing the usage of "HybridConnections_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // get the collection of this RelayHybridConnectionAuthorizationRuleResource
            RelayHybridConnectionAuthorizationRuleCollection collection = relayHybridConnection.GetRelayHybridConnectionAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "example-RelayAuthRules-01";
            RelayHybridConnectionAuthorizationRuleResource result = await collection.GetAsync(authorizationRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RelayHybridConnectionAuthorizationRuleListAll()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionAuthorizationRuleListAll.json
            // this example is just showing the usage of "HybridConnections_ListAuthorizationRules" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // get the collection of this RelayHybridConnectionAuthorizationRuleResource
            RelayHybridConnectionAuthorizationRuleCollection collection = relayHybridConnection.GetRelayHybridConnectionAuthorizationRules();

            // invoke the operation and iterate over the result
            await foreach (RelayHybridConnectionAuthorizationRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RelayAuthorizationRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RelayHybridConnectionAuthorizationRuleGet()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionAuthorizationRuleGet.json
            // this example is just showing the usage of "HybridConnections_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // get the collection of this RelayHybridConnectionAuthorizationRuleResource
            RelayHybridConnectionAuthorizationRuleCollection collection = relayHybridConnection.GetRelayHybridConnectionAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "example-RelayAuthRules-01";
            bool result = await collection.ExistsAsync(authorizationRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RelayHybridConnectionAuthorizationRuleGet()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/HybridConnection/RelayHybridConnectionAuthorizationRuleGet.json
            // this example is just showing the usage of "HybridConnections_GetAuthorizationRule" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayHybridConnectionResource created on azure
            // for more information of creating RelayHybridConnectionResource, please refer to the document of RelayHybridConnectionResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "resourcegroup";
            string namespaceName = "example-RelayNamespace-01";
            string hybridConnectionName = "example-Relay-Hybrid-01";
            ResourceIdentifier relayHybridConnectionResourceId = RelayHybridConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, hybridConnectionName);
            RelayHybridConnectionResource relayHybridConnection = client.GetRelayHybridConnectionResource(relayHybridConnectionResourceId);

            // get the collection of this RelayHybridConnectionAuthorizationRuleResource
            RelayHybridConnectionAuthorizationRuleCollection collection = relayHybridConnection.GetRelayHybridConnectionAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "example-RelayAuthRules-01";
            NullableResponse<RelayHybridConnectionAuthorizationRuleResource> response = await collection.GetIfExistsAsync(authorizationRuleName);
            RelayHybridConnectionAuthorizationRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RelayAuthorizationRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
