// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkSimGroup data model.
    /// SIM group resource.
    /// Serialized Name: SimGroup
    /// </summary>
    public partial class MobileNetworkSimGroupData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSimGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MobileNetworkSimGroupData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSimGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="userAssignedIdentity">
        /// The identity used to retrieve the encryption key from Azure key vault.
        /// Serialized Name: SimGroup.identity
        /// </param>
        /// <param name="provisioningState">
        /// The provisioning state of the SIM group resource.
        /// Serialized Name: SimGroup.properties.provisioningState
        /// </param>
        /// <param name="encryptionKey">
        /// A key to encrypt the SIM data that belongs to this SIM group.
        /// Serialized Name: SimGroup.properties.encryptionKey
        /// </param>
        /// <param name="mobileNetwork">
        /// Mobile network that this SIM group belongs to. The mobile network must be in the same location as the SIM group.
        /// Serialized Name: SimGroup.properties.mobileNetwork
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkSimGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MobileNetworkManagedServiceIdentity userAssignedIdentity, MobileNetworkProvisioningState? provisioningState, KeyVaultKey encryptionKey, WritableSubResource mobileNetwork, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            UserAssignedIdentity = userAssignedIdentity;
            ProvisioningState = provisioningState;
            EncryptionKey = encryptionKey;
            MobileNetwork = mobileNetwork;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkSimGroupData"/> for deserialization. </summary>
        internal MobileNetworkSimGroupData()
        {
        }

        /// <summary>
        /// The identity used to retrieve the encryption key from Azure key vault.
        /// Serialized Name: SimGroup.identity
        /// </summary>
        [WirePath("identity")]
        public MobileNetworkManagedServiceIdentity UserAssignedIdentity { get; set; }
        /// <summary>
        /// The provisioning state of the SIM group resource.
        /// Serialized Name: SimGroup.properties.provisioningState
        /// </summary>
        [WirePath("properties.provisioningState")]
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// A key to encrypt the SIM data that belongs to this SIM group.
        /// Serialized Name: SimGroup.properties.encryptionKey
        /// </summary>
        internal KeyVaultKey EncryptionKey { get; set; }
        /// <summary>
        /// The key URL, unversioned. For example: https://contosovault.vault.azure.net/keys/azureKey.
        /// Serialized Name: KeyVaultKey.keyUrl
        /// </summary>
        [WirePath("properties.encryptionKey.keyUrl")]
        public Uri KeyUri
        {
            get => EncryptionKey is null ? default : EncryptionKey.KeyUri;
            set
            {
                if (EncryptionKey is null)
                    EncryptionKey = new KeyVaultKey();
                EncryptionKey.KeyUri = value;
            }
        }

        /// <summary>
        /// Mobile network that this SIM group belongs to. The mobile network must be in the same location as the SIM group.
        /// Serialized Name: SimGroup.properties.mobileNetwork
        /// </summary>
        internal WritableSubResource MobileNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("properties.mobileNetwork.id")]
        public ResourceIdentifier MobileNetworkId
        {
            get => MobileNetwork is null ? default : MobileNetwork.Id;
            set
            {
                if (MobileNetwork is null)
                    MobileNetwork = new WritableSubResource();
                MobileNetwork.Id = value;
            }
        }
    }
}
