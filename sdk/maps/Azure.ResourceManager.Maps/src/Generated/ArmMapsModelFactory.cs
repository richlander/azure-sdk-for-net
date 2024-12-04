// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMapsModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Maps.MapsAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU of this account. </param>
        /// <param name="kind"> Get or Set Kind property. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="properties"> The map account properties. </param>
        /// <returns> A new <see cref="Maps.MapsAccountData"/> instance for mocking. </returns>
        public static MapsAccountData MapsAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MapsSku sku = null, MapsAccountKind? kind = null, ManagedServiceIdentity identity = null, MapsAccountProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MapsAccountData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                sku,
                kind,
                identity,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsSku"/>. </summary>
        /// <param name="name"> The name of the SKU, in standard format (such as S0). </param>
        /// <param name="tier"> Gets the sku tier. This is based on the SKU name. </param>
        /// <returns> A new <see cref="Models.MapsSku"/> instance for mocking. </returns>
        public static MapsSku MapsSku(MapsSkuName name = default, string tier = null)
        {
            return new MapsSku(name, tier, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsAccountProperties"/>. </summary>
        /// <param name="uniqueId"> A unique identifier for the maps account. </param>
        /// <param name="disableLocalAuth"> Allows toggle functionality on Azure Policy to disable Azure Maps local authentication support. This will disable Shared Keys and Shared Access Signature Token authentication from any usage. </param>
        /// <param name="provisioningState"> The provisioning state of the Map account resource, Account updates can only be performed on terminal states. Terminal states: `Succeeded` and `Failed`. </param>
        /// <param name="linkedResources"> The array of associated resources to the Map account. Linked resource in the array cannot individually update, you must update all linked resources in the array together. These resources may be used on operations on the Azure Maps REST API. Access is controlled by the Map Account Managed Identity(s) permissions to those resource(s). </param>
        /// <param name="corsRulesValue"> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </param>
        /// <param name="encryption"> (Optional) Discouraged to include in resource definition. Only needed where it is possible to disable platform (AKA infrastructure) encryption. Azure SQL TDE is an example of this. Values are enabled and disabled. </param>
        /// <returns> A new <see cref="Models.MapsAccountProperties"/> instance for mocking. </returns>
        public static MapsAccountProperties MapsAccountProperties(Guid? uniqueId = null, bool? disableLocalAuth = null, string provisioningState = null, IEnumerable<MapsLinkedResource> linkedResources = null, IEnumerable<MapsCorsRule> corsRulesValue = null, MapsEncryption encryption = null)
        {
            linkedResources ??= new List<MapsLinkedResource>();
            corsRulesValue ??= new List<MapsCorsRule>();

            return new MapsAccountProperties(
                uniqueId,
                disableLocalAuth,
                provisioningState,
                linkedResources?.ToList(),
                corsRulesValue != null ? new CorsRules(corsRulesValue?.ToList(), serializedAdditionalRawData: null) : null,
                encryption,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsAccountPatch"/>. </summary>
        /// <param name="tags"> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. </param>
        /// <param name="kind"> Get or Set Kind property. </param>
        /// <param name="sku"> The SKU of this account. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="uniqueId"> A unique identifier for the maps account. </param>
        /// <param name="disableLocalAuth"> Allows toggle functionality on Azure Policy to disable Azure Maps local authentication support. This will disable Shared Keys and Shared Access Signature Token authentication from any usage. </param>
        /// <param name="provisioningState"> The provisioning state of the Map account resource, Account updates can only be performed on terminal states. Terminal states: `Succeeded` and `Failed`. </param>
        /// <param name="linkedResources"> The array of associated resources to the Map account. Linked resource in the array cannot individually update, you must update all linked resources in the array together. These resources may be used on operations on the Azure Maps REST API. Access is controlled by the Map Account Managed Identity(s) permissions to those resource(s). </param>
        /// <param name="corsRulesValue"> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </param>
        /// <param name="encryption"> (Optional) Discouraged to include in resource definition. Only needed where it is possible to disable platform (AKA infrastructure) encryption. Azure SQL TDE is an example of this. Values are enabled and disabled. </param>
        /// <returns> A new <see cref="Models.MapsAccountPatch"/> instance for mocking. </returns>
        public static MapsAccountPatch MapsAccountPatch(IDictionary<string, string> tags = null, MapsAccountKind? kind = null, MapsSku sku = null, ManagedServiceIdentity identity = null, Guid? uniqueId = null, bool? disableLocalAuth = null, string provisioningState = null, IEnumerable<MapsLinkedResource> linkedResources = null, IEnumerable<MapsCorsRule> corsRulesValue = null, MapsEncryption encryption = null)
        {
            tags ??= new Dictionary<string, string>();
            linkedResources ??= new List<MapsLinkedResource>();
            corsRulesValue ??= new List<MapsCorsRule>();

            return new MapsAccountPatch(
                tags,
                kind,
                sku,
                identity,
                uniqueId,
                disableLocalAuth,
                provisioningState,
                linkedResources?.ToList(),
                corsRulesValue != null ? new CorsRules(corsRulesValue?.ToList(), serializedAdditionalRawData: null) : null,
                encryption,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsAccountSasContent"/>. </summary>
        /// <param name="signingKey"> The Map account key to use for signing. Picking `primaryKey` or `secondaryKey` will use the Map account Shared Keys, and using `managedIdentity` will use the auto-renewed private key to sign the SAS. </param>
        /// <param name="principalId"> The principal Id also known as the object Id of a User Assigned Managed Identity currently assigned to the Map Account. To assign a Managed Identity of the account, use operation Create or Update an assign a User Assigned Identity resource Id. </param>
        /// <param name="regions"> Optional, allows control of which region locations are permitted access to Azure Maps REST APIs with the SAS token. Example: "eastus", "westus2". Omitting this parameter will allow all region locations to be accessible. </param>
        /// <param name="maxRatePerSecond"> Required parameter which represents the desired maximum request per second to allowed for the given SAS token. This does not guarantee perfect accuracy in measurements but provides application safe guards of abuse with eventual enforcement. </param>
        /// <param name="start"> The date time offset of when the token validity begins. For example "2017-05-24T10:42:03.1567373Z". Maximum duration allowed is 24 hours between `start` and `expiry`. </param>
        /// <param name="expiry"> The date time offset of when the token validity expires. For example "2017-05-24T10:42:03.1567373Z". Maximum duration allowed is 24 hours between `start` and `expiry`. </param>
        /// <returns> A new <see cref="Models.MapsAccountSasContent"/> instance for mocking. </returns>
        public static MapsAccountSasContent MapsAccountSasContent(MapsSigningKey signingKey = default, string principalId = null, IEnumerable<string> regions = null, int maxRatePerSecond = default, string start = null, string expiry = null)
        {
            regions ??= new List<string>();

            return new MapsAccountSasContent(
                signingKey,
                principalId,
                regions?.ToList(),
                maxRatePerSecond,
                start,
                expiry,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsAccountSasToken"/>. </summary>
        /// <param name="accountSasToken"> The shared access signature access token. </param>
        /// <returns> A new <see cref="Models.MapsAccountSasToken"/> instance for mocking. </returns>
        public static MapsAccountSasToken MapsAccountSasToken(string accountSasToken = null)
        {
            return new MapsAccountSasToken(accountSasToken, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsAccountKeys"/>. </summary>
        /// <param name="primaryKeyLastUpdatedOn"> The last updated date and time of the primary key. </param>
        /// <param name="primaryKey"> The primary key for accessing the Maps REST APIs. </param>
        /// <param name="secondaryKey"> The secondary key for accessing the Maps REST APIs. </param>
        /// <param name="secondaryKeyLastUpdatedOn"> The last updated date and time of the secondary key. </param>
        /// <returns> A new <see cref="Models.MapsAccountKeys"/> instance for mocking. </returns>
        public static MapsAccountKeys MapsAccountKeys(DateTimeOffset? primaryKeyLastUpdatedOn = null, string primaryKey = null, string secondaryKey = null, DateTimeOffset? secondaryKeyLastUpdatedOn = null)
        {
            return new MapsAccountKeys(primaryKeyLastUpdatedOn, primaryKey, secondaryKey, secondaryKeyLastUpdatedOn, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Maps.MapsCreatorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The Creator resource properties. </param>
        /// <returns> A new <see cref="Maps.MapsCreatorData"/> instance for mocking. </returns>
        public static MapsCreatorData MapsCreatorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, MapsCreatorProperties properties = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MapsCreatorData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsCreatorProperties"/>. </summary>
        /// <param name="provisioningState"> The state of the resource provisioning, terminal states: Succeeded, Failed, Canceled. </param>
        /// <param name="storageUnits"> The storage units to be allocated. Integer values from 1 to 100, inclusive. </param>
        /// <returns> A new <see cref="Models.MapsCreatorProperties"/> instance for mocking. </returns>
        public static MapsCreatorProperties MapsCreatorProperties(string provisioningState = null, int storageUnits = default)
        {
            return new MapsCreatorProperties(provisioningState, storageUnits, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MapsCreatorPatch"/>. </summary>
        /// <param name="tags"> Gets or sets a list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. </param>
        /// <param name="provisioningState"> The state of the resource provisioning, terminal states: Succeeded, Failed, Canceled. </param>
        /// <param name="storageUnits"> The storage units to be allocated. Integer values from 1 to 100, inclusive. </param>
        /// <returns> A new <see cref="Models.MapsCreatorPatch"/> instance for mocking. </returns>
        public static MapsCreatorPatch MapsCreatorPatch(IDictionary<string, string> tags = null, string provisioningState = null, int? storageUnits = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MapsCreatorPatch(tags, provisioningState, storageUnits, serializedAdditionalRawData: null);
        }
    }
}
