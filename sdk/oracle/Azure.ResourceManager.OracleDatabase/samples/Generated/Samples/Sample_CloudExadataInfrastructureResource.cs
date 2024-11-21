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
    public partial class Sample_CloudExadataInfrastructureResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCloudExadataInfrastructures_ListExadataInfrastructureBySubscription()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_listBySubscription.json
            // this example is just showing the usage of "CloudExadataInfrastructures_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (CloudExadataInfrastructureResource item in subscriptionResource.GetCloudExadataInfrastructuresAsync())
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

            // this example assumes you already have this CloudExadataInfrastructureResource created on azure
            // for more information of creating CloudExadataInfrastructureResource, please refer to the document of CloudExadataInfrastructureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudexadatainfrastructurename = "infra1";
            ResourceIdentifier cloudExadataInfrastructureResourceId = CloudExadataInfrastructureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudexadatainfrastructurename);
            CloudExadataInfrastructureResource cloudExadataInfrastructure = client.GetCloudExadataInfrastructureResource(cloudExadataInfrastructureResourceId);

            // invoke the operation
            CloudExadataInfrastructureResource result = await cloudExadataInfrastructure.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudExadataInfrastructureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchExadataInfrastructure()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_patch.json
            // this example is just showing the usage of "CloudExadataInfrastructures_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudExadataInfrastructureResource created on azure
            // for more information of creating CloudExadataInfrastructureResource, please refer to the document of CloudExadataInfrastructureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudexadatainfrastructurename = "infra1";
            ResourceIdentifier cloudExadataInfrastructureResourceId = CloudExadataInfrastructureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudexadatainfrastructurename);
            CloudExadataInfrastructureResource cloudExadataInfrastructure = client.GetCloudExadataInfrastructureResource(cloudExadataInfrastructureResourceId);

            // invoke the operation
            CloudExadataInfrastructurePatch patch = new CloudExadataInfrastructurePatch();
            ArmOperation<CloudExadataInfrastructureResource> lro = await cloudExadataInfrastructure.UpdateAsync(WaitUntil.Completed, patch);
            CloudExadataInfrastructureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudExadataInfrastructureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteExadataInfrastructure()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_delete.json
            // this example is just showing the usage of "CloudExadataInfrastructures_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudExadataInfrastructureResource created on azure
            // for more information of creating CloudExadataInfrastructureResource, please refer to the document of CloudExadataInfrastructureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudexadatainfrastructurename = "infra1";
            ResourceIdentifier cloudExadataInfrastructureResourceId = CloudExadataInfrastructureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudexadatainfrastructurename);
            CloudExadataInfrastructureResource cloudExadataInfrastructure = client.GetCloudExadataInfrastructureResource(cloudExadataInfrastructureResourceId);

            // invoke the operation
            await cloudExadataInfrastructure.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task AddStorageCapacity_PerformAddStorageCapacityOnExadataInfra()
        {
            // Generated from example definition: specification/oracle/resource-manager/Oracle.Database/stable/2023-09-01/examples/exaInfra_addStorageCapacity.json
            // this example is just showing the usage of "CloudExadataInfrastructures_AddStorageCapacity" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CloudExadataInfrastructureResource created on azure
            // for more information of creating CloudExadataInfrastructureResource, please refer to the document of CloudExadataInfrastructureResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg000";
            string cloudexadatainfrastructurename = "infra1";
            ResourceIdentifier cloudExadataInfrastructureResourceId = CloudExadataInfrastructureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cloudexadatainfrastructurename);
            CloudExadataInfrastructureResource cloudExadataInfrastructure = client.GetCloudExadataInfrastructureResource(cloudExadataInfrastructureResourceId);

            // invoke the operation
            ArmOperation<CloudExadataInfrastructureResource> lro = await cloudExadataInfrastructure.AddStorageCapacityAsync(WaitUntil.Completed);
            CloudExadataInfrastructureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CloudExadataInfrastructureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
