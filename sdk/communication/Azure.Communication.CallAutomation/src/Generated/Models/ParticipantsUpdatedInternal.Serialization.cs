// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class ParticipantsUpdatedInternal
    {
        internal static ParticipantsUpdatedInternal DeserializeParticipantsUpdatedInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string callConnectionId = default;
            string serverCallId = default;
            string correlationId = default;
            int? sequenceNumber = default;
            IReadOnlyList<CallParticipantInternal> participants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CallParticipantInternal> array = new List<CallParticipantInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CallParticipantInternal.DeserializeCallParticipantInternal(item));
                    }
                    participants = array;
                    continue;
                }
            }
            return new ParticipantsUpdatedInternal(callConnectionId, serverCallId, correlationId, sequenceNumber, participants ?? new ChangeTrackingList<CallParticipantInternal>());
        }
    }
}
