// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Built-in Arm roles that you can assign to users, groups, service
/// principals, and managed identities.
/// </summary>
/// <param name="value">The ID value of the role.</param>
public readonly struct ArmBuiltInRole(string value) : IEquatable<ArmBuiltInRole>
{
    private readonly string _value = value ?? throw new ArgumentNullException(nameof(value));

    /// <summary>
    /// Grants full access to manage all resources, but does not allow you to
    /// assign roles in Azure RBAC, manage assignments in Azure Blueprints, or
    /// share image galleries.
    /// </summary>
    public static ArmBuiltInRole Contributor { get; } = new(ContributorValue);
    internal const string ContributorValue = "b24988ac-6180-42a0-ab88-20f7382dd24c";

    /// <summary>
    /// Grants full access to manage all resources, including the ability to
    /// assign roles in Azure RBAC.
    /// </summary>
    public static ArmBuiltInRole Owner { get; } = new(OwnerValue);
    internal const string OwnerValue = "8e3af657-a8ff-443c-a75c-2fe8c4bcb635";

    /// <summary>
    /// View all resources, but does not allow you to make any changes.
    /// </summary>
    public static ArmBuiltInRole Reader { get; } = new(ReaderValue);
    internal const string ReaderValue = "acdd72a7-3385-48ef-bd42-f606fba81ae7";

    /// <summary>
    /// Manage access to Azure resources by assigning roles using Azure RBAC.
    /// This role does not allow you to manage access using other ways, such
    /// as Azure Policy.
    /// </summary>
    public static ArmBuiltInRole RoleBasedAccessControlAdministrator { get; } = new(RoleBasedAccessControlAdministratorValue);
    internal const string RoleBasedAccessControlAdministratorValue = "f58310d9-a9f6-439a-9e8d-f62e7b41a168";

    /// <summary>
    /// Lets you manage user access to Azure resources.
    /// </summary>
    public static ArmBuiltInRole UserAccessAdministrator { get; } = new(UserAccessAdministratorValue);
    internal const string UserAccessAdministratorValue = "18d7d88d-d35e-4fb5-a5c3-7773c20a72d9";

    /// <summary>
    /// Create, Read, Update, and Delete User Assigned Identity
    /// </summary>
    public static ArmBuiltInRole ManagedIdentityContributor { get; } = new(ManagedIdentityContributorValue);
    internal const string ManagedIdentityContributorValue = "e40ec5ca-96e0-45a2-b4ff-59039f2c2b59";

    /// <summary>
    /// Read and Assign User Assigned Identity
    /// </summary>
    public static ArmBuiltInRole ManagedIdentityOperator { get; } = new(ManagedIdentityOperatorValue);
    internal const string ManagedIdentityOperatorValue = "f1a07417-d97a-45cb-824c-7a7467783830";

    /// <summary>
    /// Try to get the name of a built-in Arm role from its ID value.
    /// </summary>
    /// <param name="value">The role value.</param>
    /// <returns>
    /// The name of the built-in Arm role if known, otherwise the ID will be returned.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string GetBuiltInRoleName(ArmBuiltInRole value) =>
        value._value switch
        {
            ContributorValue => nameof(Contributor),
            OwnerValue => nameof(Owner),
            ReaderValue => nameof(Reader),
            RoleBasedAccessControlAdministratorValue => nameof(RoleBasedAccessControlAdministrator),
            UserAccessAdministratorValue => nameof(UserAccessAdministrator),
            ManagedIdentityContributorValue => nameof(ManagedIdentityContributor),
            ManagedIdentityOperatorValue => nameof(ManagedIdentityOperator),
            _ => value._value
        };

    /// <summary>
    /// Determines if two ArmBuiltInRole values are the same.
    /// </summary>
    /// <param name="left">The first ArmBuiltInRole to compare.</param>
    /// <param name="right">The second ArmBuiltInRole to compare.</param>
    /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are the same; otherwise, false.</returns>
    public static bool operator ==(ArmBuiltInRole left, ArmBuiltInRole right) => left.Equals(right);

    /// <summary>
    /// Determines if two ArmBuiltInRole values are different.
    /// </summary>
    /// <param name="left">The first ArmBuiltInRole to compare.</param>
    /// <param name="right">The second ArmBuiltInRole to compare.</param>
    /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are different; otherwise, false.</returns>
    public static bool operator !=(ArmBuiltInRole left, ArmBuiltInRole right) => !left.Equals(right);

    /// <summary>
    /// Converts a string to a ArmBuiltInRole.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator ArmBuiltInRole(string value) => new(value);

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object? obj) => obj is ArmBuiltInRole other && Equals(other);

    /// <inheritdoc/>
    public bool Equals(ArmBuiltInRole other) => string.Equals(_value, other._value, StringComparison.Ordinal);

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public override string ToString() => _value;
}
