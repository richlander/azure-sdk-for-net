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
    /// A class representing a collection of <see cref="ServiceWorkspaceTagApiLinkResource"/> and their operations.
    /// Each <see cref="ServiceWorkspaceTagApiLinkResource"/> in the collection will belong to the same instance of <see cref="ServiceWorkspaceTagResource"/>.
    /// To get a <see cref="ServiceWorkspaceTagApiLinkCollection"/> instance call the GetServiceWorkspaceTagApiLinks method from an instance of <see cref="ServiceWorkspaceTagResource"/>.
    /// </summary>
    public partial class ServiceWorkspaceTagApiLinkCollection : ArmCollection, IEnumerable<ServiceWorkspaceTagApiLinkResource>, IAsyncEnumerable<ServiceWorkspaceTagApiLinkResource>
    {
        private readonly ClientDiagnostics _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics;
        private readonly WorkspaceTagApiLinkRestOperations _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceTagApiLinkCollection"/> class for mocking. </summary>
        protected ServiceWorkspaceTagApiLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceWorkspaceTagApiLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceWorkspaceTagApiLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ServiceWorkspaceTagApiLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceWorkspaceTagApiLinkResource.ResourceType, out string serviceWorkspaceTagApiLinkWorkspaceTagApiLinkApiVersion);
            _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient = new WorkspaceTagApiLinkRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceWorkspaceTagApiLinkWorkspaceTagApiLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceWorkspaceTagResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceWorkspaceTagResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds an API to the specified tag via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceWorkspaceTagApiLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string apiLinkId, TagApiLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, data, cancellationToken).ConfigureAwait(false);
                var uri = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceTagApiLinkResource>(Response.FromValue(new ServiceWorkspaceTagApiLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Adds an API to the specified tag via link.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceWorkspaceTagApiLinkResource> CreateOrUpdate(WaitUntil waitUntil, string apiLinkId, TagApiLinkContractData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, data, cancellationToken);
                var uri = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ApiManagementArmOperation<ServiceWorkspaceTagApiLinkResource>(Response.FromValue(new ServiceWorkspaceTagApiLinkResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets the API link for the tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        public virtual async Task<Response<ServiceWorkspaceTagApiLinkResource>> GetAsync(string apiLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceTagApiLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the API link for the tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        public virtual Response<ServiceWorkspaceTagApiLinkResource> Get(string apiLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceTagApiLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of the API links associated with a tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| apiId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceWorkspaceTagApiLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceWorkspaceTagApiLinkResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceTagApiLinkResource(Client, TagApiLinkContractData.DeserializeTagApiLinkContractData(e)), _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics, Pipeline, "ServiceWorkspaceTagApiLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of the API links associated with a tag.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_ListByProduct</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| apiId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceWorkspaceTagApiLinkResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceWorkspaceTagApiLinkResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateListByProductRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.CreateListByProductNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, filter, top, skip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServiceWorkspaceTagApiLinkResource(Client, TagApiLinkContractData.DeserializeTagApiLinkContractData(e)), _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics, Pipeline, "ServiceWorkspaceTagApiLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string apiLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        public virtual Response<bool> Exists(string apiLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        public virtual async Task<NullableResponse<ServiceWorkspaceTagApiLinkResource>> GetIfExistsAsync(string apiLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceTagApiLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceTagApiLinkResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/workspaces/{workspaceId}/tags/{tagId}/apiLinks/{apiLinkId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkspaceTagApiLink_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceWorkspaceTagApiLinkResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apiLinkId"> Tag-API link identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="apiLinkId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="apiLinkId"/> is null. </exception>
        public virtual NullableResponse<ServiceWorkspaceTagApiLinkResource> GetIfExists(string apiLinkId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(apiLinkId, nameof(apiLinkId));

            using var scope = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkClientDiagnostics.CreateScope("ServiceWorkspaceTagApiLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceWorkspaceTagApiLinkWorkspaceTagApiLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, apiLinkId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServiceWorkspaceTagApiLinkResource>(response.GetRawResponse());
                return Response.FromValue(new ServiceWorkspaceTagApiLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceWorkspaceTagApiLinkResource> IEnumerable<ServiceWorkspaceTagApiLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceWorkspaceTagApiLinkResource> IAsyncEnumerable<ServiceWorkspaceTagApiLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
