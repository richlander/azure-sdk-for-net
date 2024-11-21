// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The speed Unit of measurement. </summary>
    public readonly partial struct SpeedUnit : IEquatable<SpeedUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpeedUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpeedUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnspecifiedValue = "Unspecified";
        private const string MetersPerSecondValue = "MetersPerSecond";
        private const string KilometersPerHourValue = "KilometersPerHour";
        private const string KilometersPerMinuteValue = "KilometersPerMinute";
        private const string KilometersPerSecondValue = "KilometersPerSecond";
        private const string MilesPerHourValue = "MilesPerHour";
        private const string KnotValue = "Knot";
        private const string FootPerSecondValue = "FootPerSecond";
        private const string FootPerMinuteValue = "FootPerMinute";
        private const string YardsPerMinuteValue = "YardsPerMinute";
        private const string YardsPerSecondValue = "YardsPerSecond";
        private const string MetersPerMillisecondValue = "MetersPerMillisecond";
        private const string CentimetersPerMillisecondValue = "CentimetersPerMillisecond";
        private const string KilometersPerMillisecondValue = "KilometersPerMillisecond";

        /// <summary> Unspecified speed unit. </summary>
        public static SpeedUnit Unspecified { get; } = new SpeedUnit(UnspecifiedValue);
        /// <summary> Meters per second speed unit. </summary>
        public static SpeedUnit MetersPerSecond { get; } = new SpeedUnit(MetersPerSecondValue);
        /// <summary> Kilometers per hour speed unit. </summary>
        public static SpeedUnit KilometersPerHour { get; } = new SpeedUnit(KilometersPerHourValue);
        /// <summary> Kilometers per minute speed unit. </summary>
        public static SpeedUnit KilometersPerMinute { get; } = new SpeedUnit(KilometersPerMinuteValue);
        /// <summary> Kilometers per second speed unit. </summary>
        public static SpeedUnit KilometersPerSecond { get; } = new SpeedUnit(KilometersPerSecondValue);
        /// <summary> Miles per hour speed unit. </summary>
        public static SpeedUnit MilesPerHour { get; } = new SpeedUnit(MilesPerHourValue);
        /// <summary> Knot speed unit. </summary>
        public static SpeedUnit Knot { get; } = new SpeedUnit(KnotValue);
        /// <summary> Foot per second speed unit. </summary>
        public static SpeedUnit FootPerSecond { get; } = new SpeedUnit(FootPerSecondValue);
        /// <summary> Foot per minute speed unit. </summary>
        public static SpeedUnit FootPerMinute { get; } = new SpeedUnit(FootPerMinuteValue);
        /// <summary> Yards per minute speed unit. </summary>
        public static SpeedUnit YardsPerMinute { get; } = new SpeedUnit(YardsPerMinuteValue);
        /// <summary> Yards per second speed unit. </summary>
        public static SpeedUnit YardsPerSecond { get; } = new SpeedUnit(YardsPerSecondValue);
        /// <summary> Meters per millisecond speed unit. </summary>
        public static SpeedUnit MetersPerMillisecond { get; } = new SpeedUnit(MetersPerMillisecondValue);
        /// <summary> Centimeters per millisecond speed unit. </summary>
        public static SpeedUnit CentimetersPerMillisecond { get; } = new SpeedUnit(CentimetersPerMillisecondValue);
        /// <summary> Kilometers per millisecond speed unit. </summary>
        public static SpeedUnit KilometersPerMillisecond { get; } = new SpeedUnit(KilometersPerMillisecondValue);
        /// <summary> Determines if two <see cref="SpeedUnit"/> values are the same. </summary>
        public static bool operator ==(SpeedUnit left, SpeedUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpeedUnit"/> values are not the same. </summary>
        public static bool operator !=(SpeedUnit left, SpeedUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SpeedUnit"/>. </summary>
        public static implicit operator SpeedUnit(string value) => new SpeedUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpeedUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpeedUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
