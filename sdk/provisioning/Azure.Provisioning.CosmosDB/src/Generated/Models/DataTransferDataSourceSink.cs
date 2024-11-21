// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Base class for all DataTransfer source/sink             Please note
/// Azure.ResourceManager.CosmosDB.Models.DataTransferDataSourceSink is the
/// base class. According to the scenario, a derived class of the base class
/// might need to be assigned here, or this property needs to be casted to one
/// of the possible derived classes.             The available derived classes
/// include
/// Azure.ResourceManager.CosmosDB.Models.AzureBlobDataTransferDataSourceSink,
/// Azure.ResourceManager.CosmosDB.Models.BaseCosmosDataTransferDataSourceSink,
/// Azure.ResourceManager.CosmosDB.Models.CosmosCassandraDataTransferDataSourceSink,
/// Azure.ResourceManager.CosmosDB.Models.CosmosMongoDataTransferDataSourceSink
/// and
/// Azure.ResourceManager.CosmosDB.Models.CosmosSqlDataTransferDataSourceSink.
/// </summary>
public partial class DataTransferDataSourceSink : ProvisionableConstruct
{
    /// <summary>
    /// Creates a new DataTransferDataSourceSink.
    /// </summary>
    public DataTransferDataSourceSink()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of DataTransferDataSourceSink.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
    }
}
