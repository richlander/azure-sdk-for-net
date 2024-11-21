// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> Possible reasons for a name not being available. </summary>
    public readonly partial struct MongoClusterNameUnavailableReason : IEquatable<MongoClusterNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoClusterNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoClusterNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Name is invalid. </summary>
        public static MongoClusterNameUnavailableReason Invalid { get; } = new MongoClusterNameUnavailableReason(InvalidValue);
        /// <summary> Name already exists. </summary>
        public static MongoClusterNameUnavailableReason AlreadyExists { get; } = new MongoClusterNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="MongoClusterNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(MongoClusterNameUnavailableReason left, MongoClusterNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoClusterNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(MongoClusterNameUnavailableReason left, MongoClusterNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MongoClusterNameUnavailableReason"/>. </summary>
        public static implicit operator MongoClusterNameUnavailableReason(string value) => new MongoClusterNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoClusterNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoClusterNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
