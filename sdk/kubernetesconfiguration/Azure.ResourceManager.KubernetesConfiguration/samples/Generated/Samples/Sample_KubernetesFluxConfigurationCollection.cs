// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.KubernetesConfiguration.Samples
{
    public partial class Sample_KubernetesFluxConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateFluxConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/CreateFluxConfiguration.json
            // this example is just showing the usage of "FluxConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesFluxConfigurationResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesFluxConfigurationCollection collection = resourceGroupResource.GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string fluxConfigurationName = "srs-fluxconfig";
            KubernetesFluxConfigurationData data = new KubernetesFluxConfigurationData
            {
                Scope = KubernetesConfigurationScope.Cluster,
                Namespace = "srs-namespace",
                SourceKind = KubernetesConfigurationSourceKind.GitRepository,
                IsReconciliationSuspended = false,
                GitRepository = new KubernetesGitRepository
                {
                    Uri = new Uri("https://github.com/Azure/arc-k8s-demo"),
                    TimeoutInSeconds = 600L,
                    SyncIntervalInSeconds = 600L,
                    RepositoryRef = new KubernetesGitRepositoryRef
                    {
                        Branch = "master",
                    },
                    HttpsCACert = "ZXhhbXBsZWNlcnRpZmljYXRl",
                },
                Kustomizations =
{
["srs-kustomization1"] = new Kustomization
{
Path = "./test/path",
DependsOn = {},
TimeoutInSeconds = 600L,
SyncIntervalInSeconds = 600L,
},
["srs-kustomization2"] = new Kustomization
{
Path = "./other/test/path",
DependsOn = {"srs-kustomization1"},
TimeoutInSeconds = 600L,
SyncIntervalInSeconds = 600L,
RetryIntervalInSeconds = 600L,
Prune = false,
}
},
            };
            ArmOperation<KubernetesFluxConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fluxConfigurationName, data);
            KubernetesFluxConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesFluxConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateFluxConfigurationWithBucketSourceKind()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/CreateFluxConfigurationWithBucket.json
            // this example is just showing the usage of "FluxConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesFluxConfigurationResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesFluxConfigurationCollection collection = resourceGroupResource.GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string fluxConfigurationName = "srs-fluxconfig";
            KubernetesFluxConfigurationData data = new KubernetesFluxConfigurationData
            {
                Scope = KubernetesConfigurationScope.Cluster,
                Namespace = "srs-namespace",
                SourceKind = KubernetesConfigurationSourceKind.Bucket,
                IsReconciliationSuspended = false,
                Bucket = new KubernetesBucket
                {
                    Uri = new Uri("https://fluxminiotest.az.minio.io"),
                    BucketName = "flux",
                    TimeoutInSeconds = 1000L,
                    SyncIntervalInSeconds = 1000L,
                    AccessKey = "fluxminiotest",
                },
                Kustomizations =
{
["srs-kustomization1"] = new Kustomization
{
Path = "./test/path",
DependsOn = {},
TimeoutInSeconds = 600L,
SyncIntervalInSeconds = 600L,
},
["srs-kustomization2"] = new Kustomization
{
Path = "./other/test/path",
DependsOn = {"srs-kustomization1"},
TimeoutInSeconds = 600L,
SyncIntervalInSeconds = 600L,
RetryIntervalInSeconds = 600L,
Prune = false,
}
},
            };
            ArmOperation<KubernetesFluxConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, fluxConfigurationName, data);
            KubernetesFluxConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesFluxConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetFluxConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetFluxConfiguration.json
            // this example is just showing the usage of "FluxConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesFluxConfigurationResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesFluxConfigurationCollection collection = resourceGroupResource.GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string fluxConfigurationName = "srs-fluxconfig";
            KubernetesFluxConfigurationResource result = await collection.GetAsync(fluxConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubernetesFluxConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListFluxConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/ListFluxConfigurations.json
            // this example is just showing the usage of "FluxConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesFluxConfigurationResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesFluxConfigurationCollection collection = resourceGroupResource.GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);

            // invoke the operation and iterate over the result
            await foreach (KubernetesFluxConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KubernetesFluxConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetFluxConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetFluxConfiguration.json
            // this example is just showing the usage of "FluxConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesFluxConfigurationResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesFluxConfigurationCollection collection = resourceGroupResource.GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string fluxConfigurationName = "srs-fluxconfig";
            bool result = await collection.ExistsAsync(fluxConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetFluxConfiguration()
        {
            // Generated from example definition: specification/kubernetesconfiguration/resource-manager/Microsoft.KubernetesConfiguration/stable/2022-11-01/examples/GetFluxConfiguration.json
            // this example is just showing the usage of "FluxConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subId1";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this KubernetesFluxConfigurationResource
            string clusterRp = "Microsoft.Kubernetes";
            string clusterResourceName = "connectedClusters";
            string clusterName = "clusterName1";
            KubernetesFluxConfigurationCollection collection = resourceGroupResource.GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);

            // invoke the operation
            string fluxConfigurationName = "srs-fluxconfig";
            NullableResponse<KubernetesFluxConfigurationResource> response = await collection.GetIfExistsAsync(fluxConfigurationName);
            KubernetesFluxConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KubernetesFluxConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
