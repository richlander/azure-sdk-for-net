﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    [CodeGenSuppress(nameof(AnalyzeBatchDocumentsOptions), typeof(Uri))]
    public partial class AnalyzeBatchDocumentsOptions
    {
        // CUSTOM CODE NOTE: since either BlobSource or BlobFileListSource must be specified
        // when building this object, we're suppressing the creation of one of its constructors,
        // adding custom constructors, and making both properties readonly.

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchDocumentsOptions"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="blobSource"> Azure Blob Storage location containing the batch documents. </param>
        /// <param name="resultContainerUri"> Azure Blob Storage container URL where analyze result files will be stored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/>, <paramref name="blobSource"/>, or <paramref name="resultContainerUri"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="modelId"/> is an empty string, and was expected to be non-empty. </exception>
        public AnalyzeBatchDocumentsOptions(string modelId, BlobContentSource blobSource, Uri resultContainerUri) : this(modelId)
        {
            Argument.AssertNotNull(blobSource, nameof(blobSource));
            Argument.AssertNotNull(resultContainerUri, nameof(resultContainerUri));

            BlobSource = blobSource;
            ResultContainerUri = resultContainerUri;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchDocumentsOptions"/>. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="blobFileListSource"> Azure Blob Storage file list specifying the batch documents. </param>
        /// <param name="resultContainerUri"> Azure Blob Storage container URL where analyze result files will be stored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/>, <paramref name="blobFileListSource"/>, or <paramref name="resultContainerUri"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="modelId"/> is an empty string, and was expected to be non-empty. </exception>
        public AnalyzeBatchDocumentsOptions(string modelId, BlobFileListContentSource blobFileListSource, Uri resultContainerUri) : this(modelId)
        {
            Argument.AssertNotNull(blobFileListSource, nameof(blobFileListSource));
            Argument.AssertNotNull(resultContainerUri, nameof(resultContainerUri));

            BlobFileListSource = blobFileListSource;
            ResultContainerUri = resultContainerUri;
        }

        private AnalyzeBatchDocumentsOptions(string modelId)
        {
            Argument.AssertNotNullOrEmpty(modelId, nameof(modelId));

            ModelId = modelId;
            Features = new ChangeTrackingList<DocumentAnalysisFeature>();
            QueryFields = new ChangeTrackingList<string>();
            Output = new ChangeTrackingList<AnalyzeOutputOption>();
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }

        /// <summary>
        /// Azure Blob Storage location containing the batch documents.
        /// </summary>
        public BlobContentSource BlobSource { get; }

        /// <summary>
        /// Azure Blob Storage file list specifying the batch documents.
        /// </summary>
        public BlobFileListContentSource BlobFileListSource { get; }

        /// <summary>
        /// 1-based page numbers to analyze.  Ex. "1-3,5,7-9".
        /// </summary>
        public string Pages { get; set; }

        /// <summary>
        /// Locale hint for text recognition and document analysis.  Value may contain only
        /// the language code (ex. "en", "fr") or BCP 47 language tag (ex. "en-US").
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// List of optional analysis features.
        /// </summary>
        public ICollection<DocumentAnalysisFeature> Features { get; }

        /// <summary>
        /// List of additional fields to extract.  Ex. "NumberOfGuests,StoreNumber".
        /// </summary>
        public ICollection<string> QueryFields { get; }

        /// <summary>
        /// Format of the analyze result top-level content.
        /// </summary>
        public DocumentContentFormat? OutputContentFormat { get; set; }

        /// <summary>
        /// Additional outputs to generate during analysis.
        /// </summary>
        public ICollection<AnalyzeOutputOption> Output { get; }
    }
}
