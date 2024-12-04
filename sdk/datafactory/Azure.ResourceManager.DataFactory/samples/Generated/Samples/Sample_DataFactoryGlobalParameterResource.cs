// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataFactory.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryGlobalParameterResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GlobalParametersGet()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Get.json
            // this example is just showing the usage of "GlobalParameters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryGlobalParameterResource created on azure
            // for more information of creating DataFactoryGlobalParameterResource, please refer to the document of DataFactoryGlobalParameterResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string globalParameterName = "default";
            ResourceIdentifier dataFactoryGlobalParameterResourceId = DataFactoryGlobalParameterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, globalParameterName);
            DataFactoryGlobalParameterResource dataFactoryGlobalParameter = client.GetDataFactoryGlobalParameterResource(dataFactoryGlobalParameterResourceId);

            // invoke the operation
            DataFactoryGlobalParameterResource result = await dataFactoryGlobalParameter.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryGlobalParameterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_GlobalParametersDelete()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Delete.json
            // this example is just showing the usage of "GlobalParameters_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryGlobalParameterResource created on azure
            // for more information of creating DataFactoryGlobalParameterResource, please refer to the document of DataFactoryGlobalParameterResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string globalParameterName = "default";
            ResourceIdentifier dataFactoryGlobalParameterResourceId = DataFactoryGlobalParameterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, globalParameterName);
            DataFactoryGlobalParameterResource dataFactoryGlobalParameter = client.GetDataFactoryGlobalParameterResource(dataFactoryGlobalParameterResourceId);

            // invoke the operation
            await dataFactoryGlobalParameter.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_GlobalParametersCreate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Create.json
            // this example is just showing the usage of "GlobalParameters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryGlobalParameterResource created on azure
            // for more information of creating DataFactoryGlobalParameterResource, please refer to the document of DataFactoryGlobalParameterResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string globalParameterName = "default";
            ResourceIdentifier dataFactoryGlobalParameterResourceId = DataFactoryGlobalParameterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, globalParameterName);
            DataFactoryGlobalParameterResource dataFactoryGlobalParameter = client.GetDataFactoryGlobalParameterResource(dataFactoryGlobalParameterResourceId);

            // invoke the operation
            DataFactoryGlobalParameterData data = new DataFactoryGlobalParameterData(new Dictionary<string, DataFactoryGlobalParameterProperties>
            {
                ["waitTime"] = new DataFactoryGlobalParameterProperties(DataFactoryGlobalParameterType.Int, BinaryData.FromObjectAsJson("5"))
            });
            ArmOperation<DataFactoryGlobalParameterResource> lro = await dataFactoryGlobalParameter.UpdateAsync(WaitUntil.Completed, data);
            DataFactoryGlobalParameterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryGlobalParameterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_GlobalParametersUpdate()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GlobalParameters_Update.json
            // this example is just showing the usage of "GlobalParameters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryGlobalParameterResource created on azure
            // for more information of creating DataFactoryGlobalParameterResource, please refer to the document of DataFactoryGlobalParameterResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            string globalParameterName = "default";
            ResourceIdentifier dataFactoryGlobalParameterResourceId = DataFactoryGlobalParameterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName, globalParameterName);
            DataFactoryGlobalParameterResource dataFactoryGlobalParameter = client.GetDataFactoryGlobalParameterResource(dataFactoryGlobalParameterResourceId);

            // invoke the operation
            DataFactoryGlobalParameterData data = new DataFactoryGlobalParameterData(new Dictionary<string, DataFactoryGlobalParameterProperties>
            {
                ["waitTime"] = new DataFactoryGlobalParameterProperties(DataFactoryGlobalParameterType.Int, BinaryData.FromObjectAsJson("5"))
            });
            ArmOperation<DataFactoryGlobalParameterResource> lro = await dataFactoryGlobalParameter.UpdateAsync(WaitUntil.Completed, data);
            DataFactoryGlobalParameterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryGlobalParameterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
