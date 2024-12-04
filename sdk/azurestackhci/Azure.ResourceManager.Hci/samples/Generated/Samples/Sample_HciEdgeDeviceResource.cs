// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Hci.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_HciEdgeDeviceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetEdgeDevice()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/GetEdgeDevices.json
            // this example is just showing the usage of "EdgeDevices_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciEdgeDeviceResource created on azure
            // for more information of creating HciEdgeDeviceResource, please refer to the document of HciEdgeDeviceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/ArcInstance-rg/providers/Microsoft.HybridCompute/machines/Node-1";
            string edgeDeviceName = "default";
            ResourceIdentifier hciEdgeDeviceResourceId = HciEdgeDeviceResource.CreateResourceIdentifier(resourceUri, edgeDeviceName);
            HciEdgeDeviceResource hciEdgeDevice = client.GetHciEdgeDeviceResource(hciEdgeDeviceResourceId);

            // invoke the operation
            HciEdgeDeviceResource result = await hciEdgeDevice.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciEdgeDeviceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteEdgeDevices()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/DeleteEdgeDevices.json
            // this example is just showing the usage of "EdgeDevices_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciEdgeDeviceResource created on azure
            // for more information of creating HciEdgeDeviceResource, please refer to the document of HciEdgeDeviceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/ArcInstance-rg/providers/Microsoft.HybridCompute/machines/Node-1";
            string edgeDeviceName = "default";
            ResourceIdentifier hciEdgeDeviceResourceId = HciEdgeDeviceResource.CreateResourceIdentifier(resourceUri, edgeDeviceName);
            HciEdgeDeviceResource hciEdgeDevice = client.GetHciEdgeDeviceResource(hciEdgeDeviceResourceId);

            // invoke the operation
            await hciEdgeDevice.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateHCIEdgeDevice()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/CreateHciEdgeDevice.json
            // this example is just showing the usage of "EdgeDevices_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciEdgeDeviceResource created on azure
            // for more information of creating HciEdgeDeviceResource, please refer to the document of HciEdgeDeviceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/ArcInstance-rg/providers/Microsoft.HybridCompute/machines/Node-1";
            string edgeDeviceName = "default";
            ResourceIdentifier hciEdgeDeviceResourceId = HciEdgeDeviceResource.CreateResourceIdentifier(resourceUri, edgeDeviceName);
            HciEdgeDeviceResource hciEdgeDevice = client.GetHciEdgeDeviceResource(hciEdgeDeviceResourceId);

            // invoke the operation
            HciEdgeDeviceData data = new HciArcEnabledEdgeDevice
            {
                Properties = new HciArcEnabledEdgeDeviceProperties
                {
                    DeviceConfiguration = new HciEdgeDeviceConfiguration
                    {
                        NicDetails = {new HciEdgeDeviceNicDetail
{
AdapterName = "ethernet",
InterfaceDescription = "NDIS 6.70 ",
ComponentId = "VMBUS{f8615163-df3e-46c5-913f-f2d2f965ed0g} ",
DriverVersion = "10.0.20348.1547 ",
IPv4Address = "10.10.10.10",
SubnetMask = "255.255.255.0",
DefaultGateway = "10.10.10.1",
DnsServers = {"100.10.10.1"},
DefaultIsolationId = "0",
}},
                        DeviceMetadata = "",
                    },
                },
            };
            ArmOperation<HciEdgeDeviceResource> lro = await hciEdgeDevice.UpdateAsync(WaitUntil.Completed, data);
            HciEdgeDeviceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciEdgeDeviceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Validate_ValidateEdgeDevices()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/ValidateEdgeDevices.json
            // this example is just showing the usage of "EdgeDevices_Validate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciEdgeDeviceResource created on azure
            // for more information of creating HciEdgeDeviceResource, please refer to the document of HciEdgeDeviceResource
            string resourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/ArcInstance-rg/providers/Microsoft.HybridCompute/machines/Node-1";
            string edgeDeviceName = "default";
            ResourceIdentifier hciEdgeDeviceResourceId = HciEdgeDeviceResource.CreateResourceIdentifier(resourceUri, edgeDeviceName);
            HciEdgeDeviceResource hciEdgeDevice = client.GetHciEdgeDeviceResource(hciEdgeDeviceResourceId);

            // invoke the operation
            HciEdgeDeviceValidateContent content = new HciEdgeDeviceValidateContent(new ResourceIdentifier[] { new ResourceIdentifier("/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/ArcInstance-rg/providers/Microsoft.HybridCompute/machines/Node-1/edgeDevices/default"), new ResourceIdentifier("/subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/ArcInstance-rg/providers/Microsoft.HybridCompute/machines/Node-2/edgeDevices/default") })
            {
                AdditionalInfo = "test",
            };
            ArmOperation<HciEdgeDeviceValidateResult> lro = await hciEdgeDevice.ValidateAsync(WaitUntil.Completed, content);
            HciEdgeDeviceValidateResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
