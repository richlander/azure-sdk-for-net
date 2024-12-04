// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Check SKU availability parameter. </summary>
    public partial class CognitiveServicesSkuAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesSkuAvailabilityContent"/>. </summary>
        /// <param name="skus"> The SKU of the resource. </param>
        /// <param name="kind"> The kind (type) of cognitive service account. </param>
        /// <param name="resourceType"> The Type of the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="skus"/> or <paramref name="kind"/> is null. </exception>
        public CognitiveServicesSkuAvailabilityContent(IEnumerable<string> skus, string kind, ResourceType resourceType)
        {
            Argument.AssertNotNull(skus, nameof(skus));
            Argument.AssertNotNull(kind, nameof(kind));

            Skus = skus.ToList();
            Kind = kind;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesSkuAvailabilityContent"/>. </summary>
        /// <param name="skus"> The SKU of the resource. </param>
        /// <param name="kind"> The kind (type) of cognitive service account. </param>
        /// <param name="resourceType"> The Type of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesSkuAvailabilityContent(IList<string> skus, string kind, ResourceType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Skus = skus;
            Kind = kind;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesSkuAvailabilityContent"/> for deserialization. </summary>
        internal CognitiveServicesSkuAvailabilityContent()
        {
        }

        /// <summary> The SKU of the resource. </summary>
        [WirePath("skus")]
        public IList<string> Skus { get; }
        /// <summary> The kind (type) of cognitive service account. </summary>
        [WirePath("kind")]
        public string Kind { get; }
        /// <summary> The Type of the resource. </summary>
        [WirePath("type")]
        public ResourceType ResourceType { get; }
    }
}
