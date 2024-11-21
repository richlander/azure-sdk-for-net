// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ResourceGroup.
/// </summary>
public partial class ResourceGroup : ProvisionableResource
{
    /// <summary>
    /// The name of the resource group to create or update. Can include
    /// alphanumeric, underscore, parentheses, hyphen, period (except at end),
    /// and Unicode characters that match the allowed characters.
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
    /// The ID of the resource that manages this resource group.
    /// </summary>
    public BicepValue<string> ManagedBy 
    {
        get { Initialize(); return _managedBy!; }
        set { Initialize(); _managedBy!.Assign(value); }
    }
    private BicepValue<string>? _managedBy;

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
    /// Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The provisioning state.
    /// </summary>
    public BicepValue<string> ResourceGroupProvisioningState 
    {
        get { Initialize(); return _resourceGroupProvisioningState!; }
    }
    private BicepValue<string>? _resourceGroupProvisioningState;

    /// <summary>
    /// Azure Resource Manager metadata containing createdBy and modifiedBy
    /// information.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new ResourceGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ResourceGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ResourceGroup.</param>
    public ResourceGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Resources/resourceGroups", resourceVersion ?? "2023-07-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ResourceGroup.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _managedBy = DefineProperty<string>("ManagedBy", ["managedBy"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _resourceGroupProvisioningState = DefineProperty<string>("ResourceGroupProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ResourceGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2022-12-01.
        /// </summary>
        public static readonly string V2022_12_01 = "2022-12-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2022-01-01.
        /// </summary>
        public static readonly string V2022_01_01 = "2022-01-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";

        /// <summary>
        /// 2020-07-01.
        /// </summary>
        public static readonly string V2020_07_01 = "2020-07-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2020-05-01.
        /// </summary>
        public static readonly string V2020_05_01 = "2020-05-01";

        /// <summary>
        /// 2020-01-01.
        /// </summary>
        public static readonly string V2020_01_01 = "2020-01-01";

        /// <summary>
        /// 2019-11-01.
        /// </summary>
        public static readonly string V2019_11_01 = "2019-11-01";

        /// <summary>
        /// 2019-10-01.
        /// </summary>
        public static readonly string V2019_10_01 = "2019-10-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2019-07-01.
        /// </summary>
        public static readonly string V2019_07_01 = "2019-07-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-05-01.
        /// </summary>
        public static readonly string V2019_05_01 = "2019-05-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2019-03-01.
        /// </summary>
        public static readonly string V2019_03_01 = "2019-03-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-09-01.
        /// </summary>
        public static readonly string V2018_09_01 = "2018-09-01";

        /// <summary>
        /// 2018-08-01.
        /// </summary>
        public static readonly string V2018_08_01 = "2018-08-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-05-01.
        /// </summary>
        public static readonly string V2018_05_01 = "2018-05-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2018-01-01.
        /// </summary>
        public static readonly string V2018_01_01 = "2018-01-01";

        /// <summary>
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2017-05-10.
        /// </summary>
        public static readonly string V2017_05_10 = "2017-05-10";

        /// <summary>
        /// 2017-05-01.
        /// </summary>
        public static readonly string V2017_05_01 = "2017-05-01";

        /// <summary>
        /// 2017-03-01.
        /// </summary>
        public static readonly string V2017_03_01 = "2017-03-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-07-01.
        /// </summary>
        public static readonly string V2016_07_01 = "2016-07-01";

        /// <summary>
        /// 2016-06-01.
        /// </summary>
        public static readonly string V2016_06_01 = "2016-06-01";

        /// <summary>
        /// 2016-02-01.
        /// </summary>
        public static readonly string V2016_02_01 = "2016-02-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing ResourceGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ResourceGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ResourceGroup.</param>
    /// <returns>The existing ResourceGroup resource.</returns>
    public static ResourceGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ResourceGroup resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 90, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period | ResourceNameCharacters.Parentheses);
}
