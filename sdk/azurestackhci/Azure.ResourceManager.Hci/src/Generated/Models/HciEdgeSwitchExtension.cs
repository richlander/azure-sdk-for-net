// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> This represents extensions installed on virtualSwitch. </summary>
    public partial class HciEdgeSwitchExtension
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

        /// <summary> Initializes a new instance of <see cref="HciEdgeSwitchExtension"/>. </summary>
        internal HciEdgeSwitchExtension()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HciEdgeSwitchExtension"/>. </summary>
        /// <param name="switchId"> Unique identifier for virtualSwitch. </param>
        /// <param name="extensionName"> This will show extension name for virtualSwitch. </param>
        /// <param name="isExtensionEnabled"> This represents whether extension is enabled on virtualSwitch. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciEdgeSwitchExtension(string switchId, string extensionName, bool? isExtensionEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SwitchId = switchId;
            ExtensionName = extensionName;
            IsExtensionEnabled = isExtensionEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Unique identifier for virtualSwitch. </summary>
        [WirePath("switchId")]
        public string SwitchId { get; }
        /// <summary> This will show extension name for virtualSwitch. </summary>
        [WirePath("extensionName")]
        public string ExtensionName { get; }
        /// <summary> This represents whether extension is enabled on virtualSwitch. </summary>
        [WirePath("extensionEnabled")]
        public bool? IsExtensionEnabled { get; }
    }
}
