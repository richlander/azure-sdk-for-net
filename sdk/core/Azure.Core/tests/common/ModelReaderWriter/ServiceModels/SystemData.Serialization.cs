// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Core.Tests.ResourceManager.Models
{
    [JsonConverter(typeof(SystemDataConverter))]
    public partial class SystemData : IUtf8JsonSerializable, IJsonModel<SystemData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SystemData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SystemData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static SystemData DeserializeSystemData(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> createdBy = default;
            Optional<CreatedByType> createdByType = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<string> lastModifiedBy = default;
            Optional<CreatedByType> lastModifiedByType = default;
            Optional<DateTimeOffset> lastModifiedAt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdByType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByType = new CreatedByType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    lastModifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedByType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedByType = new CreatedByType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastModifiedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new SystemData(createdBy.Value, Optional.ToNullable(createdByType), Optional.ToNullable(createdAt), lastModifiedBy.Value, Optional.ToNullable(lastModifiedByType), Optional.ToNullable(lastModifiedAt));
        }

        private struct SystemDataProperties
        {
            public Optional<string> CreatedBy { get; set; }
            public Optional<CreatedByType> CreatedByType { get; set; }
            public Optional<DateTimeOffset> CreatedOn { get; set; }
            public Optional<string> LastModifiedBy { get; set; }
            public Optional<CreatedByType> LastModifiedByType { get; set; }
            public Optional<DateTimeOffset> LastModifiedOn { get; set; }
        }

        SystemData IJsonModel<SystemData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSystemData(doc.RootElement, options);
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref SystemDataProperties properties, ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            if (propertyName.SequenceEqual("createdBy"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.CreatedBy = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("createdByType"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.CreatedByType = new CreatedByType(reader.GetString());
                return;
            }
            if (propertyName.SequenceEqual("createdAt"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.CreatedOn = DateTimeOffset.Parse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                return;
            }
            if (propertyName.SequenceEqual("lastModifiedBy"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.LastModifiedBy = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("lastModifiedByType"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.LastModifiedByType = new CreatedByType(reader.GetString());
                return;
            }
            if (propertyName.SequenceEqual("lastModifiedAt"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.LastModifiedOn = DateTimeOffset.Parse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                return;
            }
            reader.Skip();
        }

        SystemData IModel<SystemData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeSystemData(doc.RootElement, options);
        }

        internal partial class SystemDataConverter : JsonConverter<SystemData>
        {
            public override void Write(Utf8JsonWriter writer, SystemData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SystemData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSystemData(document.RootElement, ModelReaderWriterOptions.DefaultWireOptions);
            }
        }

        BinaryData IModel<SystemData>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.WriteCore(this, options);
        }
    }
}
