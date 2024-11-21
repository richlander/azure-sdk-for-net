// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    /// <summary> The action to take when a NFS volume is deleted. </summary>
    public readonly partial struct NfsDirectoryActionOnVolumeDeletion : IEquatable<NfsDirectoryActionOnVolumeDeletion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NfsDirectoryActionOnVolumeDeletion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NfsDirectoryActionOnVolumeDeletion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "Delete";
        private const string RetainValue = "Retain";

        /// <summary> When the volume is deleted, delete the directory. </summary>
        public static NfsDirectoryActionOnVolumeDeletion Delete { get; } = new NfsDirectoryActionOnVolumeDeletion(DeleteValue);
        /// <summary> When the volume is deleted, retain the directory. </summary>
        public static NfsDirectoryActionOnVolumeDeletion Retain { get; } = new NfsDirectoryActionOnVolumeDeletion(RetainValue);
        /// <summary> Determines if two <see cref="NfsDirectoryActionOnVolumeDeletion"/> values are the same. </summary>
        public static bool operator ==(NfsDirectoryActionOnVolumeDeletion left, NfsDirectoryActionOnVolumeDeletion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NfsDirectoryActionOnVolumeDeletion"/> values are not the same. </summary>
        public static bool operator !=(NfsDirectoryActionOnVolumeDeletion left, NfsDirectoryActionOnVolumeDeletion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NfsDirectoryActionOnVolumeDeletion"/>. </summary>
        public static implicit operator NfsDirectoryActionOnVolumeDeletion(string value) => new NfsDirectoryActionOnVolumeDeletion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NfsDirectoryActionOnVolumeDeletion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NfsDirectoryActionOnVolumeDeletion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
