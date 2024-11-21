// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Action to perform based on the match or no match of the IpMask. </summary>
    public readonly partial struct EventGridIPActionType : IEquatable<EventGridIPActionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridIPActionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridIPActionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";

        /// <summary> Allow. </summary>
        public static EventGridIPActionType Allow { get; } = new EventGridIPActionType(AllowValue);
        /// <summary> Determines if two <see cref="EventGridIPActionType"/> values are the same. </summary>
        public static bool operator ==(EventGridIPActionType left, EventGridIPActionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridIPActionType"/> values are not the same. </summary>
        public static bool operator !=(EventGridIPActionType left, EventGridIPActionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventGridIPActionType"/>. </summary>
        public static implicit operator EventGridIPActionType(string value) => new EventGridIPActionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridIPActionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridIPActionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
