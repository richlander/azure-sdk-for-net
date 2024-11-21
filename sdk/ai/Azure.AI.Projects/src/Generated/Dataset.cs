// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Dataset as source for evaluation. </summary>
    public partial class Dataset : InputData
    {
        /// <summary> Initializes a new instance of <see cref="Dataset"/>. </summary>
        /// <param name="id"> Evaluation input data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public Dataset(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Type = "dataset";
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="Dataset"/>. </summary>
        /// <param name="type"> Type of the data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="id"> Evaluation input data. </param>
        internal Dataset(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, string id) : base(type, serializedAdditionalRawData)
        {
            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="Dataset"/> for deserialization. </summary>
        internal Dataset()
        {
        }

        /// <summary> Evaluation input data. </summary>
        public string Id { get; set; }
    }
}
