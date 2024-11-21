// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Deployment What-if properties.
/// </summary>
public partial class ArmDeploymentWhatIfProperties : ArmDeploymentProperties
{
    /// <summary>
    /// The format of the What-If results.
    /// </summary>
    public BicepValue<WhatIfResultFormat> WhatIfResultFormat 
    {
        get { Initialize(); return _whatIfResultFormat!; }
        set { Initialize(); _whatIfResultFormat!.Assign(value); }
    }
    private BicepValue<WhatIfResultFormat>? _whatIfResultFormat;

    /// <summary>
    /// Creates a new ArmDeploymentWhatIfProperties.
    /// </summary>
    public ArmDeploymentWhatIfProperties() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ArmDeploymentWhatIfProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _whatIfResultFormat = DefineProperty<WhatIfResultFormat>("WhatIfResultFormat", ["whatIfSettings", "resultFormat"]);
    }
}
