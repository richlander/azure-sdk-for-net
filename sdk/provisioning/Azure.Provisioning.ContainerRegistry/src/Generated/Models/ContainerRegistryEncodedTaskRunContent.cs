// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The parameters for a quick task run request.
/// </summary>
public partial class ContainerRegistryEncodedTaskRunContent : ContainerRegistryRunContent
{
    /// <summary>
    /// Base64 encoded value of the template/definition file content.
    /// </summary>
    public BicepValue<string> EncodedTaskContent 
    {
        get { Initialize(); return _encodedTaskContent!; }
        set { Initialize(); _encodedTaskContent!.Assign(value); }
    }
    private BicepValue<string>? _encodedTaskContent;

    /// <summary>
    /// Base64 encoded value of the parameters/values file content.
    /// </summary>
    public BicepValue<string> EncodedValuesContent 
    {
        get { Initialize(); return _encodedValuesContent!; }
        set { Initialize(); _encodedValuesContent!.Assign(value); }
    }
    private BicepValue<string>? _encodedValuesContent;

    /// <summary>
    /// The collection of overridable values that can be passed when running a
    /// task.
    /// </summary>
    public BicepList<ContainerRegistryTaskOverridableValue> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<ContainerRegistryTaskOverridableValue>? _values;

    /// <summary>
    /// Run timeout in seconds.
    /// </summary>
    public BicepValue<int> TimeoutInSeconds 
    {
        get { Initialize(); return _timeoutInSeconds!; }
        set { Initialize(); _timeoutInSeconds!.Assign(value); }
    }
    private BicepValue<int>? _timeoutInSeconds;

    /// <summary>
    /// The platform properties against which the run has to happen.
    /// </summary>
    public ContainerRegistryPlatformProperties Platform 
    {
        get { Initialize(); return _platform!; }
        set { Initialize(); AssignOrReplace(ref _platform, value); }
    }
    private ContainerRegistryPlatformProperties? _platform;

    /// <summary>
    /// The CPU configuration in terms of number of cores required for the run.
    /// </summary>
    public BicepValue<int> AgentCpu 
    {
        get { Initialize(); return _agentCpu!; }
        set { Initialize(); _agentCpu!.Assign(value); }
    }
    private BicepValue<int>? _agentCpu;

    /// <summary>
    /// The URL(absolute or relative) of the source context. It can be an URL
    /// to a tar or git repository.             If it is relative URL, the
    /// relative path should be obtained from calling listBuildSourceUploadUrl
    /// API.
    /// </summary>
    public BicepValue<string> SourceLocation 
    {
        get { Initialize(); return _sourceLocation!; }
        set { Initialize(); _sourceLocation!.Assign(value); }
    }
    private BicepValue<string>? _sourceLocation;

    /// <summary>
    /// The properties that describes a set of credentials that will be used
    /// when this run is invoked.
    /// </summary>
    public ContainerRegistryCredentials Credentials 
    {
        get { Initialize(); return _credentials!; }
        set { Initialize(); AssignOrReplace(ref _credentials, value); }
    }
    private ContainerRegistryCredentials? _credentials;

    /// <summary>
    /// Creates a new ContainerRegistryEncodedTaskRunContent.
    /// </summary>
    public ContainerRegistryEncodedTaskRunContent() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerRegistryEncodedTaskRunContent.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("type", ["type"], defaultValue: "EncodedTaskRunRequest");
        _encodedTaskContent = DefineProperty<string>("EncodedTaskContent", ["encodedTaskContent"]);
        _encodedValuesContent = DefineProperty<string>("EncodedValuesContent", ["encodedValuesContent"]);
        _values = DefineListProperty<ContainerRegistryTaskOverridableValue>("Values", ["values"]);
        _timeoutInSeconds = DefineProperty<int>("TimeoutInSeconds", ["timeout"]);
        _platform = DefineModelProperty<ContainerRegistryPlatformProperties>("Platform", ["platform"]);
        _agentCpu = DefineProperty<int>("AgentCpu", ["agentConfiguration", "cpu"]);
        _sourceLocation = DefineProperty<string>("SourceLocation", ["sourceLocation"]);
        _credentials = DefineModelProperty<ContainerRegistryCredentials>("Credentials", ["credentials"]);
    }
}
