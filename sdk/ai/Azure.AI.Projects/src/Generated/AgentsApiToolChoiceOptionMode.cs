// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Specifies how the tool choice will be used. </summary>
    public readonly partial struct AgentsApiToolChoiceOptionMode : IEquatable<AgentsApiToolChoiceOptionMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AgentsApiToolChoiceOptionMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AgentsApiToolChoiceOptionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string AutoValue = "auto";

        /// <summary> The model will not call a function and instead generates a message. </summary>
        public static AgentsApiToolChoiceOptionMode None { get; } = new AgentsApiToolChoiceOptionMode(NoneValue);
        /// <summary> The model can pick between generating a message or calling a function. </summary>
        public static AgentsApiToolChoiceOptionMode Auto { get; } = new AgentsApiToolChoiceOptionMode(AutoValue);
        /// <summary> Determines if two <see cref="AgentsApiToolChoiceOptionMode"/> values are the same. </summary>
        public static bool operator ==(AgentsApiToolChoiceOptionMode left, AgentsApiToolChoiceOptionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AgentsApiToolChoiceOptionMode"/> values are not the same. </summary>
        public static bool operator !=(AgentsApiToolChoiceOptionMode left, AgentsApiToolChoiceOptionMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AgentsApiToolChoiceOptionMode"/>. </summary>
        public static implicit operator AgentsApiToolChoiceOptionMode(string value) => new AgentsApiToolChoiceOptionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AgentsApiToolChoiceOptionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AgentsApiToolChoiceOptionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
