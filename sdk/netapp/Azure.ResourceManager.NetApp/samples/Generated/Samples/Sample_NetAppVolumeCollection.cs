// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetApp.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppVolumeCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_VolumesList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Volumes_List.json
            // this example is just showing the usage of "Volumes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // get the collection of this NetAppVolumeResource
            NetAppVolumeCollection collection = capacityPool.GetNetAppVolumes();

            // invoke the operation and iterate over the result
            await foreach (NetAppVolumeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppVolumeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_VolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Volumes_Get.json
            // this example is just showing the usage of "Volumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // get the collection of this NetAppVolumeResource
            NetAppVolumeCollection collection = capacityPool.GetNetAppVolumes();

            // invoke the operation
            string volumeName = "volume1";
            NetAppVolumeResource result = await collection.GetAsync(volumeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_VolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Volumes_Get.json
            // this example is just showing the usage of "Volumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // get the collection of this NetAppVolumeResource
            NetAppVolumeCollection collection = capacityPool.GetNetAppVolumes();

            // invoke the operation
            string volumeName = "volume1";
            bool result = await collection.ExistsAsync(volumeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_VolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Volumes_Get.json
            // this example is just showing the usage of "Volumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // get the collection of this NetAppVolumeResource
            NetAppVolumeCollection collection = capacityPool.GetNetAppVolumes();

            // invoke the operation
            string volumeName = "volume1";
            NullableResponse<NetAppVolumeResource> response = await collection.GetIfExistsAsync(volumeName);
            NetAppVolumeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppVolumeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_VolumesCreateOrUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Volumes_CreateOrUpdate.json
            // this example is just showing the usage of "Volumes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CapacityPoolResource created on azure
            // for more information of creating CapacityPoolResource, please refer to the document of CapacityPoolResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            ResourceIdentifier capacityPoolResourceId = CapacityPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName);
            CapacityPoolResource capacityPool = client.GetCapacityPoolResource(capacityPoolResourceId);

            // get the collection of this NetAppVolumeResource
            NetAppVolumeCollection collection = capacityPool.GetNetAppVolumes();

            // invoke the operation
            string volumeName = "volume1";
            NetAppVolumeData data = new NetAppVolumeData(new AzureLocation("eastus"), "my-unique-file-path", 107374182400L, new ResourceIdentifier("/subscriptions/9760acf5-4638-11e7-9bdb-020073ca7778/resourceGroups/myRP/providers/Microsoft.Network/virtualNetworks/testvnet3/subnets/testsubnet3"))
            {
                ServiceLevel = NetAppFileServiceLevel.Premium,
            };
            ArmOperation<NetAppVolumeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, volumeName, data);
            NetAppVolumeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
