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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkManagerRoutingRulesResource"/> and their operations.
    /// Each <see cref="NetworkManagerRoutingRulesResource"/> in the collection will belong to the same instance of <see cref="NetworkManagerRoutingConfigurationResource"/>.
    /// To get a <see cref="NetworkManagerRoutingRulesCollection"/> instance call the GetNetworkManagerRoutingRules method from an instance of <see cref="NetworkManagerRoutingConfigurationResource"/>.
    /// </summary>
    public partial class NetworkManagerRoutingRulesCollection : ArmCollection, IEnumerable<NetworkManagerRoutingRulesResource>, IAsyncEnumerable<NetworkManagerRoutingRulesResource>
    {
        private readonly ClientDiagnostics _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics;
        private readonly RoutingRuleCollectionsRestOperations _networkManagerRoutingRulesRoutingRuleCollectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkManagerRoutingRulesCollection"/> class for mocking. </summary>
        protected NetworkManagerRoutingRulesCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkManagerRoutingRulesCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkManagerRoutingRulesCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkManagerRoutingRulesResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkManagerRoutingRulesResource.ResourceType, out string networkManagerRoutingRulesRoutingRuleCollectionsApiVersion);
            _networkManagerRoutingRulesRoutingRuleCollectionsRestClient = new RoutingRuleCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkManagerRoutingRulesRoutingRuleCollectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkManagerRoutingConfigurationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkManagerRoutingConfigurationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a routing rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="data"> The Rule Collection to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkManagerRoutingRulesResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleCollectionName, NetworkManagerRoutingRulesData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data, cancellationToken).ConfigureAwait(false);
                var uri = _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<NetworkManagerRoutingRulesResource>(Response.FromValue(new NetworkManagerRoutingRulesResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates a routing rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="data"> The Rule Collection to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkManagerRoutingRulesResource> CreateOrUpdate(WaitUntil waitUntil, string ruleCollectionName, NetworkManagerRoutingRulesData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data, cancellationToken);
                var uri = _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<NetworkManagerRoutingRulesResource>(Response.FromValue(new NetworkManagerRoutingRulesResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a network manager routing configuration rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual async Task<Response<NetworkManagerRoutingRulesResource>> GetAsync(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerRoutingRulesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a network manager routing configuration rule collection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual Response<NetworkManagerRoutingRulesResource> Get(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.Get");
            scope.Start();
            try
            {
                var response = _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerRoutingRulesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the rule collections in a routing configuration, in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkManagerRoutingRulesResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkManagerRoutingRulesResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkManagerRoutingRulesResource(Client, NetworkManagerRoutingRulesData.DeserializeNetworkManagerRoutingRulesData(e)), _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics, Pipeline, "NetworkManagerRoutingRulesCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the rule collections in a routing configuration, in a paginated format.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkManagerRoutingRulesResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkManagerRoutingRulesResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkManagerRoutingRulesResource(Client, NetworkManagerRoutingRulesData.DeserializeNetworkManagerRoutingRulesData(e)), _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics, Pipeline, "NetworkManagerRoutingRulesCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetworkManagerRoutingRulesResource>> GetIfExistsAsync(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetworkManagerRoutingRulesResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerRoutingRulesResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRuleCollections_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NetworkManagerRoutingRulesResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleCollectionName"> The name of the network manager routing Configuration rule collection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleCollectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionName"/> is null. </exception>
        public virtual NullableResponse<NetworkManagerRoutingRulesResource> GetIfExists(string ruleCollectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleCollectionName, nameof(ruleCollectionName));

            using var scope = _networkManagerRoutingRulesRoutingRuleCollectionsClientDiagnostics.CreateScope("NetworkManagerRoutingRulesCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkManagerRoutingRulesRoutingRuleCollectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleCollectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetworkManagerRoutingRulesResource>(response.GetRawResponse());
                return Response.FromValue(new NetworkManagerRoutingRulesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkManagerRoutingRulesResource> IEnumerable<NetworkManagerRoutingRulesResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkManagerRoutingRulesResource> IAsyncEnumerable<NetworkManagerRoutingRulesResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
