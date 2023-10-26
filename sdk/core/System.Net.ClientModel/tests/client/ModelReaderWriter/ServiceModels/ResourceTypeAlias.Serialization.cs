// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace System.Net.ClientModel.Tests.Client.ResourceManager.Resources.Models
{
    public partial class ResourceTypeAlias : IUtf8JsonContentWriteable, IJsonModel<ResourceTypeAlias>
    {
        void IUtf8JsonContentWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeAlias>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        internal static ResourceTypeAlias DeserializeResourceTypeAlias(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> name = default;
            OptionalProperty<IReadOnlyList<ResourceTypeAliasPath>> paths = default;
            OptionalProperty<ResourceTypeAliasType> type = default;
            OptionalProperty<string> defaultPath = default;
            OptionalProperty<ResourceTypeAliasPattern> defaultPattern = default;
            OptionalProperty<ResourceTypeAliasPathMetadata> defaultMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeAliasPath> array = new List<ResourceTypeAliasPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeAliasPath.DeserializeResourceTypeAliasPath(item, options));
                    }
                    paths = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasType();
                    continue;
                }
                if (property.NameEquals("defaultPath"u8))
                {
                    defaultPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultPattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultPattern = ResourceTypeAliasPattern.DeserializeResourceTypeAliasPattern(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMetadata = ResourceTypeAliasPathMetadata.DeserializeResourceTypeAliasPathMetadata(property.Value, options);
                    continue;
                }
            }
            return new ResourceTypeAlias(name.Value, OptionalProperty.ToList(paths), OptionalProperty.ToNullable(type), defaultPath.Value, defaultPattern.Value, defaultMetadata.Value);
        }

        void IJsonModel<ResourceTypeAlias>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (OptionalProperty.IsCollectionDefined(Paths))
            {
                writer.WritePropertyName("paths"u8);
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsDefined(AliasType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AliasType.ToString());
            }
            if (OptionalProperty.IsDefined(DefaultPath))
            {
                writer.WritePropertyName("defaultPath"u8);
                writer.WriteStringValue(DefaultPath);
            }
            if (OptionalProperty.IsDefined(DefaultPattern))
            {
                writer.WritePropertyName("defaultPattern"u8);
                writer.WriteObjectValue(DefaultPattern);
            }
            if (OptionalProperty.IsDefined(DefaultMetadata))
            {
                writer.WritePropertyName("defaultMetadata"u8);
                writer.WriteObjectValue(DefaultMetadata);
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasProperties
        {
            public OptionalProperty<string> Name { get; set; }
            public OptionalProperty<IReadOnlyList<ResourceTypeAliasPath>> Paths { get; set; }
            public OptionalProperty<ResourceTypeAliasType> AliasType { get; set; }
            public OptionalProperty<string> DefaultPath { get; set; }
            public OptionalProperty<ResourceTypeAliasPattern> DefaultPattern { get; set; }
            public OptionalProperty<ResourceTypeAliasPathMetadata> DefaultMetadata { get; set; }
        }

        ResourceTypeAlias IJsonModel<ResourceTypeAlias>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAlias(doc.RootElement, options);
        }

        ResourceTypeAlias IModel<ResourceTypeAlias>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAlias(doc.RootElement, options);
        }

        BinaryData IModel<ResourceTypeAlias>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.WriteCore(this, options);
        }
    }
}
