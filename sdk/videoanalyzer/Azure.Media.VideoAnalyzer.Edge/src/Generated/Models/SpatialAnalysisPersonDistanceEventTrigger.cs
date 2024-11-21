// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The event trigger type. </summary>
    public readonly partial struct SpatialAnalysisPersonDistanceEventTrigger : IEquatable<SpatialAnalysisPersonDistanceEventTrigger>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpatialAnalysisPersonDistanceEventTrigger"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpatialAnalysisPersonDistanceEventTrigger(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EventValue = "event";
        private const string IntervalValue = "interval";

        /// <summary> Event trigger. </summary>
        public static SpatialAnalysisPersonDistanceEventTrigger Event { get; } = new SpatialAnalysisPersonDistanceEventTrigger(EventValue);
        /// <summary> Interval trigger. </summary>
        public static SpatialAnalysisPersonDistanceEventTrigger Interval { get; } = new SpatialAnalysisPersonDistanceEventTrigger(IntervalValue);
        /// <summary> Determines if two <see cref="SpatialAnalysisPersonDistanceEventTrigger"/> values are the same. </summary>
        public static bool operator ==(SpatialAnalysisPersonDistanceEventTrigger left, SpatialAnalysisPersonDistanceEventTrigger right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpatialAnalysisPersonDistanceEventTrigger"/> values are not the same. </summary>
        public static bool operator !=(SpatialAnalysisPersonDistanceEventTrigger left, SpatialAnalysisPersonDistanceEventTrigger right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SpatialAnalysisPersonDistanceEventTrigger"/>. </summary>
        public static implicit operator SpatialAnalysisPersonDistanceEventTrigger(string value) => new SpatialAnalysisPersonDistanceEventTrigger(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpatialAnalysisPersonDistanceEventTrigger other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpatialAnalysisPersonDistanceEventTrigger other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
