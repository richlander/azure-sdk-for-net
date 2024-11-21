// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerOrchestratorRuntime.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Samples
{
    public partial class Sample_ConnectedClusterBgpPeerCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BgpPeersGet()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_Get.json
            // this example is just showing the usage of "BgpPeer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterBgpPeerCollection collection = client.GetConnectedClusterBgpPeers(scopeId);

            // invoke the operation
            string bgpPeerName = "testpeer";
            ConnectedClusterBgpPeerResource result = await collection.GetAsync(bgpPeerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterBgpPeerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_BgpPeersGet()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_Get.json
            // this example is just showing the usage of "BgpPeer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterBgpPeerCollection collection = client.GetConnectedClusterBgpPeers(scopeId);

            // invoke the operation
            string bgpPeerName = "testpeer";
            bool result = await collection.ExistsAsync(bgpPeerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_BgpPeersGet()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_Get.json
            // this example is just showing the usage of "BgpPeer_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterBgpPeerCollection collection = client.GetConnectedClusterBgpPeers(scopeId);

            // invoke the operation
            string bgpPeerName = "testpeer";
            NullableResponse<ConnectedClusterBgpPeerResource> response = await collection.GetIfExistsAsync(bgpPeerName);
            ConnectedClusterBgpPeerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectedClusterBgpPeerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_BgpPeersCreateOrUpdate()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_CreateOrUpdate.json
            // this example is just showing the usage of "BgpPeer_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterBgpPeerCollection collection = client.GetConnectedClusterBgpPeers(scopeId);

            // invoke the operation
            string bgpPeerName = "testpeer";
            ConnectedClusterBgpPeerData data = new ConnectedClusterBgpPeerData()
            {
                Properties = new ConnectedClusterBgpPeerProperties(64500, 64501, "10.0.0.1"),
            };
            ArmOperation<ConnectedClusterBgpPeerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, bgpPeerName, data);
            ConnectedClusterBgpPeerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConnectedClusterBgpPeerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_BgpPeersList()
        {
            // Generated from example definition: 2024-03-01/BgpPeers_List.json
            // this example is just showing the usage of "BgpPeer_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this ConnectedClusterBgpPeerResource
            string resourceUri = "subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/example/providers/Microsoft.Kubernetes/connectedClusters/cluster1";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            ConnectedClusterBgpPeerCollection collection = client.GetConnectedClusterBgpPeers(scopeId);

            // invoke the operation and iterate over the result
            await foreach (ConnectedClusterBgpPeerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConnectedClusterBgpPeerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
