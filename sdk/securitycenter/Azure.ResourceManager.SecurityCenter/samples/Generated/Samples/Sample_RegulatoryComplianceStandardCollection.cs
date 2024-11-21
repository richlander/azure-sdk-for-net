// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_RegulatoryComplianceStandardCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAllSupportedRegulatoryComplianceStandardsDetailsAndState()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/RegulatoryCompliance/getRegulatoryComplianceStandardList_example.json
            // this example is just showing the usage of "RegulatoryComplianceStandards_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this RegulatoryComplianceStandardResource
            RegulatoryComplianceStandardCollection collection = subscriptionResource.GetRegulatoryComplianceStandards();

            // invoke the operation and iterate over the result
            await foreach (RegulatoryComplianceStandardResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RegulatoryComplianceStandardData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSelectedRegulatoryComplianceStandardDetailsAndState()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/RegulatoryCompliance/getRegulatoryComplianceStandard_example.json
            // this example is just showing the usage of "RegulatoryComplianceStandards_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this RegulatoryComplianceStandardResource
            RegulatoryComplianceStandardCollection collection = subscriptionResource.GetRegulatoryComplianceStandards();

            // invoke the operation
            string regulatoryComplianceStandardName = "PCI-DSS-3.2";
            RegulatoryComplianceStandardResource result = await collection.GetAsync(regulatoryComplianceStandardName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RegulatoryComplianceStandardData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetSelectedRegulatoryComplianceStandardDetailsAndState()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/RegulatoryCompliance/getRegulatoryComplianceStandard_example.json
            // this example is just showing the usage of "RegulatoryComplianceStandards_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this RegulatoryComplianceStandardResource
            RegulatoryComplianceStandardCollection collection = subscriptionResource.GetRegulatoryComplianceStandards();

            // invoke the operation
            string regulatoryComplianceStandardName = "PCI-DSS-3.2";
            bool result = await collection.ExistsAsync(regulatoryComplianceStandardName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetSelectedRegulatoryComplianceStandardDetailsAndState()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2019-01-01-preview/examples/RegulatoryCompliance/getRegulatoryComplianceStandard_example.json
            // this example is just showing the usage of "RegulatoryComplianceStandards_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this RegulatoryComplianceStandardResource
            RegulatoryComplianceStandardCollection collection = subscriptionResource.GetRegulatoryComplianceStandards();

            // invoke the operation
            string regulatoryComplianceStandardName = "PCI-DSS-3.2";
            NullableResponse<RegulatoryComplianceStandardResource> response = await collection.GetIfExistsAsync(regulatoryComplianceStandardName);
            RegulatoryComplianceStandardResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RegulatoryComplianceStandardData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
