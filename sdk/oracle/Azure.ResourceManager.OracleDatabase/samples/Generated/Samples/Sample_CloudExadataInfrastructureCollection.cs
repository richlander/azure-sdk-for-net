// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OracleDatabase.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.OracleDatabase.Samples
{
    public partial class Sample_CloudExadataInfrastructureCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListExadataInfrastructureByResourceGroup()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_listByResourceGroup.json
            // this example is just showing the usage of "CloudExadataInfrastructures_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudExadataInfrastructureResource
            CloudExadataInfrastructureCollection collection = resourceGroupResource.GetCloudExadataInfrastructures();

            // invoke the operation and iterate over the result
            await foreach (CloudExadataInfrastructureResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudExadataInfrastructureData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetExadataInfrastructure()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_get.json
            // this example is just showing the usage of "CloudExadataInfrastructures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudExadataInfrastructureResource
            CloudExadataInfrastructureCollection collection = resourceGroupResource.GetCloudExadataInfrastructures();

            // invoke the operation
            string cloudexadatainfrastructurename = "infra1";
            CloudExadataInfrastructureResource result = await collection.GetAsync(cloudexadatainfrastructurename);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudExadataInfrastructureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetExadataInfrastructure()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_get.json
            // this example is just showing the usage of "CloudExadataInfrastructures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudExadataInfrastructureResource
            CloudExadataInfrastructureCollection collection = resourceGroupResource.GetCloudExadataInfrastructures();

            // invoke the operation
            string cloudexadatainfrastructurename = "infra1";
            bool result = await collection.ExistsAsync(cloudexadatainfrastructurename);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetExadataInfrastructure()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_get.json
            // this example is just showing the usage of "CloudExadataInfrastructures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudExadataInfrastructureResource
            CloudExadataInfrastructureCollection collection = resourceGroupResource.GetCloudExadataInfrastructures();

            // invoke the operation
            string cloudexadatainfrastructurename = "infra1";
            NullableResponse<CloudExadataInfrastructureResource> response = await collection.GetIfExistsAsync(cloudexadatainfrastructurename);
            CloudExadataInfrastructureResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CloudExadataInfrastructureData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateExadataInfrastructure()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_create.json
            // this example is just showing the usage of "CloudExadataInfrastructures_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this CloudExadataInfrastructureResource
            CloudExadataInfrastructureCollection collection = resourceGroupResource.GetCloudExadataInfrastructures();

            // invoke the operation
            string cloudexadatainfrastructurename = "infra1";
            CloudExadataInfrastructureData data = new CloudExadataInfrastructureData(new AzureLocation("eastus"), new string[]
            {
"1"
            })
            {
                Properties = new CloudExadataInfrastructureProperties("EXADATA.X9M", "infra 1")
                {
                    ComputeCount = 100,
                    StorageCount = 10,
                },
                Tags =
{
["tagK1"] = "tagV1",
},
            };
            ArmOperation<CloudExadataInfrastructureResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, cloudexadatainfrastructurename, data);
            CloudExadataInfrastructureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudExadataInfrastructureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
