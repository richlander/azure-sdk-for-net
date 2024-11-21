// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Persistence-related configuration for the Redis Enterprise database. </summary>
    public partial class RedisPersistenceSettings
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

        /// <summary> Initializes a new instance of <see cref="RedisPersistenceSettings"/>. </summary>
        public RedisPersistenceSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisPersistenceSettings"/>. </summary>
        /// <param name="isAofEnabled"> Sets whether AOF is enabled. Note that at most one of AOF or RDB persistence may be enabled. </param>
        /// <param name="isRdbEnabled"> Sets whether RDB is enabled. Note that at most one of AOF or RDB persistence may be enabled. </param>
        /// <param name="aofFrequency"> Sets the frequency at which data is written to disk. Defaults to '1s', meaning 'every second'. Note that the 'always' setting is deprecated, because of its performance impact. </param>
        /// <param name="rdbFrequency"> Sets the frequency at which a snapshot of the database is created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisPersistenceSettings(bool? isAofEnabled, bool? isRdbEnabled, PersistenceSettingAofFrequency? aofFrequency, PersistenceSettingRdbFrequency? rdbFrequency, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsAofEnabled = isAofEnabled;
            IsRdbEnabled = isRdbEnabled;
            AofFrequency = aofFrequency;
            RdbFrequency = rdbFrequency;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sets whether AOF is enabled. Note that at most one of AOF or RDB persistence may be enabled. </summary>
        [WirePath("aofEnabled")]
        public bool? IsAofEnabled { get; set; }
        /// <summary> Sets whether RDB is enabled. Note that at most one of AOF or RDB persistence may be enabled. </summary>
        [WirePath("rdbEnabled")]
        public bool? IsRdbEnabled { get; set; }
        /// <summary> Sets the frequency at which data is written to disk. Defaults to '1s', meaning 'every second'. Note that the 'always' setting is deprecated, because of its performance impact. </summary>
        [WirePath("aofFrequency")]
        public PersistenceSettingAofFrequency? AofFrequency { get; set; }
        /// <summary> Sets the frequency at which a snapshot of the database is created. </summary>
        [WirePath("rdbFrequency")]
        public PersistenceSettingRdbFrequency? RdbFrequency { get; set; }
    }
}
