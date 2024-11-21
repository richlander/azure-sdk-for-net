// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// A class representing the StaticSiteUserProvidedFunctionApp data model.
/// Static Site User Provided Function App ARM resource.
/// </summary>
public partial class StaticSiteUserProvidedFunctionAppData : ProvisionableConstruct
{
    /// <summary>
    /// The resource id of the function app registered with the static site.
    /// </summary>
    public BicepValue<ResourceIdentifier> FunctionAppResourceId 
    {
        get { Initialize(); return _functionAppResourceId!; }
        set { Initialize(); _functionAppResourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _functionAppResourceId;

    /// <summary>
    /// The region of the function app registered with the static site.
    /// </summary>
    public BicepValue<string> FunctionAppRegion 
    {
        get { Initialize(); return _functionAppRegion!; }
        set { Initialize(); _functionAppRegion!.Assign(value); }
    }
    private BicepValue<string>? _functionAppRegion;

    /// <summary>
    /// The date and time on which the function app was registered with the
    /// static site.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new StaticSiteUserProvidedFunctionAppData.
    /// </summary>
    public StaticSiteUserProvidedFunctionAppData()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// StaticSiteUserProvidedFunctionAppData.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _functionAppResourceId = DefineProperty<ResourceIdentifier>("FunctionAppResourceId", ["properties", "functionAppResourceId"]);
        _functionAppRegion = DefineProperty<string>("FunctionAppRegion", ["properties", "functionAppRegion"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createdOn"], isOutput: true);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
