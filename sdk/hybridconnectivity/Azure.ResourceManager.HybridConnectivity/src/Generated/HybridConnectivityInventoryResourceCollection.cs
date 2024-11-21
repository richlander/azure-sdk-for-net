// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridConnectivityInventoryResource"/> and their operations.
    /// Each <see cref="HybridConnectivityInventoryResource"/> in the collection will belong to the same instance of <see cref="SolutionConfigurationResource"/>.
    /// To get a <see cref="HybridConnectivityInventoryResourceCollection"/> instance call the GetHybridConnectivityInventoryResources method from an instance of <see cref="SolutionConfigurationResource"/>.
    /// </summary>
    public partial class HybridConnectivityInventoryResourceCollection : ArmCollection, IEnumerable<HybridConnectivityInventoryResource>, IAsyncEnumerable<HybridConnectivityInventoryResource>
    {
        private readonly ClientDiagnostics _hybridConnectivityInventoryResourceInventoryClientDiagnostics;
        private readonly InventoryRestOperations _hybridConnectivityInventoryResourceInventoryRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityInventoryResourceCollection"/> class for mocking. </summary>
        protected HybridConnectivityInventoryResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridConnectivityInventoryResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridConnectivityInventoryResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridConnectivityInventoryResourceInventoryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridConnectivity", HybridConnectivityInventoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridConnectivityInventoryResource.ResourceType, out string hybridConnectivityInventoryResourceInventoryApiVersion);
            _hybridConnectivityInventoryResourceInventoryRestClient = new InventoryRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridConnectivityInventoryResourceInventoryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SolutionConfigurationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SolutionConfigurationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a InventoryResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory/{inventoryId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryId"> Inventory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryId"/> is null. </exception>
        public virtual async Task<Response<HybridConnectivityInventoryResource>> GetAsync(string inventoryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryId, nameof(inventoryId));

            using var scope = _hybridConnectivityInventoryResourceInventoryClientDiagnostics.CreateScope("HybridConnectivityInventoryResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityInventoryResourceInventoryRestClient.GetAsync(Id.Parent, Id.Name, inventoryId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivityInventoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a InventoryResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory/{inventoryId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryId"> Inventory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryId"/> is null. </exception>
        public virtual Response<HybridConnectivityInventoryResource> Get(string inventoryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryId, nameof(inventoryId));

            using var scope = _hybridConnectivityInventoryResourceInventoryClientDiagnostics.CreateScope("HybridConnectivityInventoryResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridConnectivityInventoryResourceInventoryRestClient.Get(Id.Parent, Id.Name, inventoryId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivityInventoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List InventoryResource resources by SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_ListBySolutionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridConnectivityInventoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridConnectivityInventoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridConnectivityInventoryResourceInventoryRestClient.CreateListBySolutionConfigurationRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridConnectivityInventoryResourceInventoryRestClient.CreateListBySolutionConfigurationNextPageRequest(nextLink, Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridConnectivityInventoryResource(Client, HybridConnectivityInventoryResourceData.DeserializeHybridConnectivityInventoryResourceData(e)), _hybridConnectivityInventoryResourceInventoryClientDiagnostics, Pipeline, "HybridConnectivityInventoryResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List InventoryResource resources by SolutionConfiguration
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_ListBySolutionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridConnectivityInventoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridConnectivityInventoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridConnectivityInventoryResourceInventoryRestClient.CreateListBySolutionConfigurationRequest(Id.Parent, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridConnectivityInventoryResourceInventoryRestClient.CreateListBySolutionConfigurationNextPageRequest(nextLink, Id.Parent, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridConnectivityInventoryResource(Client, HybridConnectivityInventoryResourceData.DeserializeHybridConnectivityInventoryResourceData(e)), _hybridConnectivityInventoryResourceInventoryClientDiagnostics, Pipeline, "HybridConnectivityInventoryResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory/{inventoryId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryId"> Inventory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inventoryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryId, nameof(inventoryId));

            using var scope = _hybridConnectivityInventoryResourceInventoryClientDiagnostics.CreateScope("HybridConnectivityInventoryResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityInventoryResourceInventoryRestClient.GetAsync(Id.Parent, Id.Name, inventoryId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory/{inventoryId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryId"> Inventory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryId"/> is null. </exception>
        public virtual Response<bool> Exists(string inventoryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryId, nameof(inventoryId));

            using var scope = _hybridConnectivityInventoryResourceInventoryClientDiagnostics.CreateScope("HybridConnectivityInventoryResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridConnectivityInventoryResourceInventoryRestClient.Get(Id.Parent, Id.Name, inventoryId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory/{inventoryId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryId"> Inventory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryId"/> is null. </exception>
        public virtual async Task<NullableResponse<HybridConnectivityInventoryResource>> GetIfExistsAsync(string inventoryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryId, nameof(inventoryId));

            using var scope = _hybridConnectivityInventoryResourceInventoryClientDiagnostics.CreateScope("HybridConnectivityInventoryResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hybridConnectivityInventoryResourceInventoryRestClient.GetAsync(Id.Parent, Id.Name, inventoryId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HybridConnectivityInventoryResource>(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivityInventoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/solutionConfigurations/{solutionConfiguration}/inventory/{inventoryId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Inventory_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridConnectivityInventoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryId"> Inventory resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryId"/> is null. </exception>
        public virtual NullableResponse<HybridConnectivityInventoryResource> GetIfExists(string inventoryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryId, nameof(inventoryId));

            using var scope = _hybridConnectivityInventoryResourceInventoryClientDiagnostics.CreateScope("HybridConnectivityInventoryResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hybridConnectivityInventoryResourceInventoryRestClient.Get(Id.Parent, Id.Name, inventoryId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HybridConnectivityInventoryResource>(response.GetRawResponse());
                return Response.FromValue(new HybridConnectivityInventoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridConnectivityInventoryResource> IEnumerable<HybridConnectivityInventoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridConnectivityInventoryResource> IAsyncEnumerable<HybridConnectivityInventoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
