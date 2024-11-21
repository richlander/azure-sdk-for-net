// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> Endpoint details. </summary>
    public partial class HybridConnectivityEndpointProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HybridConnectivityEndpointProperties"/>. </summary>
        /// <param name="endpointType"> The type of endpoint. </param>
        public HybridConnectivityEndpointProperties(EndpointType endpointType)
        {
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="HybridConnectivityEndpointProperties"/>. </summary>
        /// <param name="endpointType"> The type of endpoint. </param>
        /// <param name="resourceId"> The resource Id of the connectivity endpoint (optional). </param>
        /// <param name="provisioningState"> The resource provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridConnectivityEndpointProperties(EndpointType endpointType, ResourceIdentifier resourceId, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndpointType = endpointType;
            ResourceId = resourceId;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HybridConnectivityEndpointProperties"/> for deserialization. </summary>
        internal HybridConnectivityEndpointProperties()
        {
        }

        /// <summary> The type of endpoint. </summary>
        public EndpointType EndpointType { get; set; }
        /// <summary> The resource Id of the connectivity endpoint (optional). </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The resource provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
