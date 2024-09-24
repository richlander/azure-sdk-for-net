// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Indicates if base policy should be enforced for the policy document. </summary>
    public readonly partial struct PolicyRestrictionRequireBase : IEquatable<PolicyRestrictionRequireBase>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyRestrictionRequireBase"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyRestrictionRequireBase(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> The policy is required to have base policy. </summary>
        public static PolicyRestrictionRequireBase True { get; } = new PolicyRestrictionRequireBase(TrueValue);
        /// <summary> The policy does not require to have base policy. </summary>
        public static PolicyRestrictionRequireBase False { get; } = new PolicyRestrictionRequireBase(FalseValue);
        /// <summary> Determines if two <see cref="PolicyRestrictionRequireBase"/> values are the same. </summary>
        public static bool operator ==(PolicyRestrictionRequireBase left, PolicyRestrictionRequireBase right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyRestrictionRequireBase"/> values are not the same. </summary>
        public static bool operator !=(PolicyRestrictionRequireBase left, PolicyRestrictionRequireBase right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyRestrictionRequireBase"/>. </summary>
        public static implicit operator PolicyRestrictionRequireBase(string value) => new PolicyRestrictionRequireBase(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyRestrictionRequireBase other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyRestrictionRequireBase other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
