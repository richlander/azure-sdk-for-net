// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Acs Router Job Status. </summary>
    public readonly partial struct AcsRouterJobStatus : IEquatable<AcsRouterJobStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AcsRouterJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingClassificationValue = "PendingClassification";
        private const string QueuedValue = "Queued";
        private const string AssignedValue = "Assigned";
        private const string CompletedValue = "Completed";
        private const string ClosedValue = "Closed";
        private const string CancelledValue = "Cancelled";
        private const string ClassificationFailedValue = "ClassificationFailed";
        private const string CreatedValue = "Created";
        private const string PendingScheduleValue = "PendingSchedule";
        private const string ScheduledValue = "Scheduled";
        private const string ScheduleFailedValue = "ScheduleFailed";
        private const string WaitingForActivationValue = "WaitingForActivation";

        /// <summary> Router Job Status Pending Classification. </summary>
        public static AcsRouterJobStatus PendingClassification { get; } = new AcsRouterJobStatus(PendingClassificationValue);
        /// <summary> Router Job Status Queued. </summary>
        public static AcsRouterJobStatus Queued { get; } = new AcsRouterJobStatus(QueuedValue);
        /// <summary> Router Job Status Assigned. </summary>
        public static AcsRouterJobStatus Assigned { get; } = new AcsRouterJobStatus(AssignedValue);
        /// <summary> Router Job Status Completed. </summary>
        public static AcsRouterJobStatus Completed { get; } = new AcsRouterJobStatus(CompletedValue);
        /// <summary> Router Job Status Closed. </summary>
        public static AcsRouterJobStatus Closed { get; } = new AcsRouterJobStatus(ClosedValue);
        /// <summary> Router Job Status Cancelled. </summary>
        public static AcsRouterJobStatus Cancelled { get; } = new AcsRouterJobStatus(CancelledValue);
        /// <summary> Router Job Status Classification Failed. </summary>
        public static AcsRouterJobStatus ClassificationFailed { get; } = new AcsRouterJobStatus(ClassificationFailedValue);
        /// <summary> Router Job Status Created. </summary>
        public static AcsRouterJobStatus Created { get; } = new AcsRouterJobStatus(CreatedValue);
        /// <summary> Router Job Status Pending Schedule. </summary>
        public static AcsRouterJobStatus PendingSchedule { get; } = new AcsRouterJobStatus(PendingScheduleValue);
        /// <summary> Router Job Status Scheduled. </summary>
        public static AcsRouterJobStatus Scheduled { get; } = new AcsRouterJobStatus(ScheduledValue);
        /// <summary> Router Job Status Schedule Failed. </summary>
        public static AcsRouterJobStatus ScheduleFailed { get; } = new AcsRouterJobStatus(ScheduleFailedValue);
        /// <summary> Router Job Status Waiting For Activation. </summary>
        public static AcsRouterJobStatus WaitingForActivation { get; } = new AcsRouterJobStatus(WaitingForActivationValue);
        /// <summary> Determines if two <see cref="AcsRouterJobStatus"/> values are the same. </summary>
        public static bool operator ==(AcsRouterJobStatus left, AcsRouterJobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AcsRouterJobStatus"/> values are not the same. </summary>
        public static bool operator !=(AcsRouterJobStatus left, AcsRouterJobStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AcsRouterJobStatus"/>. </summary>
        public static implicit operator AcsRouterJobStatus(string value) => new AcsRouterJobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AcsRouterJobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AcsRouterJobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
