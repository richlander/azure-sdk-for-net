// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PostgreSql.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.PostgreSql.Samples
{
    public partial class Sample_PostgreSqlServerSecurityAlertPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateAServerSThreatDetectionPolicyWithAllParameters()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerSecurityAlertsCreateMax.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerSecurityAlertPolicyResource
            PostgreSqlServerSecurityAlertPolicyCollection collection = postgreSqlServer.GetPostgreSqlServerSecurityAlertPolicies();

            // invoke the operation
            PostgreSqlSecurityAlertPolicyName securityAlertPolicyName = PostgreSqlSecurityAlertPolicyName.Default;
            PostgreSqlServerSecurityAlertPolicyData data = new PostgreSqlServerSecurityAlertPolicyData
            {
                State = PostgreSqlServerSecurityAlertPolicyState.Enabled,
                DisabledAlerts = { "Access_Anomaly", "Usage_Anomaly" },
                EmailAddresses = { "testSecurityAlert@microsoft.com" },
                SendToEmailAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 5,
            };
            ArmOperation<PostgreSqlServerSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            PostgreSqlServerSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateAServerSThreatDetectionPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerSecurityAlertsCreateMin.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerSecurityAlertPolicyResource
            PostgreSqlServerSecurityAlertPolicyCollection collection = postgreSqlServer.GetPostgreSqlServerSecurityAlertPolicies();

            // invoke the operation
            PostgreSqlSecurityAlertPolicyName securityAlertPolicyName = PostgreSqlSecurityAlertPolicyName.Default;
            PostgreSqlServerSecurityAlertPolicyData data = new PostgreSqlServerSecurityAlertPolicyData
            {
                State = PostgreSqlServerSecurityAlertPolicyState.Disabled,
                SendToEmailAccountAdmins = true,
            };
            ArmOperation<PostgreSqlServerSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            PostgreSqlServerSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerSecurityAlertsGet.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerSecurityAlertPolicyResource
            PostgreSqlServerSecurityAlertPolicyCollection collection = postgreSqlServer.GetPostgreSqlServerSecurityAlertPolicies();

            // invoke the operation
            PostgreSqlSecurityAlertPolicyName securityAlertPolicyName = PostgreSqlSecurityAlertPolicyName.Default;
            PostgreSqlServerSecurityAlertPolicyResource result = await collection.GetAsync(securityAlertPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PostgreSqlServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListTheServerSThreatDetectionPolicies()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerSecurityAlertsListByServer.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerSecurityAlertPolicyResource
            PostgreSqlServerSecurityAlertPolicyCollection collection = postgreSqlServer.GetPostgreSqlServerSecurityAlertPolicies();

            // invoke the operation and iterate over the result
            await foreach (PostgreSqlServerSecurityAlertPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlServerSecurityAlertPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerSecurityAlertsGet.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerSecurityAlertPolicyResource
            PostgreSqlServerSecurityAlertPolicyCollection collection = postgreSqlServer.GetPostgreSqlServerSecurityAlertPolicies();

            // invoke the operation
            PostgreSqlSecurityAlertPolicyName securityAlertPolicyName = PostgreSqlSecurityAlertPolicyName.Default;
            bool result = await collection.ExistsAsync(securityAlertPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/postgresql/resource-manager/Microsoft.DBforPostgreSQL/stable/2017-12-01/examples/ServerSecurityAlertsGet.json
            // this example is just showing the usage of "ServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PostgreSqlServerResource created on azure
            // for more information of creating PostgreSqlServerResource, please refer to the document of PostgreSqlServerResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string serverName = "securityalert-6440";
            ResourceIdentifier postgreSqlServerResourceId = PostgreSqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            PostgreSqlServerResource postgreSqlServer = client.GetPostgreSqlServerResource(postgreSqlServerResourceId);

            // get the collection of this PostgreSqlServerSecurityAlertPolicyResource
            PostgreSqlServerSecurityAlertPolicyCollection collection = postgreSqlServer.GetPostgreSqlServerSecurityAlertPolicies();

            // invoke the operation
            PostgreSqlSecurityAlertPolicyName securityAlertPolicyName = PostgreSqlSecurityAlertPolicyName.Default;
            NullableResponse<PostgreSqlServerSecurityAlertPolicyResource> response = await collection.GetIfExistsAsync(securityAlertPolicyName);
            PostgreSqlServerSecurityAlertPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                PostgreSqlServerSecurityAlertPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
