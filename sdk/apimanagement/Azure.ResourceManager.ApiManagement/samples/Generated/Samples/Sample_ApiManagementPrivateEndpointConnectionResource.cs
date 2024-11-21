// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ApiManagementPrivateEndpointConnectionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPrivateEndpointConnectionResource created on azure
            // for more information of creating ApiManagementPrivateEndpointConnectionResource, please refer to the document of ApiManagementPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier apiManagementPrivateEndpointConnectionResourceId = ApiManagementPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, privateEndpointConnectionName);
            ApiManagementPrivateEndpointConnectionResource apiManagementPrivateEndpointConnection = client.GetApiManagementPrivateEndpointConnectionResource(apiManagementPrivateEndpointConnectionResourceId);

            // invoke the operation
            ApiManagementPrivateEndpointConnectionResource result = await apiManagementPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementApproveOrRejectPrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementApproveOrRejectPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPrivateEndpointConnectionResource created on azure
            // for more information of creating ApiManagementPrivateEndpointConnectionResource, please refer to the document of ApiManagementPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier apiManagementPrivateEndpointConnectionResourceId = ApiManagementPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, privateEndpointConnectionName);
            ApiManagementPrivateEndpointConnectionResource apiManagementPrivateEndpointConnection = client.GetApiManagementPrivateEndpointConnectionResource(apiManagementPrivateEndpointConnectionResourceId);

            // invoke the operation
            ApiManagementPrivateEndpointConnectionCreateOrUpdateContent content = new ApiManagementPrivateEndpointConnectionCreateOrUpdateContent()
            {
                Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/privateEndpointConnections/connectionName"),
                PrivateLinkServiceConnectionState = new ApiManagementPrivateLinkServiceConnectionState()
                {
                    Status = ApiManagementPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "The Private Endpoint Connection is approved.",
                },
            };
            ArmOperation<ApiManagementPrivateEndpointConnectionResource> lro = await apiManagementPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, content);
            ApiManagementPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApiManagementPrivateEndpointConnectionResource created on azure
            // for more information of creating ApiManagementPrivateEndpointConnectionResource, please refer to the document of ApiManagementPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string privateEndpointConnectionName = "privateEndpointConnectionName";
            ResourceIdentifier apiManagementPrivateEndpointConnectionResourceId = ApiManagementPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, privateEndpointConnectionName);
            ApiManagementPrivateEndpointConnectionResource apiManagementPrivateEndpointConnection = client.GetApiManagementPrivateEndpointConnectionResource(apiManagementPrivateEndpointConnectionResourceId);

            // invoke the operation
            await apiManagementPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
