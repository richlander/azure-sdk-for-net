// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementPortalRevisionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetEntityTag_ApiManagementHeadPortalRevision()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementHeadPortalRevision.json
            // this example is just showing the usage of "PortalRevision_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalRevisionResource created on azure
            // for more information of creating ApiManagementPortalRevisionResource, please refer to the document of ApiManagementPortalRevisionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string portalRevisionId = "20201112101010";
            ResourceIdentifier apiManagementPortalRevisionResourceId = ApiManagementPortalRevisionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, portalRevisionId);
            ApiManagementPortalRevisionResource apiManagementPortalRevision = client.GetApiManagementPortalRevisionResource(apiManagementPortalRevisionResourceId);

            // invoke the operation
            bool result = await apiManagementPortalRevision.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetPortalRevision()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetPortalRevision.json
            // this example is just showing the usage of "PortalRevision_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalRevisionResource created on azure
            // for more information of creating ApiManagementPortalRevisionResource, please refer to the document of ApiManagementPortalRevisionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string portalRevisionId = "20201112101010";
            ResourceIdentifier apiManagementPortalRevisionResourceId = ApiManagementPortalRevisionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, portalRevisionId);
            ApiManagementPortalRevisionResource apiManagementPortalRevision = client.GetApiManagementPortalRevisionResource(apiManagementPortalRevisionResourceId);

            // invoke the operation
            ApiManagementPortalRevisionResource result = await apiManagementPortalRevision.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPortalRevisionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementUpdatePortalRevision()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementUpdatePortalRevision.json
            // this example is just showing the usage of "PortalRevision_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPortalRevisionResource created on azure
            // for more information of creating ApiManagementPortalRevisionResource, please refer to the document of ApiManagementPortalRevisionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string portalRevisionId = "20201112101010";
            ResourceIdentifier apiManagementPortalRevisionResourceId = ApiManagementPortalRevisionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, portalRevisionId);
            ApiManagementPortalRevisionResource apiManagementPortalRevision = client.GetApiManagementPortalRevisionResource(apiManagementPortalRevisionResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            ApiManagementPortalRevisionData data = new ApiManagementPortalRevisionData()
            {
                Description = "portal revision update",
                IsCurrent = true,
            };
            ArmOperation<ApiManagementPortalRevisionResource> lro = await apiManagementPortalRevision.UpdateAsync(WaitUntil.Completed, ifMatch, data);
            ApiManagementPortalRevisionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPortalRevisionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
