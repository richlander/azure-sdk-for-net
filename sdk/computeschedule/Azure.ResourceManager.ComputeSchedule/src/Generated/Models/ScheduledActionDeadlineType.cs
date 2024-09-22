// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    /// <summary> The types of deadlines supported by ScheduledActions. </summary>
    public readonly partial struct ScheduledActionDeadlineType : IEquatable<ScheduledActionDeadlineType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduledActionDeadlineType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduledActionDeadlineType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string InitiateAtValue = "InitiateAt";
        private const string CompleteByValue = "CompleteBy";

        /// <summary> Default value of Unknown. </summary>
        public static ScheduledActionDeadlineType Unknown { get; } = new ScheduledActionDeadlineType(UnknownValue);
        /// <summary> Initiate the operation at the given deadline. </summary>
        public static ScheduledActionDeadlineType InitiateAt { get; } = new ScheduledActionDeadlineType(InitiateAtValue);
        /// <summary> Complete the operation by the given deadline. </summary>
        public static ScheduledActionDeadlineType CompleteBy { get; } = new ScheduledActionDeadlineType(CompleteByValue);
        /// <summary> Determines if two <see cref="ScheduledActionDeadlineType"/> values are the same. </summary>
        public static bool operator ==(ScheduledActionDeadlineType left, ScheduledActionDeadlineType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduledActionDeadlineType"/> values are not the same. </summary>
        public static bool operator !=(ScheduledActionDeadlineType left, ScheduledActionDeadlineType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScheduledActionDeadlineType"/>. </summary>
        public static implicit operator ScheduledActionDeadlineType(string value) => new ScheduledActionDeadlineType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduledActionDeadlineType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduledActionDeadlineType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
