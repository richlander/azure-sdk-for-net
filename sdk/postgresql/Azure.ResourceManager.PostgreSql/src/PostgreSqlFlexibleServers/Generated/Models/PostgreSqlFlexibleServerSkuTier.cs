// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The tier of the particular SKU, e.g. Burstable. </summary>
    public readonly partial struct PostgreSqlFlexibleServerSkuTier : IEquatable<PostgreSqlFlexibleServerSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BurstableValue = "Burstable";
        private const string GeneralPurposeValue = "GeneralPurpose";
        private const string MemoryOptimizedValue = "MemoryOptimized";

        /// <summary> Burstable. </summary>
        public static PostgreSqlFlexibleServerSkuTier Burstable { get; } = new PostgreSqlFlexibleServerSkuTier(BurstableValue);
        /// <summary> GeneralPurpose. </summary>
        public static PostgreSqlFlexibleServerSkuTier GeneralPurpose { get; } = new PostgreSqlFlexibleServerSkuTier(GeneralPurposeValue);
        /// <summary> MemoryOptimized. </summary>
        public static PostgreSqlFlexibleServerSkuTier MemoryOptimized { get; } = new PostgreSqlFlexibleServerSkuTier(MemoryOptimizedValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerSkuTier"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerSkuTier left, PostgreSqlFlexibleServerSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerSkuTier"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerSkuTier left, PostgreSqlFlexibleServerSkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlFlexibleServerSkuTier"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerSkuTier(string value) => new PostgreSqlFlexibleServerSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
