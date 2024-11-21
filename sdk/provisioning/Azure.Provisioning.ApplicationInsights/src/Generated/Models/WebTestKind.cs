// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// The kind of WebTest that this web test watches. Choices are ping, multistep
/// and standard.
/// </summary>
public enum WebTestKind
{
    /// <summary>
    /// ping.
    /// </summary>
    [DataMember(Name = "ping")]
    Ping,

    /// <summary>
    /// multistep.
    /// </summary>
    [DataMember(Name = "multistep")]
    MultiStep,

    /// <summary>
    /// standard.
    /// </summary>
    [DataMember(Name = "standard")]
    Standard,
}
