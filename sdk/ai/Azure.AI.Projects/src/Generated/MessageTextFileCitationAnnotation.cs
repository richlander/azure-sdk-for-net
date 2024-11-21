// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> A citation within the message that points to a specific quote from a specific File associated with the agent or the message. Generated when the agent uses the 'file_search' tool to search files. </summary>
    public partial class MessageTextFileCitationAnnotation : MessageTextAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="MessageTextFileCitationAnnotation"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails">
        /// A citation within the message that points to a specific quote from a specific file.
        /// Generated when the agent uses the "file_search" tool to search files.
        /// </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        internal MessageTextFileCitationAnnotation(string type, string text, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalMessageTextFileCitationDetails internalDetails, int? startIndex, int? endIndex) : base(type, text, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextFileCitationAnnotation"/> for deserialization. </summary>
        internal MessageTextFileCitationAnnotation()
        {
        }
        /// <summary> The first text index associated with this text annotation. </summary>
        public int? StartIndex { get; set; }
        /// <summary> The last text index associated with this text annotation. </summary>
        public int? EndIndex { get; set; }
    }
}
