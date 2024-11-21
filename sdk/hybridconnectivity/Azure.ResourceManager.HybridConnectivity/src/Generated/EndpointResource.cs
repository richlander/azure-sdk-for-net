// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    /// <summary>
    /// A Class representing an EndpointResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="EndpointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetEndpointResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetEndpointResource method.
    /// </summary>
    public partial class EndpointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EndpointResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="endpointName"> The endpointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string endpointName)
        {
            var resourceId = $"{scope}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _endpointResourceEndpointsClientDiagnostics;
        private readonly EndpointsRestOperations _endpointResourceEndpointsRestClient;
        private readonly EndpointResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridConnectivity/endpoints";

        /// <summary> Initializes a new instance of the <see cref="EndpointResource"/> class for mocking. </summary>
        protected EndpointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EndpointResource(ArmClient client, EndpointResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EndpointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _endpointResourceEndpointsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridConnectivity", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string endpointResourceEndpointsApiVersion);
            _endpointResourceEndpointsRestClient = new EndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, endpointResourceEndpointsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EndpointResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ServiceConfigurationResources in the EndpointResource. </summary>
        /// <returns> An object representing collection of ServiceConfigurationResources and their operations over a ServiceConfigurationResource. </returns>
        public virtual ServiceConfigurationResourceCollection GetServiceConfigurationResources()
        {
            return GetCachedClient(client => new ServiceConfigurationResourceCollection(client, Id));
        }

        /// <summary>
        /// Gets the details about the service to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceConfigurationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ServiceConfigurationResource>> GetServiceConfigurationResourceAsync(string serviceConfigurationName, CancellationToken cancellationToken = default)
        {
            return await GetServiceConfigurationResources().GetAsync(serviceConfigurationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details about the service to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/serviceConfigurations/{serviceConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServiceConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServiceConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serviceConfigurationName"> The service name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceConfigurationName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<ServiceConfigurationResource> GetServiceConfigurationResource(string serviceConfigurationName, CancellationToken cancellationToken = default)
        {
            return GetServiceConfigurationResources().Get(serviceConfigurationName, cancellationToken);
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EndpointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.Get");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the endpoint to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EndpointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.Get");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the endpoint access to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.Delete");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _endpointResourceEndpointsRestClient.CreateDeleteRequestUri(Id.Parent, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HybridConnectivityArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the endpoint access to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.Delete");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var uri = _endpointResourceEndpointsRestClient.CreateDeleteRequestUri(Id.Parent, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new HybridConnectivityArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the endpoint to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<EndpointResource>> UpdateAsync(EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.Update");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.UpdateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the endpoint to the target resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<EndpointResource> Update(EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.Update");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.Update(Id.Parent, Id.Name, data, cancellationToken);
                return Response.FromValue(new EndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the endpoint access credentials to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_ListCredentials</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Object of type ListCredentialsRequest. </param>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TargetResourceEndpointAccess>> GetCredentialsAsync(ListCredentialsContent content = null, long? expiresin = null, CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.GetCredentials");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.ListCredentialsAsync(Id.Parent, Id.Name, content, expiresin, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the endpoint access credentials to the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_ListCredentials</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Object of type ListCredentialsRequest. </param>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TargetResourceEndpointAccess> GetCredentials(ListCredentialsContent content = null, long? expiresin = null, CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.GetCredentials");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.ListCredentials(Id.Parent, Id.Name, content, expiresin, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ingress gateway endpoint credentials
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_ListIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Object of type ListIngressGatewayCredentialsRequest. </param>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IngressGatewayAsset>> GetIngressGatewayCredentialsAsync(ListIngressGatewayCredentialsContent content = null, long? expiresin = null, CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.GetIngressGatewayCredentials");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.ListIngressGatewayCredentialsAsync(Id.Parent, Id.Name, content, expiresin, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the ingress gateway endpoint credentials
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_ListIngressGatewayCredentials</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Object of type ListIngressGatewayCredentialsRequest. </param>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IngressGatewayAsset> GetIngressGatewayCredentials(ListIngressGatewayCredentialsContent content = null, long? expiresin = null, CancellationToken cancellationToken = default)
        {
            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.GetIngressGatewayCredentials");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.ListIngressGatewayCredentials(Id.Parent, Id.Name, content, expiresin, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetches the managed proxy details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listManagedProxyDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_ListManagedProxyDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Object of type ManagedProxyRequest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ManagedProxyAsset>> GetManagedProxyDetailsAsync(ManagedProxyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.GetManagedProxyDetails");
            scope.Start();
            try
            {
                var response = await _endpointResourceEndpointsRestClient.ListManagedProxyDetailsAsync(Id.Parent, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Fetches the managed proxy details
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.HybridConnectivity/endpoints/{endpointName}/listManagedProxyDetails</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Endpoints_ListManagedProxyDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Object of type ManagedProxyRequest. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ManagedProxyAsset> GetManagedProxyDetails(ManagedProxyContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _endpointResourceEndpointsClientDiagnostics.CreateScope("EndpointResource.GetManagedProxyDetails");
            scope.Start();
            try
            {
                var response = _endpointResourceEndpointsRestClient.ListManagedProxyDetails(Id.Parent, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
