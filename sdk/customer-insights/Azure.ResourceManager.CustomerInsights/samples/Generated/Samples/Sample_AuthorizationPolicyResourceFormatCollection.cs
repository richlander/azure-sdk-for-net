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
    public partial class Sample_AuthorizationPolicyResourceFormatCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_AuthorizationPoliciesCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/AuthorizationPoliciesCreateOrUpdate.json
            // this example is just showing the usage of "AuthorizationPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "azSdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this AuthorizationPolicyResourceFormatResource
            AuthorizationPolicyResourceFormatCollection collection = hub.GetAuthorizationPolicyResourceFormats();

            // invoke the operation
            string authorizationPolicyName = "testPolicy4222";
            AuthorizationPolicyResourceFormatData data = new AuthorizationPolicyResourceFormatData()
            {
                Permissions =
{
PermissionType.Read,PermissionType.Write,PermissionType.Manage
},
            };
            ArmOperation<AuthorizationPolicyResourceFormatResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationPolicyName, data);
            AuthorizationPolicyResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationPolicyResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AuthorizationPoliciesGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/AuthorizationPoliciesGet.json
            // this example is just showing the usage of "AuthorizationPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "azSdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this AuthorizationPolicyResourceFormatResource
            AuthorizationPolicyResourceFormatCollection collection = hub.GetAuthorizationPolicyResourceFormats();

            // invoke the operation
            string authorizationPolicyName = "testPolicy4222";
            AuthorizationPolicyResourceFormatResource result = await collection.GetAsync(authorizationPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationPolicyResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_AuthorizationPoliciesGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/AuthorizationPoliciesGet.json
            // this example is just showing the usage of "AuthorizationPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "azSdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this AuthorizationPolicyResourceFormatResource
            AuthorizationPolicyResourceFormatCollection collection = hub.GetAuthorizationPolicyResourceFormats();

            // invoke the operation
            string authorizationPolicyName = "testPolicy4222";
            bool result = await collection.ExistsAsync(authorizationPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_AuthorizationPoliciesGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/AuthorizationPoliciesGet.json
            // this example is just showing the usage of "AuthorizationPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "azSdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this AuthorizationPolicyResourceFormatResource
            AuthorizationPolicyResourceFormatCollection collection = hub.GetAuthorizationPolicyResourceFormats();

            // invoke the operation
            string authorizationPolicyName = "testPolicy4222";
            NullableResponse<AuthorizationPolicyResourceFormatResource> response = await collection.GetIfExistsAsync(authorizationPolicyName);
            AuthorizationPolicyResourceFormatResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationPolicyResourceFormatData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_AuthorizationPoliciesListByHub()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/AuthorizationPoliciesListByHub.json
            // this example is just showing the usage of "AuthorizationPolicies_ListByHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HubResource created on azure
            // for more information of creating HubResource, please refer to the document of HubResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "azSdkTestHub";
            ResourceIdentifier hubResourceId = HubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName);
            HubResource hub = client.GetHubResource(hubResourceId);

            // get the collection of this AuthorizationPolicyResourceFormatResource
            AuthorizationPolicyResourceFormatCollection collection = hub.GetAuthorizationPolicyResourceFormats();

            // invoke the operation and iterate over the result
            await foreach (AuthorizationPolicyResourceFormatResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationPolicyResourceFormatData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
