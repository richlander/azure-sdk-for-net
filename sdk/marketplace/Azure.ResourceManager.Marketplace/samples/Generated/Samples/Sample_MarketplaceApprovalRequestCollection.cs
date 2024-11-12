// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Marketplace.Samples
{
    public partial class Sample_MarketplaceApprovalRequestCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetApprovalRequestsList()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetApprovalRequestsList.json
            // this example is just showing the usage of "PrivateStore_GetApprovalRequestsList" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreResource created on azure
            // for more information of creating PrivateStoreResource, please refer to the document of PrivateStoreResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            ResourceIdentifier privateStoreResourceId = PrivateStoreResource.CreateResourceIdentifier(privateStoreId);
            PrivateStoreResource privateStore = client.GetPrivateStoreResource(privateStoreResourceId);

            // get the collection of this MarketplaceApprovalRequestResource
            MarketplaceApprovalRequestCollection collection = privateStore.GetMarketplaceApprovalRequests();

            // invoke the operation and iterate over the result
            await foreach (MarketplaceApprovalRequestResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MarketplaceApprovalRequestData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetApprovalRequest()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetRequestApproval.json
            // this example is just showing the usage of "PrivateStore_GetRequestApproval" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreResource created on azure
            // for more information of creating PrivateStoreResource, please refer to the document of PrivateStoreResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            ResourceIdentifier privateStoreResourceId = PrivateStoreResource.CreateResourceIdentifier(privateStoreId);
            PrivateStoreResource privateStore = client.GetPrivateStoreResource(privateStoreResourceId);

            // get the collection of this MarketplaceApprovalRequestResource
            MarketplaceApprovalRequestCollection collection = privateStore.GetMarketplaceApprovalRequests();

            // invoke the operation
            string requestApprovalId = "marketplacetestthirdparty.md-test-third-party-2";
            MarketplaceApprovalRequestResource result = await collection.GetAsync(requestApprovalId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MarketplaceApprovalRequestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetApprovalRequest()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetRequestApproval.json
            // this example is just showing the usage of "PrivateStore_GetRequestApproval" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreResource created on azure
            // for more information of creating PrivateStoreResource, please refer to the document of PrivateStoreResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            ResourceIdentifier privateStoreResourceId = PrivateStoreResource.CreateResourceIdentifier(privateStoreId);
            PrivateStoreResource privateStore = client.GetPrivateStoreResource(privateStoreResourceId);

            // get the collection of this MarketplaceApprovalRequestResource
            MarketplaceApprovalRequestCollection collection = privateStore.GetMarketplaceApprovalRequests();

            // invoke the operation
            string requestApprovalId = "marketplacetestthirdparty.md-test-third-party-2";
            bool result = await collection.ExistsAsync(requestApprovalId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetApprovalRequest()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/GetRequestApproval.json
            // this example is just showing the usage of "PrivateStore_GetRequestApproval" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreResource created on azure
            // for more information of creating PrivateStoreResource, please refer to the document of PrivateStoreResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            ResourceIdentifier privateStoreResourceId = PrivateStoreResource.CreateResourceIdentifier(privateStoreId);
            PrivateStoreResource privateStore = client.GetPrivateStoreResource(privateStoreResourceId);

            // get the collection of this MarketplaceApprovalRequestResource
            MarketplaceApprovalRequestCollection collection = privateStore.GetMarketplaceApprovalRequests();

            // invoke the operation
            string requestApprovalId = "marketplacetestthirdparty.md-test-third-party-2";
            NullableResponse<MarketplaceApprovalRequestResource> response = await collection.GetIfExistsAsync(requestApprovalId);
            MarketplaceApprovalRequestResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MarketplaceApprovalRequestData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateApprovalRequest()
        {
            // Generated from example definition: specification/marketplace/resource-manager/Microsoft.Marketplace/stable/2023-01-01/examples/CreateApprovalRequest.json
            // this example is just showing the usage of "PrivateStore_CreateApprovalRequest" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PrivateStoreResource created on azure
            // for more information of creating PrivateStoreResource, please refer to the document of PrivateStoreResource
            Guid privateStoreId = Guid.Parse("a0e28e55-90c4-41d8-8e34-bb7ef7775406");
            ResourceIdentifier privateStoreResourceId = PrivateStoreResource.CreateResourceIdentifier(privateStoreId);
            PrivateStoreResource privateStore = client.GetPrivateStoreResource(privateStoreResourceId);

            // get the collection of this MarketplaceApprovalRequestResource
            MarketplaceApprovalRequestCollection collection = privateStore.GetMarketplaceApprovalRequests();

            // invoke the operation
            string requestApprovalId = "marketplacetestthirdparty.md-test-third-party-2";
            MarketplaceApprovalRequestData data = new MarketplaceApprovalRequestData();
            ArmOperation<MarketplaceApprovalRequestResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, requestApprovalId, data);
            MarketplaceApprovalRequestResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MarketplaceApprovalRequestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
