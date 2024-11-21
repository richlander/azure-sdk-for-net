// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The status of the query testing request. </summary>
    public readonly partial struct StreamAnalyticsQueryTestingResultStatus : IEquatable<StreamAnalyticsQueryTestingResultStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryTestingResultStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamAnalyticsQueryTestingResultStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartedValue = "Started";
        private const string SuccessValue = "Success";
        private const string CompilerErrorValue = "CompilerError";
        private const string RuntimeErrorValue = "RuntimeError";
        private const string TimeoutValue = "Timeout";
        private const string UnknownErrorValue = "UnknownError";

        /// <summary> The query testing operation was initiated. </summary>
        public static StreamAnalyticsQueryTestingResultStatus Started { get; } = new StreamAnalyticsQueryTestingResultStatus(StartedValue);
        /// <summary> The query testing operation succeeded. </summary>
        public static StreamAnalyticsQueryTestingResultStatus Success { get; } = new StreamAnalyticsQueryTestingResultStatus(SuccessValue);
        /// <summary> The query testing operation failed due to a compiler error. </summary>
        public static StreamAnalyticsQueryTestingResultStatus CompilerError { get; } = new StreamAnalyticsQueryTestingResultStatus(CompilerErrorValue);
        /// <summary> The query testing operation failed due to a runtime error. </summary>
        public static StreamAnalyticsQueryTestingResultStatus RuntimeError { get; } = new StreamAnalyticsQueryTestingResultStatus(RuntimeErrorValue);
        /// <summary> The query testing operation failed due to a timeout. </summary>
        public static StreamAnalyticsQueryTestingResultStatus Timeout { get; } = new StreamAnalyticsQueryTestingResultStatus(TimeoutValue);
        /// <summary> The query testing operation failed due to an unknown error . </summary>
        public static StreamAnalyticsQueryTestingResultStatus UnknownError { get; } = new StreamAnalyticsQueryTestingResultStatus(UnknownErrorValue);
        /// <summary> Determines if two <see cref="StreamAnalyticsQueryTestingResultStatus"/> values are the same. </summary>
        public static bool operator ==(StreamAnalyticsQueryTestingResultStatus left, StreamAnalyticsQueryTestingResultStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamAnalyticsQueryTestingResultStatus"/> values are not the same. </summary>
        public static bool operator !=(StreamAnalyticsQueryTestingResultStatus left, StreamAnalyticsQueryTestingResultStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StreamAnalyticsQueryTestingResultStatus"/>. </summary>
        public static implicit operator StreamAnalyticsQueryTestingResultStatus(string value) => new StreamAnalyticsQueryTestingResultStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamAnalyticsQueryTestingResultStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamAnalyticsQueryTestingResultStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
