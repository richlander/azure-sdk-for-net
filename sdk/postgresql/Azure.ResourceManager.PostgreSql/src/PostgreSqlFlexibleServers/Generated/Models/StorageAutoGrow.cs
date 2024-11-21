// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Flag to enable / disable Storage Auto grow for flexible server. </summary>
    public readonly partial struct StorageAutoGrow : IEquatable<StorageAutoGrow>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageAutoGrow"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageAutoGrow(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static StorageAutoGrow Enabled { get; } = new StorageAutoGrow(EnabledValue);
        /// <summary> Disabled. </summary>
        public static StorageAutoGrow Disabled { get; } = new StorageAutoGrow(DisabledValue);
        /// <summary> Determines if two <see cref="StorageAutoGrow"/> values are the same. </summary>
        public static bool operator ==(StorageAutoGrow left, StorageAutoGrow right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageAutoGrow"/> values are not the same. </summary>
        public static bool operator !=(StorageAutoGrow left, StorageAutoGrow right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageAutoGrow"/>. </summary>
        public static implicit operator StorageAutoGrow(string value) => new StorageAutoGrow(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageAutoGrow other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageAutoGrow other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
