// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Paypal Service linked service. </summary>
    public partial class PaypalLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="PaypalLinkedService"/>. </summary>
        /// <param name="host"> The URL of the PayPal instance. (i.e. api.sandbox.paypal.com). </param>
        /// <param name="clientId"> The client ID associated with your PayPal application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> or <paramref name="clientId"/> is null. </exception>
        public PaypalLinkedService(DataFactoryElement<string> host, DataFactoryElement<string> clientId)
        {
            Argument.AssertNotNull(host, nameof(host));
            Argument.AssertNotNull(clientId, nameof(clientId));

            Host = host;
            ClientId = clientId;
            LinkedServiceType = "Paypal";
        }

        /// <summary> Initializes a new instance of <see cref="PaypalLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The URL of the PayPal instance. (i.e. api.sandbox.paypal.com). </param>
        /// <param name="clientId"> The client ID associated with your PayPal application. </param>
        /// <param name="clientSecret"> The client secret associated with your PayPal application. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal PaypalLinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> host, DataFactoryElement<string> clientId, DataFactorySecret clientSecret, DataFactoryElement<bool> useEncryptedEndpoints, DataFactoryElement<bool> useHostVerification, DataFactoryElement<bool> usePeerVerification, string encryptedCredential) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Paypal";
        }

        /// <summary> Initializes a new instance of <see cref="PaypalLinkedService"/> for deserialization. </summary>
        internal PaypalLinkedService()
        {
        }

        /// <summary> The URL of the PayPal instance. (i.e. api.sandbox.paypal.com). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The client ID associated with your PayPal application. </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> The client secret associated with your PayPal application. </summary>
        public DataFactorySecret ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
