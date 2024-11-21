// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The DomainNotRenewableReason. </summary>
    public readonly partial struct DomainNotRenewableReason : IEquatable<DomainNotRenewableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DomainNotRenewableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DomainNotRenewableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegistrationStatusNotSupportedForRenewalValue = "RegistrationStatusNotSupportedForRenewal";
        private const string ExpirationNotInRenewalTimeRangeValue = "ExpirationNotInRenewalTimeRange";
        private const string SubscriptionNotActiveValue = "SubscriptionNotActive";

        /// <summary> RegistrationStatusNotSupportedForRenewal. </summary>
        public static DomainNotRenewableReason RegistrationStatusNotSupportedForRenewal { get; } = new DomainNotRenewableReason(RegistrationStatusNotSupportedForRenewalValue);
        /// <summary> ExpirationNotInRenewalTimeRange. </summary>
        public static DomainNotRenewableReason ExpirationNotInRenewalTimeRange { get; } = new DomainNotRenewableReason(ExpirationNotInRenewalTimeRangeValue);
        /// <summary> SubscriptionNotActive. </summary>
        public static DomainNotRenewableReason SubscriptionNotActive { get; } = new DomainNotRenewableReason(SubscriptionNotActiveValue);
        /// <summary> Determines if two <see cref="DomainNotRenewableReason"/> values are the same. </summary>
        public static bool operator ==(DomainNotRenewableReason left, DomainNotRenewableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DomainNotRenewableReason"/> values are not the same. </summary>
        public static bool operator !=(DomainNotRenewableReason left, DomainNotRenewableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DomainNotRenewableReason"/>. </summary>
        public static implicit operator DomainNotRenewableReason(string value) => new DomainNotRenewableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DomainNotRenewableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DomainNotRenewableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
