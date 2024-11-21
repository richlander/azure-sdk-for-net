// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The more detailed status of the bare metal machine. </summary>
    public readonly partial struct BareMetalMachineDetailedStatus : IEquatable<BareMetalMachineDetailedStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BareMetalMachineDetailedStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BareMetalMachineDetailedStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PreparingValue = "Preparing";
        private const string ErrorValue = "Error";
        private const string AvailableValue = "Available";
        private const string ProvisioningValue = "Provisioning";
        private const string ProvisionedValue = "Provisioned";
        private const string DeprovisioningValue = "Deprovisioning";

        /// <summary> Preparing. </summary>
        public static BareMetalMachineDetailedStatus Preparing { get; } = new BareMetalMachineDetailedStatus(PreparingValue);
        /// <summary> Error. </summary>
        public static BareMetalMachineDetailedStatus Error { get; } = new BareMetalMachineDetailedStatus(ErrorValue);
        /// <summary> Available. </summary>
        public static BareMetalMachineDetailedStatus Available { get; } = new BareMetalMachineDetailedStatus(AvailableValue);
        /// <summary> Provisioning. </summary>
        public static BareMetalMachineDetailedStatus Provisioning { get; } = new BareMetalMachineDetailedStatus(ProvisioningValue);
        /// <summary> Provisioned. </summary>
        public static BareMetalMachineDetailedStatus Provisioned { get; } = new BareMetalMachineDetailedStatus(ProvisionedValue);
        /// <summary> Deprovisioning. </summary>
        public static BareMetalMachineDetailedStatus Deprovisioning { get; } = new BareMetalMachineDetailedStatus(DeprovisioningValue);
        /// <summary> Determines if two <see cref="BareMetalMachineDetailedStatus"/> values are the same. </summary>
        public static bool operator ==(BareMetalMachineDetailedStatus left, BareMetalMachineDetailedStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BareMetalMachineDetailedStatus"/> values are not the same. </summary>
        public static bool operator !=(BareMetalMachineDetailedStatus left, BareMetalMachineDetailedStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BareMetalMachineDetailedStatus"/>. </summary>
        public static implicit operator BareMetalMachineDetailedStatus(string value) => new BareMetalMachineDetailedStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BareMetalMachineDetailedStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BareMetalMachineDetailedStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
