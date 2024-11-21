// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The Vpn Policy member attribute type. </summary>
    public readonly partial struct VpnPolicyMemberAttributeType : IEquatable<VpnPolicyMemberAttributeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VpnPolicyMemberAttributeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnPolicyMemberAttributeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CertificateGroupIdValue = "CertificateGroupId";
        private const string AadGroupIdValue = "AADGroupId";
        private const string RadiusAzureGroupIdValue = "RadiusAzureGroupId";

        /// <summary> CertificateGroupId. </summary>
        public static VpnPolicyMemberAttributeType CertificateGroupId { get; } = new VpnPolicyMemberAttributeType(CertificateGroupIdValue);
        /// <summary> AADGroupId. </summary>
        public static VpnPolicyMemberAttributeType AadGroupId { get; } = new VpnPolicyMemberAttributeType(AadGroupIdValue);
        /// <summary> RadiusAzureGroupId. </summary>
        public static VpnPolicyMemberAttributeType RadiusAzureGroupId { get; } = new VpnPolicyMemberAttributeType(RadiusAzureGroupIdValue);
        /// <summary> Determines if two <see cref="VpnPolicyMemberAttributeType"/> values are the same. </summary>
        public static bool operator ==(VpnPolicyMemberAttributeType left, VpnPolicyMemberAttributeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnPolicyMemberAttributeType"/> values are not the same. </summary>
        public static bool operator !=(VpnPolicyMemberAttributeType left, VpnPolicyMemberAttributeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VpnPolicyMemberAttributeType"/>. </summary>
        public static implicit operator VpnPolicyMemberAttributeType(string value) => new VpnPolicyMemberAttributeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnPolicyMemberAttributeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnPolicyMemberAttributeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
