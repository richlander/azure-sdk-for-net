// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Batch.Service.Models
{
    /// <summary> An inbound endpoint on a Compute Node. </summary>
    public partial class InboundEndpoint
    {
        /// <summary> Initializes a new instance of InboundEndpoint. </summary>
        /// <param name="name"> The name of the endpoint. </param>
        /// <param name="protocol"> The protocol of the endpoint. </param>
        /// <param name="publicIPAddress"> The public IP address of the Compute Node. </param>
        /// <param name="publicFqdn"> The public fully qualified domain name for the Compute Node. </param>
        /// <param name="frontendPort"> The public port number of the endpoint. </param>
        /// <param name="backendPort"> The backend port number of the endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="publicIPAddress"/> or <paramref name="publicFqdn"/> is null. </exception>
        internal InboundEndpoint(string name, InboundEndpointProtocol protocol, string publicIPAddress, string publicFqdn, int frontendPort, int backendPort)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (publicIPAddress == null)
            {
                throw new ArgumentNullException(nameof(publicIPAddress));
            }
            if (publicFqdn == null)
            {
                throw new ArgumentNullException(nameof(publicFqdn));
            }

            Name = name;
            Protocol = protocol;
            PublicIPAddress = publicIPAddress;
            PublicFqdn = publicFqdn;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
        }

        /// <summary> The name of the endpoint. </summary>
        public string Name { get; }
        /// <summary> The protocol of the endpoint. </summary>
        public InboundEndpointProtocol Protocol { get; }
        /// <summary> The public IP address of the Compute Node. </summary>
        public string PublicIPAddress { get; }
        /// <summary> The public fully qualified domain name for the Compute Node. </summary>
        public string PublicFqdn { get; }
        /// <summary> The public port number of the endpoint. </summary>
        public int FrontendPort { get; }
        /// <summary> The backend port number of the endpoint. </summary>
        public int BackendPort { get; }
    }
}
