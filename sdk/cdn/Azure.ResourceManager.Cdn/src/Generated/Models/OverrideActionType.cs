// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the action to take on rule match. </summary>
    public readonly partial struct OverrideActionType : IEquatable<OverrideActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OverrideActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OverrideActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string BlockValue = "Block";
        private const string LogValue = "Log";
        private const string RedirectValue = "Redirect";

        /// <summary> Allow. </summary>
        public static OverrideActionType Allow { get; } = new OverrideActionType(AllowValue);
        /// <summary> Block. </summary>
        public static OverrideActionType Block { get; } = new OverrideActionType(BlockValue);
        /// <summary> Log. </summary>
        public static OverrideActionType Log { get; } = new OverrideActionType(LogValue);
        /// <summary> Redirect. </summary>
        public static OverrideActionType Redirect { get; } = new OverrideActionType(RedirectValue);
        /// <summary> Determines if two <see cref="OverrideActionType"/> values are the same. </summary>
        public static bool operator ==(OverrideActionType left, OverrideActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OverrideActionType"/> values are not the same. </summary>
        public static bool operator !=(OverrideActionType left, OverrideActionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OverrideActionType"/>. </summary>
        public static implicit operator OverrideActionType(string value) => new OverrideActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OverrideActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OverrideActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
