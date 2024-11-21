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
    public partial class Sample_NetAppSubvolumeInfoResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SubvolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Subvolumes_Get.json
            // this example is just showing the usage of "Subvolumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppSubvolumeInfoResource created on azure
            // for more information of creating NetAppSubvolumeInfoResource, please refer to the document of NetAppSubvolumeInfoResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string subvolumeName = "subvolume1";
            ResourceIdentifier netAppSubvolumeInfoResourceId = NetAppSubvolumeInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, subvolumeName);
            NetAppSubvolumeInfoResource netAppSubvolumeInfo = client.GetNetAppSubvolumeInfoResource(netAppSubvolumeInfoResourceId);

            // invoke the operation
            NetAppSubvolumeInfoResource result = await netAppSubvolumeInfo.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppSubvolumeInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SubvolumesUpdate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Subvolumes_Update.json
            // this example is just showing the usage of "Subvolumes_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppSubvolumeInfoResource created on azure
            // for more information of creating NetAppSubvolumeInfoResource, please refer to the document of NetAppSubvolumeInfoResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string subvolumeName = "subvolume1";
            ResourceIdentifier netAppSubvolumeInfoResourceId = NetAppSubvolumeInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, subvolumeName);
            NetAppSubvolumeInfoResource netAppSubvolumeInfo = client.GetNetAppSubvolumeInfoResource(netAppSubvolumeInfoResourceId);

            // invoke the operation
            NetAppSubvolumeInfoPatch patch = new NetAppSubvolumeInfoPatch()
            {
                Path = "/subvolumePath",
            };
            ArmOperation<NetAppSubvolumeInfoResource> lro = await netAppSubvolumeInfo.UpdateAsync(WaitUntil.Completed, patch);
            NetAppSubvolumeInfoResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppSubvolumeInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SubvolumesDelete()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Subvolumes_Delete.json
            // this example is just showing the usage of "Subvolumes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppSubvolumeInfoResource created on azure
            // for more information of creating NetAppSubvolumeInfoResource, please refer to the document of NetAppSubvolumeInfoResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string subvolumeName = "subvolume1";
            ResourceIdentifier netAppSubvolumeInfoResourceId = NetAppSubvolumeInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, subvolumeName);
            NetAppSubvolumeInfoResource netAppSubvolumeInfo = client.GetNetAppSubvolumeInfoResource(netAppSubvolumeInfoResourceId);

            // invoke the operation
            await netAppSubvolumeInfo.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMetadata_SubvolumesMetadata()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2024-07-01/examples/Subvolumes_Metadata.json
            // this example is just showing the usage of "Subvolumes_GetMetadata" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppSubvolumeInfoResource created on azure
            // for more information of creating NetAppSubvolumeInfoResource, please refer to the document of NetAppSubvolumeInfoResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            string subvolumeName = "subvolume1";
            ResourceIdentifier netAppSubvolumeInfoResourceId = NetAppSubvolumeInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName, subvolumeName);
            NetAppSubvolumeInfoResource netAppSubvolumeInfo = client.GetNetAppSubvolumeInfoResource(netAppSubvolumeInfoResourceId);

            // invoke the operation
            ArmOperation<NetAppSubvolumeMetadata> lro = await netAppSubvolumeInfo.GetMetadataAsync(WaitUntil.Completed);
            NetAppSubvolumeMetadata result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
