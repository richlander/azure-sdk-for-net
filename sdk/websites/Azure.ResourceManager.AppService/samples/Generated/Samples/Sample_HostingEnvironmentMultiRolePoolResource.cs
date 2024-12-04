// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_HostingEnvironmentMultiRolePoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetPropertiesOfAMultiRolePool()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_GetMultiRolePool.json
            // this example is just showing the usage of "AppServiceEnvironments_GetMultiRolePool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation
            HostingEnvironmentMultiRolePoolResource result = await hostingEnvironmentMultiRolePool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceWorkerPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateAMultiRolePool()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_CreateOrUpdateMultiRolePool.json
            // this example is just showing the usage of "AppServiceEnvironments_UpdateMultiRolePool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation
            AppServiceWorkerPoolData data = new AppServiceWorkerPoolData
            {
                WorkerSize = "Medium",
                WorkerCount = 3,
            };
            HostingEnvironmentMultiRolePoolResource result = await hostingEnvironmentMultiRolePool.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceWorkerPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAMultiRolePool()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_CreateOrUpdateMultiRolePool.json
            // this example is just showing the usage of "AppServiceEnvironments_CreateOrUpdateMultiRolePool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation
            AppServiceWorkerPoolData data = new AppServiceWorkerPoolData
            {
                WorkerSize = "Medium",
                WorkerCount = 3,
            };
            ArmOperation<HostingEnvironmentMultiRolePoolResource> lro = await hostingEnvironmentMultiRolePool.CreateOrUpdateAsync(WaitUntil.Completed, data);
            HostingEnvironmentMultiRolePoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceWorkerPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMultiRolePoolInstanceMetricDefinitions_GetMetricDefinitionsForASpecificInstanceOfAMultiRolePoolOfAnAppServiceEnvironment()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions.json
            // this example is just showing the usage of "AppServiceEnvironments_ListMultiRolePoolInstanceMetricDefinitions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation and iterate over the result
            string instance = "10.7.1.8";
            await foreach (ResourceMetricDefinition item in hostingEnvironmentMultiRolePool.GetMultiRolePoolInstanceMetricDefinitionsAsync(instance))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMultiRoleMetricDefinitions_GetMetricDefinitionsForAMultiRolePoolOfAnAppServiceEnvironment()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_ListMultiRoleMetricDefinitions.json
            // this example is just showing the usage of "AppServiceEnvironments_ListMultiRoleMetricDefinitions" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (ResourceMetricDefinition item in hostingEnvironmentMultiRolePool.GetMultiRoleMetricDefinitionsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMultiRolePoolSkus_GetAvailableSKUsForScalingAMultiRolePool()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_ListMultiRolePoolSkus.json
            // this example is just showing the usage of "AppServiceEnvironments_ListMultiRolePoolSkus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (AppServicePoolSkuInfo item in hostingEnvironmentMultiRolePool.GetMultiRolePoolSkusAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetMultiRoleUsages_GetUsageMetricsForAMultiRolePoolOfAnAppServiceEnvironment()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/AppServiceEnvironments_ListMultiRoleUsages.json
            // this example is just showing the usage of "AppServiceEnvironments_ListMultiRoleUsages" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostingEnvironmentMultiRolePoolResource created on azure
            // for more information of creating HostingEnvironmentMultiRolePoolResource, please refer to the document of HostingEnvironmentMultiRolePoolResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-rg";
            string name = "test-ase";
            ResourceIdentifier hostingEnvironmentMultiRolePoolResourceId = HostingEnvironmentMultiRolePoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            HostingEnvironmentMultiRolePoolResource hostingEnvironmentMultiRolePool = client.GetHostingEnvironmentMultiRolePoolResource(hostingEnvironmentMultiRolePoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (AppServiceUsage item in hostingEnvironmentMultiRolePool.GetMultiRoleUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
