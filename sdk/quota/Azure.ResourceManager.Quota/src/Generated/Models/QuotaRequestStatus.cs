// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Request status. </summary>
    public readonly partial struct QuotaRequestStatus : IEquatable<QuotaRequestStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QuotaRequestStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QuotaRequestStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatedValue = "Created";
        private const string InvalidValue = "Invalid";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string InProgressValue = "InProgress";
        private const string CanceledValue = "Canceled";

        /// <summary> Accepted. </summary>
        public static QuotaRequestStatus Accepted { get; } = new QuotaRequestStatus(AcceptedValue);
        /// <summary> Created. </summary>
        public static QuotaRequestStatus Created { get; } = new QuotaRequestStatus(CreatedValue);
        /// <summary> Invalid. </summary>
        public static QuotaRequestStatus Invalid { get; } = new QuotaRequestStatus(InvalidValue);
        /// <summary> Succeeded. </summary>
        public static QuotaRequestStatus Succeeded { get; } = new QuotaRequestStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static QuotaRequestStatus Failed { get; } = new QuotaRequestStatus(FailedValue);
        /// <summary> InProgress. </summary>
        public static QuotaRequestStatus InProgress { get; } = new QuotaRequestStatus(InProgressValue);
        /// <summary> Canceled. </summary>
        public static QuotaRequestStatus Canceled { get; } = new QuotaRequestStatus(CanceledValue);
        /// <summary> Determines if two <see cref="QuotaRequestStatus"/> values are the same. </summary>
        public static bool operator ==(QuotaRequestStatus left, QuotaRequestStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QuotaRequestStatus"/> values are not the same. </summary>
        public static bool operator !=(QuotaRequestStatus left, QuotaRequestStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="QuotaRequestStatus"/>. </summary>
        public static implicit operator QuotaRequestStatus(string value) => new QuotaRequestStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QuotaRequestStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QuotaRequestStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
