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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a CosmosDBChaosFaultResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CosmosDBChaosFaultResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCosmosDBChaosFaultResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBAccountResource"/> using the GetCosmosDBChaosFaultResource method.
    /// </summary>
    public partial class CosmosDBChaosFaultResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CosmosDBChaosFaultResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="chaosFault"> The chaosFault. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string chaosFault)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics;
        private readonly ChaosFaultRestOperations _cosmosDBChaosFaultResourceChaosFaultRestClient;
        private readonly CosmosDBChaosFaultResourceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/chaosFaults";

        /// <summary> Initializes a new instance of the <see cref="CosmosDBChaosFaultResource"/> class for mocking. </summary>
        protected CosmosDBChaosFaultResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBChaosFaultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CosmosDBChaosFaultResource(ArmClient client, CosmosDBChaosFaultResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBChaosFaultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CosmosDBChaosFaultResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cosmosDBChaosFaultResourceChaosFaultApiVersion);
            _cosmosDBChaosFaultResourceChaosFaultRestClient = new ChaosFaultRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBChaosFaultResourceChaosFaultApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CosmosDBChaosFaultResourceData Data
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

        /// <summary>
        /// Get Chaos Fault for a CosmosdB account for a particular Chaos Fault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CosmosDBChaosFaultResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResource.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBChaosFaultResourceChaosFaultRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBChaosFaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Chaos Fault for a CosmosdB account for a particular Chaos Fault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CosmosDBChaosFaultResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResource.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBChaosFaultResourceChaosFaultRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBChaosFaultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enable, disable Chaos Fault in a CosmosDB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_EnableDisable</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A request object to enable/disable the chaos fault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CosmosDBChaosFaultResource>> UpdateAsync(WaitUntil waitUntil, CosmosDBChaosFaultResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResource.Update");
            scope.Start();
            try
            {
                var response = await _cosmosDBChaosFaultResourceChaosFaultRestClient.EnableDisableAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CosmosDBArmOperation<CosmosDBChaosFaultResource>(new CosmosDBChaosFaultResourceOperationSource(Client), _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics, Pipeline, _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateEnableDisableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Enable, disable Chaos Fault in a CosmosDB account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/chaosFaults/{chaosFault}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChaosFault_EnableDisable</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBChaosFaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A request object to enable/disable the chaos fault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CosmosDBChaosFaultResource> Update(WaitUntil waitUntil, CosmosDBChaosFaultResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics.CreateScope("CosmosDBChaosFaultResource.Update");
            scope.Start();
            try
            {
                var response = _cosmosDBChaosFaultResourceChaosFaultRestClient.EnableDisable(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CosmosDBArmOperation<CosmosDBChaosFaultResource>(new CosmosDBChaosFaultResourceOperationSource(Client), _cosmosDBChaosFaultResourceChaosFaultClientDiagnostics, Pipeline, _cosmosDBChaosFaultResourceChaosFaultRestClient.CreateEnableDisableRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
    }
}
