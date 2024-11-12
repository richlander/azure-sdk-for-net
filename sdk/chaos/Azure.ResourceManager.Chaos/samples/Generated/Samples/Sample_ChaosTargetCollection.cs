// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ChaosTargetCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllTargetsThatExtendAVirtualMachineResource()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/ListTargets.json
            // this example is just showing the usage of "Targets_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ChaosTargetResource
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            ChaosTargetCollection collection = resourceGroupResource.GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName);

            // invoke the operation and iterate over the result
            string continuationToken = null;
            await foreach (ChaosTargetResource item in collection.GetAllAsync(continuationToken: continuationToken))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ChaosTargetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetATargetThatExtendsAVirtualMachineResource()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/GetTarget.json
            // this example is just showing the usage of "Targets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ChaosTargetResource
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            ChaosTargetCollection collection = resourceGroupResource.GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName);

            // invoke the operation
            string targetName = "Microsoft-Agent";
            ChaosTargetResource result = await collection.GetAsync(targetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetATargetThatExtendsAVirtualMachineResource()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/GetTarget.json
            // this example is just showing the usage of "Targets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ChaosTargetResource
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            ChaosTargetCollection collection = resourceGroupResource.GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName);

            // invoke the operation
            string targetName = "Microsoft-Agent";
            bool result = await collection.ExistsAsync(targetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetATargetThatExtendsAVirtualMachineResource()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/GetTarget.json
            // this example is just showing the usage of "Targets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ChaosTargetResource
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            ChaosTargetCollection collection = resourceGroupResource.GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName);

            // invoke the operation
            string targetName = "Microsoft-Agent";
            NullableResponse<ChaosTargetResource> response = await collection.GetIfExistsAsync(targetName);
            ChaosTargetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ChaosTargetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateUpdateATargetThatExtendsAVirtualMachineResource()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/stable/2024-01-01/examples/CreateUpdateTarget.json
            // this example is just showing the usage of "Targets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ChaosTargetResource
            string parentProviderNamespace = "Microsoft.Compute";
            string parentResourceType = "virtualMachines";
            string parentResourceName = "exampleVM";
            ChaosTargetCollection collection = resourceGroupResource.GetChaosTargets(parentProviderNamespace, parentResourceType, parentResourceName);

            // invoke the operation
            string targetName = "Microsoft-Agent";
            ChaosTargetData data = new ChaosTargetData(new Dictionary<string, BinaryData>()
            {
                ["identities"] = BinaryData.FromObjectAsJson(new object[] { new Dictionary<string, object>()
{
["type"] = "CertificateSubjectIssuer",
["subject"] = "CN=example.subject"} }),
            });
            ArmOperation<ChaosTargetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, targetName, data);
            ChaosTargetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
