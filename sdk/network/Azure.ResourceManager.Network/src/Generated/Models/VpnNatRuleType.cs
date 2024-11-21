// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The type of NAT rule for VPN NAT. </summary>
    public readonly partial struct VpnNatRuleType : IEquatable<VpnNatRuleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VpnNatRuleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VpnNatRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "Static";
        private const string DynamicValue = "Dynamic";

        /// <summary> Static. </summary>
        public static VpnNatRuleType Static { get; } = new VpnNatRuleType(StaticValue);
        /// <summary> Dynamic. </summary>
        public static VpnNatRuleType Dynamic { get; } = new VpnNatRuleType(DynamicValue);
        /// <summary> Determines if two <see cref="VpnNatRuleType"/> values are the same. </summary>
        public static bool operator ==(VpnNatRuleType left, VpnNatRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VpnNatRuleType"/> values are not the same. </summary>
        public static bool operator !=(VpnNatRuleType left, VpnNatRuleType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VpnNatRuleType"/>. </summary>
        public static implicit operator VpnNatRuleType(string value) => new VpnNatRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VpnNatRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VpnNatRuleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
