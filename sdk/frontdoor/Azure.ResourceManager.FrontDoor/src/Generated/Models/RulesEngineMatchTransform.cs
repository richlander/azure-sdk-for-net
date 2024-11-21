// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Describes what transforms are applied before matching. </summary>
    public readonly partial struct RulesEngineMatchTransform : IEquatable<RulesEngineMatchTransform>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RulesEngineMatchTransform"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RulesEngineMatchTransform(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowercaseValue = "Lowercase";
        private const string UppercaseValue = "Uppercase";
        private const string TrimValue = "Trim";
        private const string UriDecodeValue = "UrlDecode";
        private const string UriEncodeValue = "UrlEncode";
        private const string RemoveNullsValue = "RemoveNulls";

        /// <summary> Lowercase. </summary>
        public static RulesEngineMatchTransform Lowercase { get; } = new RulesEngineMatchTransform(LowercaseValue);
        /// <summary> Uppercase. </summary>
        public static RulesEngineMatchTransform Uppercase { get; } = new RulesEngineMatchTransform(UppercaseValue);
        /// <summary> Trim. </summary>
        public static RulesEngineMatchTransform Trim { get; } = new RulesEngineMatchTransform(TrimValue);
        /// <summary> UrlDecode. </summary>
        public static RulesEngineMatchTransform UriDecode { get; } = new RulesEngineMatchTransform(UriDecodeValue);
        /// <summary> UrlEncode. </summary>
        public static RulesEngineMatchTransform UriEncode { get; } = new RulesEngineMatchTransform(UriEncodeValue);
        /// <summary> RemoveNulls. </summary>
        public static RulesEngineMatchTransform RemoveNulls { get; } = new RulesEngineMatchTransform(RemoveNullsValue);
        /// <summary> Determines if two <see cref="RulesEngineMatchTransform"/> values are the same. </summary>
        public static bool operator ==(RulesEngineMatchTransform left, RulesEngineMatchTransform right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RulesEngineMatchTransform"/> values are not the same. </summary>
        public static bool operator !=(RulesEngineMatchTransform left, RulesEngineMatchTransform right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RulesEngineMatchTransform"/>. </summary>
        public static implicit operator RulesEngineMatchTransform(string value) => new RulesEngineMatchTransform(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RulesEngineMatchTransform other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RulesEngineMatchTransform other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
