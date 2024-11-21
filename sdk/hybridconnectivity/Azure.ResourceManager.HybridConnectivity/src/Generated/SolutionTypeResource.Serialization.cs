// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridConnectivity
{
    public partial class SolutionTypeResource : IJsonModel<SolutionTypeResourceData>
    {
        void IJsonModel<SolutionTypeResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SolutionTypeResourceData>)Data).Write(writer, options);

        SolutionTypeResourceData IJsonModel<SolutionTypeResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SolutionTypeResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SolutionTypeResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SolutionTypeResourceData IPersistableModel<SolutionTypeResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SolutionTypeResourceData>(data, options);

        string IPersistableModel<SolutionTypeResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SolutionTypeResourceData>)Data).GetFormatFromOptions(options);
    }
}
