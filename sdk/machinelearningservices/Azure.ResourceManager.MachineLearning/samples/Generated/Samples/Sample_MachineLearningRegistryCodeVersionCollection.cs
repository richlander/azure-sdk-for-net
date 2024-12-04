// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningRegistryCodeVersionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateRegistryCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/CodeVersion/createOrUpdate.json
            // this example is just showing the usage of "RegistryCodeVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryCodeContainerResource created on azure
            // for more information of creating MachineLearningRegistryCodeContainerResource, please refer to the document of MachineLearningRegistryCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string codeName = "string";
            ResourceIdentifier machineLearningRegistryCodeContainerResourceId = MachineLearningRegistryCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, codeName);
            MachineLearningRegistryCodeContainerResource machineLearningRegistryCodeContainer = client.GetMachineLearningRegistryCodeContainerResource(machineLearningRegistryCodeContainerResourceId);

            // get the collection of this MachineLearningRegistryCodeVersionResource
            MachineLearningRegistryCodeVersionCollection collection = machineLearningRegistryCodeContainer.GetMachineLearningRegistryCodeVersions();

            // invoke the operation
            string version = "string";
            MachineLearningCodeVersionData data = new MachineLearningCodeVersionData(new MachineLearningCodeVersionProperties
            {
                CodeUri = new Uri("https://blobStorage/folderName"),
                IsAnonymous = false,
                Description = "string",
                Tags =
{
["string"] = "string"
},
                Properties =
{
["string"] = "string"
},
            });
            ArmOperation<MachineLearningRegistryCodeVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, version, data);
            MachineLearningRegistryCodeVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetRegistryCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/CodeVersion/get.json
            // this example is just showing the usage of "RegistryCodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryCodeContainerResource created on azure
            // for more information of creating MachineLearningRegistryCodeContainerResource, please refer to the document of MachineLearningRegistryCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string codeName = "string";
            ResourceIdentifier machineLearningRegistryCodeContainerResourceId = MachineLearningRegistryCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, codeName);
            MachineLearningRegistryCodeContainerResource machineLearningRegistryCodeContainer = client.GetMachineLearningRegistryCodeContainerResource(machineLearningRegistryCodeContainerResourceId);

            // get the collection of this MachineLearningRegistryCodeVersionResource
            MachineLearningRegistryCodeVersionCollection collection = machineLearningRegistryCodeContainer.GetMachineLearningRegistryCodeVersions();

            // invoke the operation
            string version = "string";
            MachineLearningRegistryCodeVersionResource result = await collection.GetAsync(version);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningCodeVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListRegistryCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/CodeVersion/list.json
            // this example is just showing the usage of "RegistryCodeVersions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryCodeContainerResource created on azure
            // for more information of creating MachineLearningRegistryCodeContainerResource, please refer to the document of MachineLearningRegistryCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string codeName = "string";
            ResourceIdentifier machineLearningRegistryCodeContainerResourceId = MachineLearningRegistryCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, codeName);
            MachineLearningRegistryCodeContainerResource machineLearningRegistryCodeContainer = client.GetMachineLearningRegistryCodeContainerResource(machineLearningRegistryCodeContainerResourceId);

            // get the collection of this MachineLearningRegistryCodeVersionResource
            MachineLearningRegistryCodeVersionCollection collection = machineLearningRegistryCodeContainer.GetMachineLearningRegistryCodeVersions();

            // invoke the operation and iterate over the result
            string orderBy = "string";
            int? top = 1;
            await foreach (MachineLearningRegistryCodeVersionResource item in collection.GetAllAsync(orderBy: orderBy, top: top))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningCodeVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetRegistryCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/CodeVersion/get.json
            // this example is just showing the usage of "RegistryCodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryCodeContainerResource created on azure
            // for more information of creating MachineLearningRegistryCodeContainerResource, please refer to the document of MachineLearningRegistryCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string codeName = "string";
            ResourceIdentifier machineLearningRegistryCodeContainerResourceId = MachineLearningRegistryCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, codeName);
            MachineLearningRegistryCodeContainerResource machineLearningRegistryCodeContainer = client.GetMachineLearningRegistryCodeContainerResource(machineLearningRegistryCodeContainerResourceId);

            // get the collection of this MachineLearningRegistryCodeVersionResource
            MachineLearningRegistryCodeVersionCollection collection = machineLearningRegistryCodeContainer.GetMachineLearningRegistryCodeVersions();

            // invoke the operation
            string version = "string";
            bool result = await collection.ExistsAsync(version);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetRegistryCodeVersion()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/stable/2024-04-01/examples/Registry/CodeVersion/get.json
            // this example is just showing the usage of "RegistryCodeVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryCodeContainerResource created on azure
            // for more information of creating MachineLearningRegistryCodeContainerResource, please refer to the document of MachineLearningRegistryCodeContainerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "my-aml-registry";
            string codeName = "string";
            ResourceIdentifier machineLearningRegistryCodeContainerResourceId = MachineLearningRegistryCodeContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, codeName);
            MachineLearningRegistryCodeContainerResource machineLearningRegistryCodeContainer = client.GetMachineLearningRegistryCodeContainerResource(machineLearningRegistryCodeContainerResourceId);

            // get the collection of this MachineLearningRegistryCodeVersionResource
            MachineLearningRegistryCodeVersionCollection collection = machineLearningRegistryCodeContainer.GetMachineLearningRegistryCodeVersions();

            // invoke the operation
            string version = "string";
            NullableResponse<MachineLearningRegistryCodeVersionResource> response = await collection.GetIfExistsAsync(version);
            MachineLearningRegistryCodeVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningCodeVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
