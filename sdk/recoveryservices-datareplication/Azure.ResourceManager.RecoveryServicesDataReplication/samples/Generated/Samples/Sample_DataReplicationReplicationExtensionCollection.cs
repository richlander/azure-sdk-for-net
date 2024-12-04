// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Samples
{
    public partial class Sample_DataReplicationReplicationExtensionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ReplicationExtensionCreate()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ReplicationExtension_Create.json
            // this example is just showing the usage of "ReplicationExtension_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationReplicationExtensionResource
            DataReplicationReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            DataReplicationReplicationExtensionData data = new DataReplicationReplicationExtensionData(new DataReplicationReplicationExtensionProperties(new GeneralReplicationExtensionModelCustomProperties()));
            ArmOperation<DataReplicationReplicationExtensionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, replicationExtensionName, data);
            DataReplicationReplicationExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationReplicationExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ReplicationExtensionGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ReplicationExtension_Get.json
            // this example is just showing the usage of "ReplicationExtension_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationReplicationExtensionResource
            DataReplicationReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            DataReplicationReplicationExtensionResource result = await collection.GetAsync(replicationExtensionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataReplicationReplicationExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ReplicationExtensionList()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ReplicationExtension_List.json
            // this example is just showing the usage of "ReplicationExtension_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationReplicationExtensionResource
            DataReplicationReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationReplicationExtensions();

            // invoke the operation and iterate over the result
            await foreach (DataReplicationReplicationExtensionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationReplicationExtensionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ReplicationExtensionGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ReplicationExtension_Get.json
            // this example is just showing the usage of "ReplicationExtension_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationReplicationExtensionResource
            DataReplicationReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            bool result = await collection.ExistsAsync(replicationExtensionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ReplicationExtensionGet()
        {
            // Generated from example definition: specification/recoveryservicesdatareplication/resource-manager/Microsoft.DataReplication/preview/2021-02-16-preview/examples/ReplicationExtension_Get.json
            // this example is just showing the usage of "ReplicationExtension_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataReplicationVaultResource created on azure
            // for more information of creating DataReplicationVaultResource, please refer to the document of DataReplicationVaultResource
            string subscriptionId = "930CEC23-4430-4513-B855-DBA237E2F3BF";
            string resourceGroupName = "rgrecoveryservicesdatareplication";
            string vaultName = "4";
            ResourceIdentifier dataReplicationVaultResourceId = DataReplicationVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            DataReplicationVaultResource dataReplicationVault = client.GetDataReplicationVaultResource(dataReplicationVaultResourceId);

            // get the collection of this DataReplicationReplicationExtensionResource
            DataReplicationReplicationExtensionCollection collection = dataReplicationVault.GetDataReplicationReplicationExtensions();

            // invoke the operation
            string replicationExtensionName = "g16yjJ";
            NullableResponse<DataReplicationReplicationExtensionResource> response = await collection.GetIfExistsAsync(replicationExtensionName);
            DataReplicationReplicationExtensionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataReplicationReplicationExtensionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
