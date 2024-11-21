// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridNetwork.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_ConfigurationGroupSchemaResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteANetworkFunctionGroupResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupSchemaDelete.json
            // this example is just showing the usage of "ConfigurationGroupSchemas_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupSchemaResource created on azure
            // for more information of creating ConfigurationGroupSchemaResource, please refer to the document of ConfigurationGroupSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publisherName = "testPublisher";
            string configurationGroupSchemaName = "testConfigurationGroupSchema";
            ResourceIdentifier configurationGroupSchemaResourceId = ConfigurationGroupSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, configurationGroupSchemaName);
            ConfigurationGroupSchemaResource configurationGroupSchema = client.GetConfigurationGroupSchemaResource(configurationGroupSchemaResourceId);

            // invoke the operation
            await configurationGroupSchema.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetANetworkFunctionDefinitionGroupResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupSchemaGet.json
            // this example is just showing the usage of "ConfigurationGroupSchemas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupSchemaResource created on azure
            // for more information of creating ConfigurationGroupSchemaResource, please refer to the document of ConfigurationGroupSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publisherName = "testPublisher";
            string configurationGroupSchemaName = "testConfigurationGroupSchema";
            ResourceIdentifier configurationGroupSchemaResourceId = ConfigurationGroupSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, configurationGroupSchemaName);
            ConfigurationGroupSchemaResource configurationGroupSchema = client.GetConfigurationGroupSchemaResource(configurationGroupSchemaResourceId);

            // invoke the operation
            ConfigurationGroupSchemaResource result = await configurationGroupSchema.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfigurationGroupSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateOrUpdateTheConfigurationGroupSchemaResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupSchemaUpdateTags.json
            // this example is just showing the usage of "ConfigurationGroupSchemas_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupSchemaResource created on azure
            // for more information of creating ConfigurationGroupSchemaResource, please refer to the document of ConfigurationGroupSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publisherName = "testPublisher";
            string configurationGroupSchemaName = "testConfigurationGroupSchema";
            ResourceIdentifier configurationGroupSchemaResourceId = ConfigurationGroupSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, configurationGroupSchemaName);
            ConfigurationGroupSchemaResource configurationGroupSchema = client.GetConfigurationGroupSchemaResource(configurationGroupSchemaResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ConfigurationGroupSchemaResource result = await configurationGroupSchema.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfigurationGroupSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateState_UpdateNetworkServiceDesignVersionState()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/ConfigurationGroupSchemaVersionUpdateState.json
            // this example is just showing the usage of "ConfigurationGroupSchemas_UpdateState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfigurationGroupSchemaResource created on azure
            // for more information of creating ConfigurationGroupSchemaResource, please refer to the document of ConfigurationGroupSchemaResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string publisherName = "testPublisher";
            string configurationGroupSchemaName = "testConfigurationGroupSchema";
            ResourceIdentifier configurationGroupSchemaResourceId = ConfigurationGroupSchemaResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, configurationGroupSchemaName);
            ConfigurationGroupSchemaResource configurationGroupSchema = client.GetConfigurationGroupSchemaResource(configurationGroupSchemaResourceId);

            // invoke the operation
            ConfigurationGroupSchemaVersionUpdateState configurationGroupSchemaVersionUpdateState = new ConfigurationGroupSchemaVersionUpdateState()
            {
                VersionState = VersionState.Active,
            };
            ArmOperation<ConfigurationGroupSchemaVersionUpdateState> lro = await configurationGroupSchema.UpdateStateAsync(WaitUntil.Completed, configurationGroupSchemaVersionUpdateState);
            ConfigurationGroupSchemaVersionUpdateState result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
