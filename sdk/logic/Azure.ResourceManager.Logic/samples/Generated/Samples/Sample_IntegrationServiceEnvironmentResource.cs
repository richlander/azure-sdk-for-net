// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Logic.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationServiceEnvironmentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetIntegrationServiceEnvironmentByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_Get.json
            // this example is just showing the usage of "IntegrationServiceEnvironments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentResource created on azure
            // for more information of creating IntegrationServiceEnvironmentResource, please refer to the document of IntegrationServiceEnvironmentResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            ResourceIdentifier integrationServiceEnvironmentResourceId = IntegrationServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            IntegrationServiceEnvironmentResource integrationServiceEnvironment = client.GetIntegrationServiceEnvironmentResource(integrationServiceEnvironmentResourceId);

            // invoke the operation
            IntegrationServiceEnvironmentResource result = await integrationServiceEnvironment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationServiceEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnIntegrationAccount()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_Delete.json
            // this example is just showing the usage of "IntegrationServiceEnvironments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentResource created on azure
            // for more information of creating IntegrationServiceEnvironmentResource, please refer to the document of IntegrationServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            ResourceIdentifier integrationServiceEnvironmentResourceId = IntegrationServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            IntegrationServiceEnvironmentResource integrationServiceEnvironment = client.GetIntegrationServiceEnvironmentResource(integrationServiceEnvironmentResourceId);

            // invoke the operation
            await integrationServiceEnvironment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnIntegrationServiceEnvironment()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_Patch.json
            // this example is just showing the usage of "IntegrationServiceEnvironments_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentResource created on azure
            // for more information of creating IntegrationServiceEnvironmentResource, please refer to the document of IntegrationServiceEnvironmentResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            ResourceIdentifier integrationServiceEnvironmentResourceId = IntegrationServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            IntegrationServiceEnvironmentResource integrationServiceEnvironment = client.GetIntegrationServiceEnvironmentResource(integrationServiceEnvironmentResourceId);

            // invoke the operation
            IntegrationServiceEnvironmentData data = new IntegrationServiceEnvironmentData(default)
            {
                Sku = new IntegrationServiceEnvironmentSku
                {
                    Name = IntegrationServiceEnvironmentSkuName.Developer,
                    Capacity = 0,
                },
                Tags =
{
["tag1"] = "value1"
},
            };
            ArmOperation<IntegrationServiceEnvironmentResource> lro = await integrationServiceEnvironment.UpdateAsync(WaitUntil.Completed, data);
            IntegrationServiceEnvironmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationServiceEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Restart_RestartsAnIntegrationServiceEnvironment()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_Restart.json
            // this example is just showing the usage of "IntegrationServiceEnvironments_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentResource created on azure
            // for more information of creating IntegrationServiceEnvironmentResource, please refer to the document of IntegrationServiceEnvironmentResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            ResourceIdentifier integrationServiceEnvironmentResourceId = IntegrationServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            IntegrationServiceEnvironmentResource integrationServiceEnvironment = client.GetIntegrationServiceEnvironmentResource(integrationServiceEnvironmentResourceId);

            // invoke the operation
            await integrationServiceEnvironment.RestartAsync();

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIntegrationServiceEnvironmentSkus_ListIntegrationServiceEnvironmentSkus()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_Skus.json
            // this example is just showing the usage of "IntegrationServiceEnvironmentSkus_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentResource created on azure
            // for more information of creating IntegrationServiceEnvironmentResource, please refer to the document of IntegrationServiceEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            ResourceIdentifier integrationServiceEnvironmentResourceId = IntegrationServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            IntegrationServiceEnvironmentResource integrationServiceEnvironment = client.GetIntegrationServiceEnvironmentResource(integrationServiceEnvironmentResourceId);

            // invoke the operation and iterate over the result
            await foreach (IntegrationServiceEnvironmentSkuDefinition item in integrationServiceEnvironment.GetIntegrationServiceEnvironmentSkusAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIntegrationServiceEnvironmentNetworkHealth_GetsTheIntegrationServiceEnvironmentNetworkHealth()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationServiceEnvironments_NetworkHealth.json
            // this example is just showing the usage of "IntegrationServiceEnvironmentNetworkHealth_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationServiceEnvironmentResource created on azure
            // for more information of creating IntegrationServiceEnvironmentResource, please refer to the document of IntegrationServiceEnvironmentResource
            string subscriptionId = "f34b22a3-2202-4fb1-b040-1332bd928c84";
            string resourceGroup = "testResourceGroup";
            string integrationServiceEnvironmentName = "testIntegrationServiceEnvironment";
            ResourceIdentifier integrationServiceEnvironmentResourceId = IntegrationServiceEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroup, integrationServiceEnvironmentName);
            IntegrationServiceEnvironmentResource integrationServiceEnvironment = client.GetIntegrationServiceEnvironmentResource(integrationServiceEnvironmentResourceId);

            // invoke the operation
            Response<IReadOnlyDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>> response = await integrationServiceEnvironment.GetIntegrationServiceEnvironmentNetworkHealthAsync();
            IReadOnlyDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth> result = response.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
