// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridConnectivity
{
    public partial class PublicCloudConnectorResource : IJsonModel<PublicCloudConnectorData>
    {
        void IJsonModel<PublicCloudConnectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PublicCloudConnectorData>)Data).Write(writer, options);

        PublicCloudConnectorData IJsonModel<PublicCloudConnectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PublicCloudConnectorData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PublicCloudConnectorData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        PublicCloudConnectorData IPersistableModel<PublicCloudConnectorData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PublicCloudConnectorData>(data, options);

        string IPersistableModel<PublicCloudConnectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PublicCloudConnectorData>)Data).GetFormatFromOptions(options);
    }
}
