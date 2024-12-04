// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Peering.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Peering.Samples
{
    public partial class Sample_PeeringCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateADirectPeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/CreateDirectPeering.json
            // this example is just showing the usage of "Peerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation
            string peeringName = "peeringName";
            PeeringData data = new PeeringData(new AzureLocation("eastus"), new PeeringSku
            {
                Name = "Basic_Direct_Free",
            }, PeeringKind.Direct)
            {
                Direct = new DirectPeeringProperties
                {
                    Connections = {new PeeringDirectConnection
{
BandwidthInMbps = 10000,
SessionAddressProvider = PeeringSessionAddressProvider.Peer,
UseForPeeringService = false,
PeeringDBFacilityId = 99999,
BgpSession = new PeeringBgpSession
{
SessionPrefixV4 = "192.168.0.0/31",
SessionPrefixV6 = "fd00::0/127",
MaxPrefixesAdvertisedV4 = 1000,
MaxPrefixesAdvertisedV6 = 100,
Md5AuthenticationKey = "test-md5-auth-key",
},
ConnectionIdentifier = "5F4CB5C7-6B43-4444-9338-9ABC72606C16",
}, new PeeringDirectConnection
{
BandwidthInMbps = 10000,
SessionAddressProvider = PeeringSessionAddressProvider.Microsoft,
UseForPeeringService = true,
PeeringDBFacilityId = 99999,
ConnectionIdentifier = "8AB00818-D533-4504-A25A-03A17F61201C",
}},
                    PeerAsnId = new ResourceIdentifier("/subscriptions/subId/providers/Microsoft.Peering/peerAsns/myAsn1"),
                    DirectPeeringType = DirectPeeringType.Edge,
                },
                PeeringLocation = "peeringLocation0",
            };
            ArmOperation<PeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, peeringName, data);
            PeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAPeeringWithExchangeRouteServer()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/CreatePeeringWithExchangeRouteServer.json
            // this example is just showing the usage of "Peerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation
            string peeringName = "peeringName";
            PeeringData data = new PeeringData(new AzureLocation("eastus"), new PeeringSku
            {
                Name = "Premium_Direct_Free",
            }, PeeringKind.Direct)
            {
                Direct = new DirectPeeringProperties
                {
                    Connections = {new PeeringDirectConnection
{
BandwidthInMbps = 10000,
SessionAddressProvider = PeeringSessionAddressProvider.Peer,
UseForPeeringService = true,
PeeringDBFacilityId = 99999,
BgpSession = new PeeringBgpSession
{
SessionPrefixV4 = "192.168.0.0/24",
MicrosoftSessionIPv4Address = IPAddress.Parse("192.168.0.123"),
PeerSessionIPv4Address = IPAddress.Parse("192.168.0.234"),
MaxPrefixesAdvertisedV4 = 1000,
MaxPrefixesAdvertisedV6 = 100,
},
ConnectionIdentifier = "5F4CB5C7-6B43-4444-9338-9ABC72606C16",
}},
                    PeerAsnId = new ResourceIdentifier("/subscriptions/subId/providers/Microsoft.Peering/peerAsns/myAsn1"),
                    DirectPeeringType = DirectPeeringType.IxRs,
                },
                PeeringLocation = "peeringLocation0",
            };
            ArmOperation<PeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, peeringName, data);
            PeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAnExchangePeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/CreateExchangePeering.json
            // this example is just showing the usage of "Peerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation
            string peeringName = "peeringName";
            PeeringData data = new PeeringData(new AzureLocation("eastus"), new PeeringSku
            {
                Name = "Basic_Exchange_Free",
            }, PeeringKind.Exchange)
            {
                Exchange = new ExchangePeeringProperties
                {
                    Connections = {new PeeringExchangeConnection
{
PeeringDBFacilityId = 99999,
BgpSession = new PeeringBgpSession
{
PeerSessionIPv4Address = IPAddress.Parse("192.168.2.1"),
PeerSessionIPv6Address = IPAddress.Parse("fd00::1"),
MaxPrefixesAdvertisedV4 = 1000,
MaxPrefixesAdvertisedV6 = 100,
Md5AuthenticationKey = "test-md5-auth-key",
},
ConnectionIdentifier = Guid.Parse("CE495334-0E94-4E51-8164-8116D6CD284D"),
}, new PeeringExchangeConnection
{
PeeringDBFacilityId = 99999,
BgpSession = new PeeringBgpSession
{
PeerSessionIPv4Address = IPAddress.Parse("192.168.2.2"),
PeerSessionIPv6Address = IPAddress.Parse("fd00::2"),
MaxPrefixesAdvertisedV4 = 1000,
MaxPrefixesAdvertisedV6 = 100,
Md5AuthenticationKey = "test-md5-auth-key",
},
ConnectionIdentifier = Guid.Parse("CDD8E673-CB07-47E6-84DE-3739F778762B"),
}},
                    PeerAsnId = new ResourceIdentifier("/subscriptions/subId/providers/Microsoft.Peering/peerAsns/myAsn1"),
                },
                PeeringLocation = "peeringLocation0",
            };
            ArmOperation<PeeringResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, peeringName, data);
            PeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAPeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/GetPeering.json
            // this example is just showing the usage of "Peerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation
            string peeringName = "peeringName";
            PeeringResource result = await collection.GetAsync(peeringName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListPeeringsInAResourceGroup()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/ListPeeringsByResourceGroup.json
            // this example is just showing the usage of "Peerings_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation and iterate over the result
            await foreach (PeeringResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PeeringData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAPeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/GetPeering.json
            // this example is just showing the usage of "Peerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation
            string peeringName = "peeringName";
            bool result = await collection.ExistsAsync(peeringName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAPeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/GetPeering.json
            // this example is just showing the usage of "Peerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this PeeringResource
            PeeringCollection collection = resourceGroupResource.GetPeerings();

            // invoke the operation
            string peeringName = "peeringName";
            NullableResponse<PeeringResource> response = await collection.GetIfExistsAsync(peeringName);
            PeeringResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PeeringData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
