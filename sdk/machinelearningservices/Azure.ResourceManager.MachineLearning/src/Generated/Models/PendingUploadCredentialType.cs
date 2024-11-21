// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine the PendingUpload credentials type. </summary>
    internal readonly partial struct PendingUploadCredentialType : IEquatable<PendingUploadCredentialType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PendingUploadCredentialType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PendingUploadCredentialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SasValue = "SAS";

        /// <summary> SAS. </summary>
        public static PendingUploadCredentialType Sas { get; } = new PendingUploadCredentialType(SasValue);
        /// <summary> Determines if two <see cref="PendingUploadCredentialType"/> values are the same. </summary>
        public static bool operator ==(PendingUploadCredentialType left, PendingUploadCredentialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PendingUploadCredentialType"/> values are not the same. </summary>
        public static bool operator !=(PendingUploadCredentialType left, PendingUploadCredentialType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PendingUploadCredentialType"/>. </summary>
        public static implicit operator PendingUploadCredentialType(string value) => new PendingUploadCredentialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PendingUploadCredentialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PendingUploadCredentialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
