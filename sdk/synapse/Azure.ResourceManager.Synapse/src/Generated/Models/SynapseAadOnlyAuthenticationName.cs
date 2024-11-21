// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SynapseAadOnlyAuthenticationName. </summary>
    public readonly partial struct SynapseAadOnlyAuthenticationName : IEquatable<SynapseAadOnlyAuthenticationName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseAadOnlyAuthenticationName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseAadOnlyAuthenticationName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static SynapseAadOnlyAuthenticationName Default { get; } = new SynapseAadOnlyAuthenticationName(DefaultValue);
        /// <summary> Determines if two <see cref="SynapseAadOnlyAuthenticationName"/> values are the same. </summary>
        public static bool operator ==(SynapseAadOnlyAuthenticationName left, SynapseAadOnlyAuthenticationName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseAadOnlyAuthenticationName"/> values are not the same. </summary>
        public static bool operator !=(SynapseAadOnlyAuthenticationName left, SynapseAadOnlyAuthenticationName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseAadOnlyAuthenticationName"/>. </summary>
        public static implicit operator SynapseAadOnlyAuthenticationName(string value) => new SynapseAadOnlyAuthenticationName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseAadOnlyAuthenticationName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseAadOnlyAuthenticationName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
