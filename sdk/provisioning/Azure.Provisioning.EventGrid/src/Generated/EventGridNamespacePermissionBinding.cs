// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// EventGridNamespacePermissionBinding.
/// </summary>
public partial class EventGridNamespacePermissionBinding : ProvisionableResource
{
    /// <summary>
    /// The permission binding name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The name of the client group resource that the permission is bound to.
    /// The client group needs to be a resource under the same
    /// namespace the permission binding is a part of.
    /// </summary>
    public BicepValue<string> ClientGroupName 
    {
        get { Initialize(); return _clientGroupName!; }
        set { Initialize(); _clientGroupName!.Assign(value); }
    }
    private BicepValue<string>? _clientGroupName;

    /// <summary>
    /// Description for the Permission Binding resource.
    /// </summary>
    public BicepValue<string> Description 
    {
        get { Initialize(); return _description!; }
        set { Initialize(); _description!.Assign(value); }
    }
    private BicepValue<string>? _description;

    /// <summary>
    /// The allowed permission.
    /// </summary>
    public BicepValue<PermissionType> Permission 
    {
        get { Initialize(); return _permission!; }
        set { Initialize(); _permission!.Assign(value); }
    }
    private BicepValue<PermissionType>? _permission;

    /// <summary>
    /// The name of the Topic Space resource that the permission is bound to.
    /// The Topic space needs to be a resource under the same
    /// namespace the permission binding is a part of.
    /// </summary>
    public BicepValue<string> TopicSpaceName 
    {
        get { Initialize(); return _topicSpaceName!; }
        set { Initialize(); _topicSpaceName!.Assign(value); }
    }
    private BicepValue<string>? _topicSpaceName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Provisioning state of the PermissionBinding resource.
    /// </summary>
    public BicepValue<PermissionBindingProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<PermissionBindingProvisioningState>? _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent EventGridNamespace.
    /// </summary>
    public EventGridNamespace? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<EventGridNamespace>? _parent;

    /// <summary>
    /// Creates a new EventGridNamespacePermissionBinding.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// EventGridNamespacePermissionBinding resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventGridNamespacePermissionBinding.</param>
    public EventGridNamespacePermissionBinding(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventGrid/namespaces/permissionBindings", resourceVersion)
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// EventGridNamespacePermissionBinding.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _clientGroupName = DefineProperty<string>("ClientGroupName", ["properties", "clientGroupName"]);
        _description = DefineProperty<string>("Description", ["properties", "description"]);
        _permission = DefineProperty<PermissionType>("Permission", ["properties", "permission"]);
        _topicSpaceName = DefineProperty<string>("TopicSpaceName", ["properties", "topicSpaceName"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _provisioningState = DefineProperty<PermissionBindingProvisioningState>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<EventGridNamespace>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventGridNamespacePermissionBinding resource versions.
    /// </summary>
    public static class ResourceVersions
    {
    }
    /// <summary>
    /// Creates a reference to an existing EventGridNamespacePermissionBinding.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// EventGridNamespacePermissionBinding resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventGridNamespacePermissionBinding.</param>
    /// <returns>The existing EventGridNamespacePermissionBinding resource.</returns>
    public static EventGridNamespacePermissionBinding FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
