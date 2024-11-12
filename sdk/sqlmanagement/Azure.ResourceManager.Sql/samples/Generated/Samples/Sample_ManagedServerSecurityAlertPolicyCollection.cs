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
    public partial class Sample_ManagedServerSecurityAlertPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAManagedServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedServerSecurityAlertGet.json
            // this example is just showing the usage of "ManagedServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string managedInstanceName = "securityalert-6440";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerSecurityAlertPolicyResource
            ManagedServerSecurityAlertPolicyCollection collection = managedInstance.GetManagedServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            ManagedServerSecurityAlertPolicyResource result = await collection.GetAsync(securityAlertPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAManagedServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedServerSecurityAlertGet.json
            // this example is just showing the usage of "ManagedServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string managedInstanceName = "securityalert-6440";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerSecurityAlertPolicyResource
            ManagedServerSecurityAlertPolicyCollection collection = managedInstance.GetManagedServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            bool result = await collection.ExistsAsync(securityAlertPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAManagedServerSThreatDetectionPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedServerSecurityAlertGet.json
            // this example is just showing the usage of "ManagedServerSecurityAlertPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string managedInstanceName = "securityalert-6440";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerSecurityAlertPolicyResource
            ManagedServerSecurityAlertPolicyCollection collection = managedInstance.GetManagedServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            NullableResponse<ManagedServerSecurityAlertPolicyResource> response = await collection.GetIfExistsAsync(securityAlertPolicyName);
            ManagedServerSecurityAlertPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServerSecurityAlertPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateAManagedServerSThreatDetectionPolicyWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedServerSecurityAlertCreateMax.json
            // this example is just showing the usage of "ManagedServerSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string managedInstanceName = "securityalert-6440";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerSecurityAlertPolicyResource
            ManagedServerSecurityAlertPolicyCollection collection = managedInstance.GetManagedServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            ManagedServerSecurityAlertPolicyData data = new ManagedServerSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
                DisabledAlerts =
{
"Access_Anomaly","Usage_Anomaly"
},
                EmailAddresses =
{
"testSecurityAlert@microsoft.com"
},
                SendToEmailAccountAdmins = true,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 5,
            };
            ArmOperation<ManagedServerSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            ManagedServerSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_UpdateAManagedServerSThreatDetectionPolicyWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedServerSecurityAlertCreateMin.json
            // this example is just showing the usage of "ManagedServerSecurityAlertPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string managedInstanceName = "securityalert-6440";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerSecurityAlertPolicyResource
            ManagedServerSecurityAlertPolicyCollection collection = managedInstance.GetManagedServerSecurityAlertPolicies();

            // invoke the operation
            SqlSecurityAlertPolicyName securityAlertPolicyName = SqlSecurityAlertPolicyName.Default;
            ManagedServerSecurityAlertPolicyData data = new ManagedServerSecurityAlertPolicyData()
            {
                State = SecurityAlertsPolicyState.Enabled,
            };
            ArmOperation<ManagedServerSecurityAlertPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, securityAlertPolicyName, data);
            ManagedServerSecurityAlertPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedServerSecurityAlertPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetTheManagedServerSThreatDetectionPolicies()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ManagedServerSecurityAlertListByInstance.json
            // this example is just showing the usage of "ManagedServerSecurityAlertPolicies_ListByInstance" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedInstanceResource created on azure
            // for more information of creating ManagedInstanceResource, please refer to the document of ManagedInstanceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "securityalert-4799";
            string managedInstanceName = "securityalert-6440";
            ResourceIdentifier managedInstanceResourceId = ManagedInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName);
            ManagedInstanceResource managedInstance = client.GetManagedInstanceResource(managedInstanceResourceId);

            // get the collection of this ManagedServerSecurityAlertPolicyResource
            ManagedServerSecurityAlertPolicyCollection collection = managedInstance.GetManagedServerSecurityAlertPolicies();

            // invoke the operation and iterate over the result
            await foreach (ManagedServerSecurityAlertPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedServerSecurityAlertPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
