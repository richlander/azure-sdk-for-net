// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> Failover tier of a storage class. </summary>
    public readonly partial struct FailoverTier : IEquatable<FailoverTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FailoverTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FailoverTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotAvailableValue = "NotAvailable";
        private const string SlowValue = "Slow";
        private const string FastValue = "Fast";
        private const string SuperValue = "Super";

        /// <summary> Not available Failover Tier. </summary>
        public static FailoverTier NotAvailable { get; } = new FailoverTier(NotAvailableValue);
        /// <summary> Slow Failover Tier. </summary>
        public static FailoverTier Slow { get; } = new FailoverTier(SlowValue);
        /// <summary> Fast Failover Tier. </summary>
        public static FailoverTier Fast { get; } = new FailoverTier(FastValue);
        /// <summary> Super Failover Tier. </summary>
        public static FailoverTier Super { get; } = new FailoverTier(SuperValue);
        /// <summary> Determines if two <see cref="FailoverTier"/> values are the same. </summary>
        public static bool operator ==(FailoverTier left, FailoverTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FailoverTier"/> values are not the same. </summary>
        public static bool operator !=(FailoverTier left, FailoverTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FailoverTier"/>. </summary>
        public static implicit operator FailoverTier(string value) => new FailoverTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FailoverTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FailoverTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
