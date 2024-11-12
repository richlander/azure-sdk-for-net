// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Quantum.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Quantum.Samples
{
    public partial class Sample_QuantumWorkspaceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QuantumWorkspacesGet()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/quantumWorkspacesGet.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QuantumWorkspaceResource created on azure
            // for more information of creating QuantumWorkspaceResource, please refer to the document of QuantumWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "quantumResourcegroup";
            string workspaceName = "quantumworkspace1";
            ResourceIdentifier quantumWorkspaceResourceId = QuantumWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            QuantumWorkspaceResource quantumWorkspace = client.GetQuantumWorkspaceResource(quantumWorkspaceResourceId);

            // invoke the operation
            QuantumWorkspaceResource result = await quantumWorkspace.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuantumWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_QuantumWorkspacesPatchTags()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/quantumWorkspacesPatch.json
            // this example is just showing the usage of "Workspaces_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QuantumWorkspaceResource created on azure
            // for more information of creating QuantumWorkspaceResource, please refer to the document of QuantumWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "quantumResourcegroup";
            string workspaceName = "quantumworkspace1";
            ResourceIdentifier quantumWorkspaceResourceId = QuantumWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            QuantumWorkspaceResource quantumWorkspace = client.GetQuantumWorkspaceResource(quantumWorkspaceResourceId);

            // invoke the operation
            QuantumWorkspacePatch patch = new QuantumWorkspacePatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            QuantumWorkspaceResource result = await quantumWorkspace.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            QuantumWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_QuantumWorkspacesDelete()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/quantumWorkspacesDelete.json
            // this example is just showing the usage of "Workspaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QuantumWorkspaceResource created on azure
            // for more information of creating QuantumWorkspaceResource, please refer to the document of QuantumWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "quantumResourcegroup";
            string workspaceName = "quantumworkspace1";
            ResourceIdentifier quantumWorkspaceResourceId = QuantumWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            QuantumWorkspaceResource quantumWorkspace = client.GetQuantumWorkspaceResource(quantumWorkspaceResourceId);

            // invoke the operation
            await quantumWorkspace.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetQuantumWorkspaces_QuantumWorkspacesListBySubscription()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/quantumWorkspacesListSubscription.json
            // this example is just showing the usage of "Workspaces_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (QuantumWorkspaceResource item in subscriptionResource.GetQuantumWorkspacesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                QuantumWorkspaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetKeysWorkspace_ListKeys()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/listKeys.json
            // this example is just showing the usage of "Workspace_ListKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QuantumWorkspaceResource created on azure
            // for more information of creating QuantumWorkspaceResource, please refer to the document of QuantumWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "quantumResourcegroup";
            string workspaceName = "quantumworkspace1";
            ResourceIdentifier quantumWorkspaceResourceId = QuantumWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            QuantumWorkspaceResource quantumWorkspace = client.GetQuantumWorkspaceResource(quantumWorkspaceResourceId);

            // invoke the operation
            WorkspaceKeyListResult result = await quantumWorkspace.GetKeysWorkspaceAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RegenerateKeysWorkspace_RegenerateKey()
        {
            // Generated from example definition: specification/quantum/resource-manager/Microsoft.Quantum/preview/2023-11-13-preview/examples/regenerateKey.json
            // this example is just showing the usage of "Workspace_RegenerateKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this QuantumWorkspaceResource created on azure
            // for more information of creating QuantumWorkspaceResource, please refer to the document of QuantumWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "quantumResourcegroup";
            string workspaceName = "quantumworkspace1";
            ResourceIdentifier quantumWorkspaceResourceId = QuantumWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            QuantumWorkspaceResource quantumWorkspace = client.GetQuantumWorkspaceResource(quantumWorkspaceResourceId);

            // invoke the operation
            WorkspaceApiKeys keySpecification = new WorkspaceApiKeys()
            {
                Keys =
{
WorkspaceKeyType.Primary,WorkspaceKeyType.Secondary
},
            };
            await quantumWorkspace.RegenerateKeysWorkspaceAsync(keySpecification);

            Console.WriteLine("Succeeded");
        }
    }
}
