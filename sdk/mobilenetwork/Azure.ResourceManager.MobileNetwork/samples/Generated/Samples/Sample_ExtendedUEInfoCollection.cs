// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MobileNetwork.Samples
{
    public partial class Sample_ExtendedUEInfoCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetUEInformation4G()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/ExtendedUeInfo4GGet.json
            // this example is just showing the usage of "ExtendedUeInformation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this ExtendedUEInfoResource
            ExtendedUEInfoCollection collection = packetCoreControlPlane.GetExtendedUEInfos();

            // invoke the operation
            string ueId = "84449105622";
            ExtendedUEInfoResource result = await collection.GetAsync(ueId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedUEInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetUEInformation5G()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/ExtendedUeInfo5GGet.json
            // this example is just showing the usage of "ExtendedUeInformation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this ExtendedUEInfoResource
            ExtendedUEInfoCollection collection = packetCoreControlPlane.GetExtendedUEInfos();

            // invoke the operation
            string ueId = "84449105622";
            ExtendedUEInfoResource result = await collection.GetAsync(ueId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedUEInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetUEInformation4G()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/ExtendedUeInfo4GGet.json
            // this example is just showing the usage of "ExtendedUeInformation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this ExtendedUEInfoResource
            ExtendedUEInfoCollection collection = packetCoreControlPlane.GetExtendedUEInfos();

            // invoke the operation
            string ueId = "84449105622";
            bool result = await collection.ExistsAsync(ueId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetUEInformation5G()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/ExtendedUeInfo5GGet.json
            // this example is just showing the usage of "ExtendedUeInformation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this ExtendedUEInfoResource
            ExtendedUEInfoCollection collection = packetCoreControlPlane.GetExtendedUEInfos();

            // invoke the operation
            string ueId = "84449105622";
            bool result = await collection.ExistsAsync(ueId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetUEInformation4G()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/ExtendedUeInfo4GGet.json
            // this example is just showing the usage of "ExtendedUeInformation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this ExtendedUEInfoResource
            ExtendedUEInfoCollection collection = packetCoreControlPlane.GetExtendedUEInfos();

            // invoke the operation
            string ueId = "84449105622";
            NullableResponse<ExtendedUEInfoResource> response = await collection.GetIfExistsAsync(ueId);
            ExtendedUEInfoResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExtendedUEInfoData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetUEInformation5G()
        {
            // Generated from example definition: specification/mobilenetwork/resource-manager/Microsoft.MobileNetwork/stable/2024-04-01/examples/ExtendedUeInfo5GGet.json
            // this example is just showing the usage of "ExtendedUeInformation_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCoreControlPlaneResource created on azure
            // for more information of creating PacketCoreControlPlaneResource, please refer to the document of PacketCoreControlPlaneResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string packetCoreControlPlaneName = "TestPacketCoreCP";
            ResourceIdentifier packetCoreControlPlaneResourceId = PacketCoreControlPlaneResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            PacketCoreControlPlaneResource packetCoreControlPlane = client.GetPacketCoreControlPlaneResource(packetCoreControlPlaneResourceId);

            // get the collection of this ExtendedUEInfoResource
            ExtendedUEInfoCollection collection = packetCoreControlPlane.GetExtendedUEInfos();

            // invoke the operation
            string ueId = "84449105622";
            NullableResponse<ExtendedUEInfoResource> response = await collection.GetIfExistsAsync(ueId);
            ExtendedUEInfoResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExtendedUEInfoData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
