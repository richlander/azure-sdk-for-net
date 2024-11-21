// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Encryption identity for the storage account.
/// </summary>
public partial class StorageAccountEncryptionIdentity : ProvisionableConstruct
{
    /// <summary>
    /// Resource identifier of the UserAssigned identity to be associated with
    /// server-side encryption on the storage account.
    /// </summary>
    public BicepValue<string> EncryptionUserAssignedIdentity 
    {
        get { Initialize(); return _encryptionUserAssignedIdentity!; }
        set { Initialize(); _encryptionUserAssignedIdentity!.Assign(value); }
    }
    private BicepValue<string>? _encryptionUserAssignedIdentity;

    /// <summary>
    /// ClientId of the multi-tenant application to be used in conjunction with
    /// the user-assigned identity for cross-tenant customer-managed-keys
    /// server-side encryption on the storage account.
    /// </summary>
    public BicepValue<string> EncryptionFederatedIdentityClientId 
    {
        get { Initialize(); return _encryptionFederatedIdentityClientId!; }
        set { Initialize(); _encryptionFederatedIdentityClientId!.Assign(value); }
    }
    private BicepValue<string>? _encryptionFederatedIdentityClientId;

    /// <summary>
    /// Creates a new StorageAccountEncryptionIdentity.
    /// </summary>
    public StorageAccountEncryptionIdentity()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// StorageAccountEncryptionIdentity.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _encryptionUserAssignedIdentity = DefineProperty<string>("EncryptionUserAssignedIdentity", ["userAssignedIdentity"]);
        _encryptionFederatedIdentityClientId = DefineProperty<string>("EncryptionFederatedIdentityClientId", ["federatedIdentityClientId"]);
    }
}
