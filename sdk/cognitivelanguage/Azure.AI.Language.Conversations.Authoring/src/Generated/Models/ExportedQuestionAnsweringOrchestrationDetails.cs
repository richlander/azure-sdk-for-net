// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents the orchestration options for a Question Answering project target. </summary>
    public partial class ExportedQuestionAnsweringOrchestrationDetails : ExportedOrchestrationDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExportedQuestionAnsweringOrchestrationDetails"/>. </summary>
        /// <param name="questionAnsweringOrchestration"> The Question Answering project details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="questionAnsweringOrchestration"/> is null. </exception>
        public ExportedQuestionAnsweringOrchestrationDetails(ExportedQuestionAnsweringOrchestration questionAnsweringOrchestration)
        {
            Argument.AssertNotNull(questionAnsweringOrchestration, nameof(questionAnsweringOrchestration));

            TargetProjectKind = OrchestrationTargetProjectKind.QuestionAnswering;
            QuestionAnsweringOrchestration = questionAnsweringOrchestration;
        }

        /// <summary> Initializes a new instance of <see cref="ExportedQuestionAnsweringOrchestrationDetails"/>. </summary>
        /// <param name="targetProjectKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="questionAnsweringOrchestration"> The Question Answering project details. </param>
        internal ExportedQuestionAnsweringOrchestrationDetails(OrchestrationTargetProjectKind targetProjectKind, IDictionary<string, BinaryData> serializedAdditionalRawData, ExportedQuestionAnsweringOrchestration questionAnsweringOrchestration) : base(targetProjectKind, serializedAdditionalRawData)
        {
            QuestionAnsweringOrchestration = questionAnsweringOrchestration;
        }

        /// <summary> Initializes a new instance of <see cref="ExportedQuestionAnsweringOrchestrationDetails"/> for deserialization. </summary>
        internal ExportedQuestionAnsweringOrchestrationDetails()
        {
        }

        /// <summary> The Question Answering project details. </summary>
        public ExportedQuestionAnsweringOrchestration QuestionAnsweringOrchestration { get; }
    }
}
