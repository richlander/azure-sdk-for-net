// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Subscription Quota details. </summary>
    public partial class SubscriptionQuotaDetails
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

        /// <summary> Initializes a new instance of <see cref="SubscriptionQuotaDetails"/>. </summary>
        public SubscriptionQuotaDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionQuotaDetails"/>. </summary>
        /// <param name="region"> Location/Azure region for the quota requested for resource. </param>
        /// <param name="limit"> The total quota limit for the subscription. </param>
        /// <param name="shareableQuota"> The shareable quota for the subscription. </param>
        /// <param name="value"> Resource name. </param>
        /// <param name="localizedValue"> Resource display name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionQuotaDetails(string region, long? limit, long? shareableQuota, string value, string localizedValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Region = region;
            Limit = limit;
            ShareableQuota = shareableQuota;
            Value = value;
            LocalizedValue = localizedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Location/Azure region for the quota requested for resource. </summary>
        [WirePath("region")]
        public string Region { get; set; }
        /// <summary> The total quota limit for the subscription. </summary>
        [WirePath("limit")]
        public long? Limit { get; set; }
        /// <summary> The shareable quota for the subscription. </summary>
        [WirePath("shareableQuota")]
        public long? ShareableQuota { get; }
        /// <summary> Resource name. </summary>
        [WirePath("name.value")]
        public string Value { get; }
        /// <summary> Resource display name. </summary>
        [WirePath("name.localizedValue")]
        public string LocalizedValue { get; }
    }
}
