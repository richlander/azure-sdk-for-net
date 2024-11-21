// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Sets the interleave mode of the output to control how audio and video are stored in the container format. Example: set InterleavedOutput as NonInterleavedOutput to produce audio-only and video-only outputs in separate MP4 files. </summary>
    public readonly partial struct InterleaveOutput : IEquatable<InterleaveOutput>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InterleaveOutput"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InterleaveOutput(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NonInterleavedOutputValue = "NonInterleavedOutput";
        private const string InterleavedOutputValue = "InterleavedOutput";

        /// <summary> The output is video-only or audio-only. </summary>
        public static InterleaveOutput NonInterleavedOutput { get; } = new InterleaveOutput(NonInterleavedOutputValue);
        /// <summary> The output includes both audio and video. </summary>
        public static InterleaveOutput InterleavedOutput { get; } = new InterleaveOutput(InterleavedOutputValue);
        /// <summary> Determines if two <see cref="InterleaveOutput"/> values are the same. </summary>
        public static bool operator ==(InterleaveOutput left, InterleaveOutput right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InterleaveOutput"/> values are not the same. </summary>
        public static bool operator !=(InterleaveOutput left, InterleaveOutput right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InterleaveOutput"/>. </summary>
        public static implicit operator InterleaveOutput(string value) => new InterleaveOutput(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InterleaveOutput other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InterleaveOutput other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
