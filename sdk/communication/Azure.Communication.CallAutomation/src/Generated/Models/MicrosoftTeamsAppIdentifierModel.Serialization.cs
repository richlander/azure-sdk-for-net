// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class MicrosoftTeamsAppIdentifierModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            if (Cloud.HasValue)
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static MicrosoftTeamsAppIdentifierModel DeserializeMicrosoftTeamsAppIdentifierModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string appId = default;
            CommunicationCloudEnvironmentModel? cloud = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloud = new CommunicationCloudEnvironmentModel(property.Value.GetString());
                    continue;
                }
            }
            return new MicrosoftTeamsAppIdentifierModel(appId, cloud);
        }
    }
}
