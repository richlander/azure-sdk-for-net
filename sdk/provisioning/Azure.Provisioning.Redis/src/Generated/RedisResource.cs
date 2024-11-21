// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;
using System.Net;

namespace Azure.Provisioning.Redis;

/// <summary>
/// RedisResource.
/// </summary>
public partial class RedisResource : ProvisionableResource
{
    /// <summary>
    /// The name of the Redis cache.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// The SKU of the Redis cache to deploy.
    /// </summary>
    public RedisSku Sku 
    {
        get { Initialize(); return _sku!; }
        set { Initialize(); AssignOrReplace(ref _sku, value); }
    }
    private RedisSku? _sku;

    /// <summary>
    /// Specifies whether the non-ssl Redis server port (6379) is enabled.
    /// </summary>
    public BicepValue<bool> EnableNonSslPort 
    {
        get { Initialize(); return _enableNonSslPort!; }
        set { Initialize(); _enableNonSslPort!.Assign(value); }
    }
    private BicepValue<bool>? _enableNonSslPort;

    /// <summary>
    /// The identity of the resource.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// Authentication to Redis through access keys is disabled when set as
    /// true. Default value is false.
    /// </summary>
    public BicepValue<bool> IsAccessKeyAuthenticationDisabled 
    {
        get { Initialize(); return _isAccessKeyAuthenticationDisabled!; }
        set { Initialize(); _isAccessKeyAuthenticationDisabled!.Assign(value); }
    }
    private BicepValue<bool>? _isAccessKeyAuthenticationDisabled;

    /// <summary>
    /// Optional: requires clients to use a specified TLS version (or higher)
    /// to connect (e,g, &apos;1.0&apos;, &apos;1.1&apos;, &apos;1.2&apos;).
    /// </summary>
    public BicepValue<RedisTlsVersion> MinimumTlsVersion 
    {
        get { Initialize(); return _minimumTlsVersion!; }
        set { Initialize(); _minimumTlsVersion!.Assign(value); }
    }
    private BicepValue<RedisTlsVersion>? _minimumTlsVersion;

    /// <summary>
    /// Whether or not public endpoint access is allowed for this cache.  Value
    /// is optional but if passed in, must be &apos;Enabled&apos; or
    /// &apos;Disabled&apos;. If &apos;Disabled&apos;, private endpoints are
    /// the exclusive access method. Default value is &apos;Enabled&apos;.
    /// </summary>
    public BicepValue<RedisPublicNetworkAccess> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<RedisPublicNetworkAccess>? _publicNetworkAccess;

    /// <summary>
    /// All Redis Settings. Few possible keys:
    /// rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,
    /// maxmemory-policy,notify-keyspace-events, aof-backup-enabled,
    /// aof-storage-connection-string-0, aof-storage-connection-string-1 etc.
    /// </summary>
    public RedisCommonConfiguration RedisConfiguration 
    {
        get { Initialize(); return _redisConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _redisConfiguration, value); }
    }
    private RedisCommonConfiguration? _redisConfiguration;

    /// <summary>
    /// Redis version. This should be in the form &apos;major[.minor]&apos;
    /// (only &apos;major&apos; is required) or the value &apos;latest&apos;
    /// which refers to the latest stable Redis version that is available.
    /// Supported versions: 4.0, 6.0 (latest). Default value is
    /// &apos;latest&apos;.
    /// </summary>
    public BicepValue<string> RedisVersion 
    {
        get { Initialize(); return _redisVersion!; }
        set { Initialize(); _redisVersion!.Assign(value); }
    }
    private BicepValue<string>? _redisVersion;

    /// <summary>
    /// The number of replicas to be created per primary.
    /// </summary>
    public BicepValue<int> ReplicasPerMaster 
    {
        get { Initialize(); return _replicasPerMaster!; }
        set { Initialize(); _replicasPerMaster!.Assign(value); }
    }
    private BicepValue<int>? _replicasPerMaster;

    /// <summary>
    /// The number of replicas to be created per primary.
    /// </summary>
    public BicepValue<int> ReplicasPerPrimary 
    {
        get { Initialize(); return _replicasPerPrimary!; }
        set { Initialize(); _replicasPerPrimary!.Assign(value); }
    }
    private BicepValue<int>? _replicasPerPrimary;

    /// <summary>
    /// The number of shards to be created on a Premium Cluster Cache.
    /// </summary>
    public BicepValue<int> ShardCount 
    {
        get { Initialize(); return _shardCount!; }
        set { Initialize(); _shardCount!.Assign(value); }
    }
    private BicepValue<int>? _shardCount;

    /// <summary>
    /// Static IP address. Optionally, may be specified when deploying a Redis
    /// cache inside an existing Azure Virtual Network; auto assigned by
    /// default.
    /// </summary>
    public BicepValue<IPAddress> StaticIP 
    {
        get { Initialize(); return _staticIP!; }
        set { Initialize(); _staticIP!.Assign(value); }
    }
    private BicepValue<IPAddress>? _staticIP;

    /// <summary>
    /// The full resource ID of a subnet in a virtual network to deploy the
    /// Redis cache in. Example format:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.{Network|ClassicNetwork}/VirtualNetworks/vnet1/subnets/subnet1.
    /// </summary>
    public BicepValue<ResourceIdentifier> SubnetId 
    {
        get { Initialize(); return _subnetId!; }
        set { Initialize(); _subnetId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _subnetId;

    /// <summary>
    /// Resource tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// A dictionary of tenant settings.
    /// </summary>
    public BicepDictionary<string> TenantSettings 
    {
        get { Initialize(); return _tenantSettings!; }
        set { Initialize(); _tenantSettings!.Assign(value); }
    }
    private BicepDictionary<string>? _tenantSettings;

    /// <summary>
    /// Optional: Specifies the update channel for the monthly Redis updates
    /// your Redis Cache will receive. Caches using &apos;Preview&apos; update
    /// channel get latest Redis updates at least 4 weeks ahead of
    /// &apos;Stable&apos; channel caches. Default value is &apos;Stable&apos;.
    /// </summary>
    public BicepValue<UpdateChannel> UpdateChannel 
    {
        get { Initialize(); return _updateChannel!; }
        set { Initialize(); _updateChannel!.Assign(value); }
    }
    private BicepValue<UpdateChannel>? _updateChannel;

    /// <summary>
    /// A list of availability zones denoting where the resource needs to come
    /// from.
    /// </summary>
    public BicepList<string> Zones 
    {
        get { Initialize(); return _zones!; }
        set { Initialize(); _zones!.Assign(value); }
    }
    private BicepList<string>? _zones;

    /// <summary>
    /// The keys of the Redis cache - not set if this object is not the
    /// response to Create or Update redis cache.
    /// </summary>
    public RedisAccessKeys AccessKeys 
    {
        get { Initialize(); return _accessKeys!; }
    }
    private RedisAccessKeys? _accessKeys;

    /// <summary>
    /// Redis host name.
    /// </summary>
    public BicepValue<string> HostName 
    {
        get { Initialize(); return _hostName!; }
    }
    private BicepValue<string>? _hostName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// List of the Redis instances associated with the cache.
    /// </summary>
    public BicepList<RedisInstanceDetails> Instances 
    {
        get { Initialize(); return _instances!; }
    }
    private BicepList<RedisInstanceDetails>? _instances;

    /// <summary>
    /// List of the linked servers associated with the cache.
    /// </summary>
    public BicepList<SubResource> LinkedServers 
    {
        get { Initialize(); return _linkedServers!; }
    }
    private BicepList<SubResource>? _linkedServers;

    /// <summary>
    /// Redis non-SSL port.
    /// </summary>
    public BicepValue<int> Port 
    {
        get { Initialize(); return _port!; }
    }
    private BicepValue<int>? _port;

    /// <summary>
    /// List of private endpoint connection associated with the specified redis
    /// cache.
    /// </summary>
    public BicepList<RedisPrivateEndpointConnectionData> PrivateEndpointConnections 
    {
        get { Initialize(); return _privateEndpointConnections!; }
    }
    private BicepList<RedisPrivateEndpointConnectionData>? _privateEndpointConnections;

    /// <summary>
    /// Redis instance provisioning status.
    /// </summary>
    public BicepValue<RedisProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<RedisProvisioningState>? _provisioningState;

    /// <summary>
    /// Redis SSL port.
    /// </summary>
    public BicepValue<int> SslPort 
    {
        get { Initialize(); return _sslPort!; }
    }
    private BicepValue<int>? _sslPort;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new RedisResource.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RedisResource resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RedisResource.</param>
    public RedisResource(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Cache/redis", resourceVersion ?? "2024-03-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of RedisResource.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _sku = DefineModelProperty<RedisSku>("Sku", ["properties", "sku"], isRequired: true);
        _enableNonSslPort = DefineProperty<bool>("EnableNonSslPort", ["properties", "enableNonSslPort"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _isAccessKeyAuthenticationDisabled = DefineProperty<bool>("IsAccessKeyAuthenticationDisabled", ["properties", "disableAccessKeyAuthentication"]);
        _minimumTlsVersion = DefineProperty<RedisTlsVersion>("MinimumTlsVersion", ["properties", "minimumTlsVersion"]);
        _publicNetworkAccess = DefineProperty<RedisPublicNetworkAccess>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _redisConfiguration = DefineModelProperty<RedisCommonConfiguration>("RedisConfiguration", ["properties", "redisConfiguration"]);
        _redisVersion = DefineProperty<string>("RedisVersion", ["properties", "redisVersion"]);
        _replicasPerMaster = DefineProperty<int>("ReplicasPerMaster", ["properties", "replicasPerMaster"]);
        _replicasPerPrimary = DefineProperty<int>("ReplicasPerPrimary", ["properties", "replicasPerPrimary"]);
        _shardCount = DefineProperty<int>("ShardCount", ["properties", "shardCount"]);
        _staticIP = DefineProperty<IPAddress>("StaticIP", ["properties", "staticIP"]);
        _subnetId = DefineProperty<ResourceIdentifier>("SubnetId", ["properties", "subnetId"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _tenantSettings = DefineDictionaryProperty<string>("TenantSettings", ["properties", "tenantSettings"]);
        _updateChannel = DefineProperty<UpdateChannel>("UpdateChannel", ["properties", "updateChannel"]);
        _zones = DefineListProperty<string>("Zones", ["zones"]);
        _accessKeys = DefineModelProperty<RedisAccessKeys>("AccessKeys", ["properties", "accessKeys"], isOutput: true);
        _hostName = DefineProperty<string>("HostName", ["properties", "hostName"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _instances = DefineListProperty<RedisInstanceDetails>("Instances", ["properties", "instances"], isOutput: true);
        _linkedServers = DefineListProperty<SubResource>("LinkedServers", ["properties", "linkedServers"], isOutput: true);
        _port = DefineProperty<int>("Port", ["properties", "port"], isOutput: true);
        _privateEndpointConnections = DefineListProperty<RedisPrivateEndpointConnectionData>("PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = DefineProperty<RedisProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _sslPort = DefineProperty<int>("SslPort", ["properties", "sslPort"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported RedisResource resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-03-01.
        /// </summary>
        public static readonly string V2024_03_01 = "2024-03-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";

        /// <summary>
        /// 2018-03-01.
        /// </summary>
        public static readonly string V2018_03_01 = "2018-03-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-02-01.
        /// </summary>
        public static readonly string V2017_02_01 = "2017-02-01";

        /// <summary>
        /// 2016-04-01.
        /// </summary>
        public static readonly string V2016_04_01 = "2016-04-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-03-01.
        /// </summary>
        public static readonly string V2015_03_01 = "2015-03-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing RedisResource.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the RedisResource resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the RedisResource.</param>
    /// <returns>The existing RedisResource resource.</returns>
    public static RedisResource FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this RedisResource resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this RedisResource resource.
    /// </summary>
    /// <returns>The keys for this RedisResource resource.</returns>
    public RedisAccessKeys GetKeys()
    {
        RedisAccessKeys key = new();
        ((IBicepValue)key).Expression = new FunctionCallExpression(new MemberExpression(new IdentifierExpression(BicepIdentifier), "listKeys"));
        return key;
    }

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this RedisResource.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(RedisBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{RedisBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// RedisResource.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(RedisBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{RedisBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
