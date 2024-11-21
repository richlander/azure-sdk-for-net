// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Tells Dapr which protocol your application is using. Valid options are http
/// and grpc. Default is http.
/// </summary>
public enum ContainerAppProtocol
{
    /// <summary>
    /// http.
    /// </summary>
    [DataMember(Name = "http")]
    Http,

    /// <summary>
    /// grpc.
    /// </summary>
    [DataMember(Name = "grpc")]
    Grpc,
}
