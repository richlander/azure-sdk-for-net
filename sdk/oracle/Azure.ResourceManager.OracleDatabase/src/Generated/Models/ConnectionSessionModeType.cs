// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Session mode type enum. </summary>
    public readonly partial struct ConnectionSessionModeType : IEquatable<ConnectionSessionModeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectionSessionModeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionSessionModeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DirectValue = "Direct";
        private const string RedirectValue = "Redirect";

        /// <summary> Direct session mode. </summary>
        public static ConnectionSessionModeType Direct { get; } = new ConnectionSessionModeType(DirectValue);
        /// <summary> Redirect session mode. </summary>
        public static ConnectionSessionModeType Redirect { get; } = new ConnectionSessionModeType(RedirectValue);
        /// <summary> Determines if two <see cref="ConnectionSessionModeType"/> values are the same. </summary>
        public static bool operator ==(ConnectionSessionModeType left, ConnectionSessionModeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionSessionModeType"/> values are not the same. </summary>
        public static bool operator !=(ConnectionSessionModeType left, ConnectionSessionModeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectionSessionModeType"/>. </summary>
        public static implicit operator ConnectionSessionModeType(string value) => new ConnectionSessionModeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionSessionModeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionSessionModeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
