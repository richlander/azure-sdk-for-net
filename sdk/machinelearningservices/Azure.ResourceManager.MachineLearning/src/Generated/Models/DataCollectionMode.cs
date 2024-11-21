// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DataCollectionMode. </summary>
    public readonly partial struct DataCollectionMode : IEquatable<DataCollectionMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataCollectionMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataCollectionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DataCollectionMode Enabled { get; } = new DataCollectionMode(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DataCollectionMode Disabled { get; } = new DataCollectionMode(DisabledValue);
        /// <summary> Determines if two <see cref="DataCollectionMode"/> values are the same. </summary>
        public static bool operator ==(DataCollectionMode left, DataCollectionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataCollectionMode"/> values are not the same. </summary>
        public static bool operator !=(DataCollectionMode left, DataCollectionMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataCollectionMode"/>. </summary>
        public static implicit operator DataCollectionMode(string value) => new DataCollectionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataCollectionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataCollectionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
