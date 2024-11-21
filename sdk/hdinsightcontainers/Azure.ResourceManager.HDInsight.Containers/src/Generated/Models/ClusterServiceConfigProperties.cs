// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Service config response. </summary>
    public partial class ClusterServiceConfigProperties
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

        /// <summary> Initializes a new instance of <see cref="ClusterServiceConfigProperties"/>. </summary>
        /// <param name="serviceName"> Service Config Name. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="componentName"> Component Name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceName"/>, <paramref name="fileName"/> or <paramref name="componentName"/> is null. </exception>
        internal ClusterServiceConfigProperties(string serviceName, string fileName, string componentName)
        {
            Argument.AssertNotNull(serviceName, nameof(serviceName));
            Argument.AssertNotNull(fileName, nameof(fileName));
            Argument.AssertNotNull(componentName, nameof(componentName));

            ServiceName = serviceName;
            FileName = fileName;
            ComponentName = componentName;
            CustomKeys = new ChangeTrackingDictionary<string, string>();
            DefaultKeys = new ChangeTrackingDictionary<string, ClusterServiceConfigValueEntity>();
        }

        /// <summary> Initializes a new instance of <see cref="ClusterServiceConfigProperties"/>. </summary>
        /// <param name="serviceName"> Service Config Name. </param>
        /// <param name="fileName"> File Name. </param>
        /// <param name="content"> Content in the service config file. </param>
        /// <param name="componentName"> Component Name. </param>
        /// <param name="serviceConfigListResultPropertiesType"> Config type. </param>
        /// <param name="path"> Config file path. </param>
        /// <param name="customKeys"> The custom keys. </param>
        /// <param name="defaultKeys"> The default keys. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterServiceConfigProperties(string serviceName, string fileName, string content, string componentName, string serviceConfigListResultPropertiesType, string path, IReadOnlyDictionary<string, string> customKeys, IReadOnlyDictionary<string, ClusterServiceConfigValueEntity> defaultKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceName = serviceName;
            FileName = fileName;
            Content = content;
            ComponentName = componentName;
            ServiceConfigListResultPropertiesType = serviceConfigListResultPropertiesType;
            Path = path;
            CustomKeys = customKeys;
            DefaultKeys = defaultKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterServiceConfigProperties"/> for deserialization. </summary>
        internal ClusterServiceConfigProperties()
        {
        }

        /// <summary> Service Config Name. </summary>
        [WirePath("serviceName")]
        public string ServiceName { get; }
        /// <summary> File Name. </summary>
        [WirePath("fileName")]
        public string FileName { get; }
        /// <summary> Content in the service config file. </summary>
        [WirePath("content")]
        public string Content { get; }
        /// <summary> Component Name. </summary>
        [WirePath("componentName")]
        public string ComponentName { get; }
        /// <summary> Config type. </summary>
        [WirePath("type")]
        public string ServiceConfigListResultPropertiesType { get; }
        /// <summary> Config file path. </summary>
        [WirePath("path")]
        public string Path { get; }
        /// <summary> The custom keys. </summary>
        [WirePath("customKeys")]
        public IReadOnlyDictionary<string, string> CustomKeys { get; }
        /// <summary> The default keys. </summary>
        [WirePath("defaultKeys")]
        public IReadOnlyDictionary<string, ClusterServiceConfigValueEntity> DefaultKeys { get; }
    }
}
