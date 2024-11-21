// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Provisioning state of the certificate. </summary>
    public readonly partial struct ContainerAppCertificateProvisioningState : IEquatable<ContainerAppCertificateProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerAppCertificateProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerAppCertificateProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeleteFailedValue = "DeleteFailed";
        private const string PendingValue = "Pending";

        /// <summary> Succeeded. </summary>
        public static ContainerAppCertificateProvisioningState Succeeded { get; } = new ContainerAppCertificateProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContainerAppCertificateProvisioningState Failed { get; } = new ContainerAppCertificateProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContainerAppCertificateProvisioningState Canceled { get; } = new ContainerAppCertificateProvisioningState(CanceledValue);
        /// <summary> DeleteFailed. </summary>
        public static ContainerAppCertificateProvisioningState DeleteFailed { get; } = new ContainerAppCertificateProvisioningState(DeleteFailedValue);
        /// <summary> Pending. </summary>
        public static ContainerAppCertificateProvisioningState Pending { get; } = new ContainerAppCertificateProvisioningState(PendingValue);
        /// <summary> Determines if two <see cref="ContainerAppCertificateProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerAppCertificateProvisioningState left, ContainerAppCertificateProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerAppCertificateProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerAppCertificateProvisioningState left, ContainerAppCertificateProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerAppCertificateProvisioningState"/>. </summary>
        public static implicit operator ContainerAppCertificateProvisioningState(string value) => new ContainerAppCertificateProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerAppCertificateProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerAppCertificateProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
