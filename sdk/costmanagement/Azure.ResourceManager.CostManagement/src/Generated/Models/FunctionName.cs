// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The name of the column to aggregate. </summary>
    public readonly partial struct FunctionName : IEquatable<FunctionName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FunctionName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FunctionName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreTaxCostUSDValue = "PreTaxCostUSD";
        private const string CostValue = "Cost";
        private const string CostUSDValue = "CostUSD";
        private const string PreTaxCostValue = "PreTaxCost";

        /// <summary> PreTaxCostUSD. </summary>
        public static FunctionName PreTaxCostUSD { get; } = new FunctionName(PreTaxCostUSDValue);
        /// <summary> Cost. </summary>
        public static FunctionName Cost { get; } = new FunctionName(CostValue);
        /// <summary> CostUSD. </summary>
        public static FunctionName CostUSD { get; } = new FunctionName(CostUSDValue);
        /// <summary> PreTaxCost. </summary>
        public static FunctionName PreTaxCost { get; } = new FunctionName(PreTaxCostValue);
        /// <summary> Determines if two <see cref="FunctionName"/> values are the same. </summary>
        public static bool operator ==(FunctionName left, FunctionName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FunctionName"/> values are not the same. </summary>
        public static bool operator !=(FunctionName left, FunctionName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FunctionName"/>. </summary>
        public static implicit operator FunctionName(string value) => new FunctionName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FunctionName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FunctionName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
