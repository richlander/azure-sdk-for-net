// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    internal partial class SolutionConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SolutionConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SolutionConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List SolutionConfiguration resources by parent. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<SolutionConfigurationListResult>> ListAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SolutionConfigurationListResult.DeserializeSolutionConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List SolutionConfiguration resources by parent. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<SolutionConfigurationListResult> List(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SolutionConfigurationListResult.DeserializeSolutionConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceUri, string solutionConfiguration)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceUri, string solutionConfiguration)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SolutionConfigurationData>> GetAsync(string resourceUri, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var message = CreateGetRequest(resourceUri, solutionConfiguration);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SolutionConfigurationData.DeserializeSolutionConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SolutionConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SolutionConfigurationData> Get(string resourceUri, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var message = CreateGetRequest(resourceUri, solutionConfiguration);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SolutionConfigurationData.DeserializeSolutionConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SolutionConfigurationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string resourceUri, string solutionConfiguration, SolutionConfigurationData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceUri, string solutionConfiguration, SolutionConfigurationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="solutionConfiguration"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SolutionConfigurationData>> CreateOrUpdateAsync(string resourceUri, string solutionConfiguration, SolutionConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(resourceUri, solutionConfiguration, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SolutionConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SolutionConfigurationData.DeserializeSolutionConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="solutionConfiguration"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SolutionConfigurationData> CreateOrUpdate(string resourceUri, string solutionConfiguration, SolutionConfigurationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(resourceUri, solutionConfiguration, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SolutionConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SolutionConfigurationData.DeserializeSolutionConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string resourceUri, string solutionConfiguration, SolutionConfigurationPatch patch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string resourceUri, string solutionConfiguration, SolutionConfigurationPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="solutionConfiguration"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SolutionConfigurationData>> UpdateAsync(string resourceUri, string solutionConfiguration, SolutionConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(resourceUri, solutionConfiguration, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SolutionConfigurationData.DeserializeSolutionConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="patch"> The resource properties to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/>, <paramref name="solutionConfiguration"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SolutionConfigurationData> Update(string resourceUri, string solutionConfiguration, SolutionConfigurationPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(resourceUri, solutionConfiguration, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SolutionConfigurationData.DeserializeSolutionConfigurationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string resourceUri, string solutionConfiguration)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string resourceUri, string solutionConfiguration)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string resourceUri, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var message = CreateDeleteRequest(resourceUri, solutionConfiguration);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a SolutionConfiguration. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string resourceUri, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var message = CreateDeleteRequest(resourceUri, solutionConfiguration);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateSyncNowRequestUri(string resourceUri, string solutionConfiguration)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendPath("/syncNow", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateSyncNowRequest(string resourceUri, string solutionConfiguration)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/solutionConfigurations/", false);
            uri.AppendPath(solutionConfiguration, true);
            uri.AppendPath("/syncNow", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Trigger immediate sync with source cloud. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> SyncNowAsync(string resourceUri, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var message = CreateSyncNowRequest(resourceUri, solutionConfiguration);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Trigger immediate sync with source cloud. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="solutionConfiguration"> Represent Solution Configuration Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="solutionConfiguration"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="solutionConfiguration"/> is an empty string, and was expected to be non-empty. </exception>
        public Response SyncNow(string resourceUri, string solutionConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNullOrEmpty(solutionConfiguration, nameof(solutionConfiguration));

            using var message = CreateSyncNowRequest(resourceUri, solutionConfiguration);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List SolutionConfiguration resources by parent. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<SolutionConfigurationListResult>> ListNextPageAsync(string nextLink, string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListNextPageRequest(nextLink, resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SolutionConfigurationListResult.DeserializeSolutionConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List SolutionConfiguration resources by parent. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public Response<SolutionConfigurationListResult> ListNextPage(string nextLink, string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListNextPageRequest(nextLink, resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SolutionConfigurationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SolutionConfigurationListResult.DeserializeSolutionConfigurationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
