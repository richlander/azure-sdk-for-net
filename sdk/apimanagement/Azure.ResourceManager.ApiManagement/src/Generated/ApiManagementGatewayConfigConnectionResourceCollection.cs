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

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementGatewayConfigConnectionResource"/> and their operations.
    /// Each <see cref="ApiManagementGatewayConfigConnectionResource"/> in the collection will belong to the same instance of <see cref="GatewayResource"/>.
    /// To get an <see cref="ApiManagementGatewayConfigConnectionResourceCollection"/> instance call the GetApiManagementGatewayConfigConnectionResources method from an instance of <see cref="GatewayResource"/>.
    /// </summary>
    public partial class ApiManagementGatewayConfigConnectionResourceCollection : ArmCollection, IEnumerable<ApiManagementGatewayConfigConnectionResource>, IAsyncEnumerable<ApiManagementGatewayConfigConnectionResource>
    {
        private readonly ClientDiagnostics _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics;
        private readonly ApiGatewayConfigConnectionRestOperations _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayConfigConnectionResourceCollection"/> class for mocking. </summary>
        protected ApiManagementGatewayConfigConnectionResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayConfigConnectionResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementGatewayConfigConnectionResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementGatewayConfigConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementGatewayConfigConnectionResource.ResourceType, out string apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionApiVersion);
            _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient = new ApiGatewayConfigConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an API Management gateway config connection. This is long running operation and could take several minutes to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate API Management gateway config connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementGatewayConfigConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configConnectionName, ApiManagementGatewayConfigConnectionResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementGatewayConfigConnectionResource>(new ApiManagementGatewayConfigConnectionResourceOperationSource(Client), _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics, Pipeline, _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an API Management gateway config connection. This is long running operation and could take several minutes to complete.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="data"> Parameters supplied to the CreateOrUpdate API Management gateway config connection operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementGatewayConfigConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string configConnectionName, ApiManagementGatewayConfigConnectionResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, data, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementGatewayConfigConnectionResource>(new ApiManagementGatewayConfigConnectionResourceOperationSource(Client), _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics, Pipeline, _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an API Management gateway config connection resource description.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> is null. </exception>
        public virtual async Task<Response<ApiManagementGatewayConfigConnectionResource>> GetAsync(string configConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayConfigConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an API Management gateway config connection resource description.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> is null. </exception>
        public virtual Response<ApiManagementGatewayConfigConnectionResource> Get(string configConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayConfigConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all API Management gateway config connections within a gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_ListByGateway</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementGatewayConfigConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementGatewayConfigConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateListByGatewayRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateListByGatewayNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGatewayConfigConnectionResource(Client, ApiManagementGatewayConfigConnectionResourceData.DeserializeApiManagementGatewayConfigConnectionResourceData(e)), _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics, Pipeline, "ApiManagementGatewayConfigConnectionResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all API Management gateway config connections within a gateway.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_ListByGateway</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementGatewayConfigConnectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementGatewayConfigConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateListByGatewayRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.CreateListByGatewayNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGatewayConfigConnectionResource(Client, ApiManagementGatewayConfigConnectionResourceData.DeserializeApiManagementGatewayConfigConnectionResourceData(e)), _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics, Pipeline, "ApiManagementGatewayConfigConnectionResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string configConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementGatewayConfigConnectionResource>> GetIfExistsAsync(string configConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGatewayConfigConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayConfigConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/gateways/{gatewayName}/configConnections/{configConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApiGatewayConfigConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayConfigConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configConnectionName"> The name of the API Management gateway config connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configConnectionName"/> is null. </exception>
        public virtual NullableResponse<ApiManagementGatewayConfigConnectionResource> GetIfExists(string configConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configConnectionName, nameof(configConnectionName));

            using var scope = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionClientDiagnostics.CreateScope("ApiManagementGatewayConfigConnectionResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayConfigConnectionResourceApiGatewayConfigConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGatewayConfigConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayConfigConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementGatewayConfigConnectionResource> IEnumerable<ApiManagementGatewayConfigConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementGatewayConfigConnectionResource> IAsyncEnumerable<ApiManagementGatewayConfigConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
