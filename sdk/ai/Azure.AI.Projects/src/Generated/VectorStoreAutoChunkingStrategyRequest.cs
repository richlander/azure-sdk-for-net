// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> The default strategy. This strategy currently uses a max_chunk_size_tokens of 800 and chunk_overlap_tokens of 400. </summary>
    public partial class VectorStoreAutoChunkingStrategyRequest : VectorStoreChunkingStrategyRequest
    {
        /// <summary> Initializes a new instance of <see cref="VectorStoreAutoChunkingStrategyRequest"/>. </summary>
        public VectorStoreAutoChunkingStrategyRequest()
        {
            Type = VectorStoreChunkingStrategyRequestType.Auto;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreAutoChunkingStrategyRequest"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VectorStoreAutoChunkingStrategyRequest(VectorStoreChunkingStrategyRequestType type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
