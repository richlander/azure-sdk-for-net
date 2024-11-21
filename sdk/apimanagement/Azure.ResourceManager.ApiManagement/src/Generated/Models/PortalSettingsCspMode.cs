// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The mode of the developer portal Content Security Policy (CSP). </summary>
    public readonly partial struct PortalSettingsCspMode : IEquatable<PortalSettingsCspMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PortalSettingsCspMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PortalSettingsCspMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "enabled";
        private const string DisabledValue = "disabled";
        private const string ReportOnlyValue = "reportOnly";

        /// <summary> The browser will block requests not matching allowed origins. </summary>
        public static PortalSettingsCspMode Enabled { get; } = new PortalSettingsCspMode(EnabledValue);
        /// <summary> The browser will not apply the origin restrictions. </summary>
        public static PortalSettingsCspMode Disabled { get; } = new PortalSettingsCspMode(DisabledValue);
        /// <summary> The browser will report requests not matching allowed origins without blocking them. </summary>
        public static PortalSettingsCspMode ReportOnly { get; } = new PortalSettingsCspMode(ReportOnlyValue);
        /// <summary> Determines if two <see cref="PortalSettingsCspMode"/> values are the same. </summary>
        public static bool operator ==(PortalSettingsCspMode left, PortalSettingsCspMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PortalSettingsCspMode"/> values are not the same. </summary>
        public static bool operator !=(PortalSettingsCspMode left, PortalSettingsCspMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PortalSettingsCspMode"/>. </summary>
        public static implicit operator PortalSettingsCspMode(string value) => new PortalSettingsCspMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PortalSettingsCspMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PortalSettingsCspMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
