// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> cloud profile for AWS. </summary>
    public partial class AwsCloudProfile
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

        /// <summary> Initializes a new instance of <see cref="AwsCloudProfile"/>. </summary>
        /// <param name="accountId"> Account id for the AWS account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountId"/> is null. </exception>
        public AwsCloudProfile(string accountId)
        {
            Argument.AssertNotNull(accountId, nameof(accountId));

            AccountId = accountId;
            ExcludedAccounts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AwsCloudProfile"/>. </summary>
        /// <param name="accountId"> Account id for the AWS account. </param>
        /// <param name="excludedAccounts"> List of AWS accounts which need to be excluded. </param>
        /// <param name="isOrganizationalAccount"> Boolean value that indicates whether the account is organizational or not. True represents organization account, whereas false represents a single account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AwsCloudProfile(string accountId, IList<string> excludedAccounts, bool? isOrganizationalAccount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountId = accountId;
            ExcludedAccounts = excludedAccounts;
            IsOrganizationalAccount = isOrganizationalAccount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AwsCloudProfile"/> for deserialization. </summary>
        internal AwsCloudProfile()
        {
        }

        /// <summary> Account id for the AWS account. </summary>
        public string AccountId { get; set; }
        /// <summary> List of AWS accounts which need to be excluded. </summary>
        public IList<string> ExcludedAccounts { get; }
        /// <summary> Boolean value that indicates whether the account is organizational or not. True represents organization account, whereas false represents a single account. </summary>
        public bool? IsOrganizationalAccount { get; set; }
    }
}
