// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.DevCenter.Samples
{
    public partial class Sample_AllowedEnvironmentTypeCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ProjectAllowedEnvironmentTypesList()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/ProjectAllowedEnvironmentTypes_List.json
            // this example is just showing the usage of "ProjectAllowedEnvironmentTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "Contoso";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this AllowedEnvironmentTypeResource
            AllowedEnvironmentTypeCollection collection = devCenterProject.GetAllowedEnvironmentTypes();

            // invoke the operation and iterate over the result
            await foreach (AllowedEnvironmentTypeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AllowedEnvironmentTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ProjectAllowedEnvironmentTypesGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/ProjectAllowedEnvironmentTypes_Get.json
            // this example is just showing the usage of "ProjectAllowedEnvironmentTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "Contoso";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this AllowedEnvironmentTypeResource
            AllowedEnvironmentTypeCollection collection = devCenterProject.GetAllowedEnvironmentTypes();

            // invoke the operation
            string environmentTypeName = "DevTest";
            AllowedEnvironmentTypeResource result = await collection.GetAsync(environmentTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AllowedEnvironmentTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ProjectAllowedEnvironmentTypesGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/ProjectAllowedEnvironmentTypes_Get.json
            // this example is just showing the usage of "ProjectAllowedEnvironmentTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "Contoso";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this AllowedEnvironmentTypeResource
            AllowedEnvironmentTypeCollection collection = devCenterProject.GetAllowedEnvironmentTypes();

            // invoke the operation
            string environmentTypeName = "DevTest";
            bool result = await collection.ExistsAsync(environmentTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ProjectAllowedEnvironmentTypesGet()
        {
            // Generated from example definition: specification/devcenter/resource-manager/Microsoft.DevCenter/stable/2023-04-01/examples/ProjectAllowedEnvironmentTypes_Get.json
            // this example is just showing the usage of "ProjectAllowedEnvironmentTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevCenterProjectResource created on azure
            // for more information of creating DevCenterProjectResource, please refer to the document of DevCenterProjectResource
            string subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c58ffff";
            string resourceGroupName = "rg1";
            string projectName = "Contoso";
            ResourceIdentifier devCenterProjectResourceId = DevCenterProjectResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, projectName);
            DevCenterProjectResource devCenterProject = client.GetDevCenterProjectResource(devCenterProjectResourceId);

            // get the collection of this AllowedEnvironmentTypeResource
            AllowedEnvironmentTypeCollection collection = devCenterProject.GetAllowedEnvironmentTypes();

            // invoke the operation
            string environmentTypeName = "DevTest";
            NullableResponse<AllowedEnvironmentTypeResource> response = await collection.GetIfExistsAsync(environmentTypeName);
            AllowedEnvironmentTypeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AllowedEnvironmentTypeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
