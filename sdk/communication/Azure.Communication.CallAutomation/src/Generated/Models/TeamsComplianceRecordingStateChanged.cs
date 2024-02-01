// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The TeamsComplianceRecordingStateChanged. </summary>
    public partial class TeamsComplianceRecordingStateChanged
    {
        /// <summary> Initializes a new instance of <see cref="TeamsComplianceRecordingStateChanged"/>. </summary>
        internal TeamsComplianceRecordingStateChanged()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TeamsComplianceRecordingStateChanged"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. </param>
        /// <param name="recordingId"> The call recording id. </param>
        /// <param name="state"></param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        internal TeamsComplianceRecordingStateChanged(string callConnectionId, string serverCallId, string correlationId, string recordingId, RecordingState state, DateTimeOffset? startDateTime)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            RecordingId = recordingId;
            State = state;
            StartDateTime = startDateTime;
        }
        /// <summary> The call recording id. </summary>
        public string RecordingId { get; }
        /// <summary> The time of the recording started. </summary>
        public DateTimeOffset? StartDateTime { get; }
    }
}
