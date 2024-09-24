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
    /// A class representing a collection of <see cref="ApiManagementGatewayCertificateAuthorityResource"/> and their operations.
    /// Each <see cref="ApiManagementGatewayCertificateAuthorityResource"/> in the collection will belong to the same instance of <see cref="ApiManagementGatewayResource"/>.
    /// To get an <see cref="ApiManagementGatewayCertificateAuthorityCollection"/> instance call the GetApiManagementGatewayCertificateAuthorities method from an instance of <see cref="ApiManagementGatewayResource"/>.
    /// </summary>
    public partial class ApiManagementGatewayCertificateAuthorityCollection : ArmCollection, IEnumerable<ApiManagementGatewayCertificateAuthorityResource>, IAsyncEnumerable<ApiManagementGatewayCertificateAuthorityResource>
    {
        private readonly ClientDiagnostics _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics;
        private readonly GatewayCertificateAuthorityRestOperations _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayCertificateAuthorityCollection"/> class for mocking. </summary>
        protected ApiManagementGatewayCertificateAuthorityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayCertificateAuthorityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementGatewayCertificateAuthorityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementGatewayCertificateAuthorityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementGatewayCertificateAuthorityResource.ResourceType, out string apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityApiVersion);
            _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient = new GatewayCertificateAuthorityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementGatewayResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementGatewayResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Assign Certificate entity to Gateway entity as Certificate Authority.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> The <see cref="ApiManagementGatewayCertificateAuthorityData"/> to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementGatewayCertificateAuthorityResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateId, ApiManagementGatewayCertificateAuthorityData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementGatewayCertificateAuthorityResource>(Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Assign Certificate entity to Gateway entity as Certificate Authority.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> The <see cref="ApiManagementGatewayCertificateAuthorityData"/> to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementGatewayCertificateAuthorityResource> CreateOrUpdate(WaitUntil waitUntil, string certificateId, ApiManagementGatewayCertificateAuthorityData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, data, ifMatch, cancellationToken);
                var uri = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ApiManagementGatewayCertificateAuthorityResource>(Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get assigned Gateway Certificate Authority details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementGatewayCertificateAuthorityResource>> GetAsync(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get assigned Gateway Certificate Authority details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual Response<ApiManagementGatewayCertificateAuthorityResource> Get(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the collection of Certificate Authorities for the specified Gateway entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | eq, ne |  |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementGatewayCertificateAuthorityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementGatewayCertificateAuthorityResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGatewayCertificateAuthorityResource(Client, ApiManagementGatewayCertificateAuthorityData.DeserializeApiManagementGatewayCertificateAuthorityData(e)), _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics, Pipeline, "ApiManagementGatewayCertificateAuthorityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the collection of Certificate Authorities for the specified Gateway entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_ListByService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | eq, ne |  |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementGatewayCertificateAuthorityResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementGatewayCertificateAuthorityResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ApiManagementGatewayCertificateAuthorityResource(Client, ApiManagementGatewayCertificateAuthorityData.DeserializeApiManagementGatewayCertificateAuthorityData(e)), _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics, Pipeline, "ApiManagementGatewayCertificateAuthorityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual async Task<NullableResponse<ApiManagementGatewayCertificateAuthorityResource>> GetIfExistsAsync(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGatewayCertificateAuthorityResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ApiManagementGatewayCertificateAuthorityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateId"> Identifier of the certificate entity. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateId"/> is null. </exception>
        public virtual NullableResponse<ApiManagementGatewayCertificateAuthorityResource> GetIfExists(string certificateId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateId, nameof(certificateId));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, certificateId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ApiManagementGatewayCertificateAuthorityResource>(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementGatewayCertificateAuthorityResource> IEnumerable<ApiManagementGatewayCertificateAuthorityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementGatewayCertificateAuthorityResource> IAsyncEnumerable<ApiManagementGatewayCertificateAuthorityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
