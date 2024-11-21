// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ExtendedServerBlobAuditingPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListExtendedAuditingSettingsOfAServer()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ServerExtendedAuditingSettingsList.json
            // this example is just showing the usage of "ExtendedServerBlobAuditingPolicies_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ExtendedServerBlobAuditingPolicyResource
            ExtendedServerBlobAuditingPolicyCollection collection = sqlServer.GetExtendedServerBlobAuditingPolicies();

            // invoke the operation and iterate over the result
            await foreach (ExtendedServerBlobAuditingPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExtendedServerBlobAuditingPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServerSBlobExtendedAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedServerBlobAuditingGet.json
            // this example is just showing the usage of "ExtendedServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ExtendedServerBlobAuditingPolicyResource
            ExtendedServerBlobAuditingPolicyCollection collection = sqlServer.GetExtendedServerBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedServerBlobAuditingPolicyResource result = await collection.GetAsync(blobAuditingPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAServerSBlobExtendedAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedServerBlobAuditingGet.json
            // this example is just showing the usage of "ExtendedServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ExtendedServerBlobAuditingPolicyResource
            ExtendedServerBlobAuditingPolicyCollection collection = sqlServer.GetExtendedServerBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            bool result = await collection.ExistsAsync(blobAuditingPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAServerSBlobExtendedAuditingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedServerBlobAuditingGet.json
            // this example is just showing the usage of "ExtendedServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ExtendedServerBlobAuditingPolicyResource
            ExtendedServerBlobAuditingPolicyCollection collection = sqlServer.GetExtendedServerBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            NullableResponse<ExtendedServerBlobAuditingPolicyResource> response = await collection.GetIfExistsAsync(blobAuditingPolicyName);
            ExtendedServerBlobAuditingPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExtendedServerBlobAuditingPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateAServerSExtendedBlobAuditingPolicyWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedServerBlobAuditingCreateMax.json
            // this example is just showing the usage of "ExtendedServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ExtendedServerBlobAuditingPolicyResource
            ExtendedServerBlobAuditingPolicyCollection collection = sqlServer.GetExtendedServerBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedServerBlobAuditingPolicyData data = new ExtendedServerBlobAuditingPolicyData()
            {
                PredicateExpression = "object_name = 'SensitiveData'",
                RetentionDays = 6,
                AuditActionsAndGroups =
{
"SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP","FAILED_DATABASE_AUTHENTICATION_GROUP","BATCH_COMPLETED_GROUP"
},
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
                QueueDelayMs = 4000,
                State = BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
            };
            ArmOperation<ExtendedServerBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            ExtendedServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateAServerSExtendedBlobAuditingPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/ExtendedServerBlobAuditingCreateMin.json
            // this example is just showing the usage of "ExtendedServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerResource created on azure
            // for more information of creating SqlServerResource, please refer to the document of SqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "blobauditingtest-4799";
            string serverName = "blobauditingtest-6440";
            ResourceIdentifier sqlServerResourceId = SqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerResource sqlServer = client.GetSqlServerResource(sqlServerResourceId);

            // get the collection of this ExtendedServerBlobAuditingPolicyResource
            ExtendedServerBlobAuditingPolicyCollection collection = sqlServer.GetExtendedServerBlobAuditingPolicies();

            // invoke the operation
            BlobAuditingPolicyName blobAuditingPolicyName = BlobAuditingPolicyName.Default;
            ExtendedServerBlobAuditingPolicyData data = new ExtendedServerBlobAuditingPolicyData()
            {
                State = BlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };
            ArmOperation<ExtendedServerBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            ExtendedServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExtendedServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
