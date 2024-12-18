// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> The EvaluationJobResult. </summary>
    public partial class EvaluationJobResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EvaluationJobResult"/>. </summary>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="modelLabel"> Represents trained model label. </param>
        /// <param name="trainingConfigVersion"> Represents training config version. </param>
        /// <param name="percentComplete"> Represents progress percentage. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="evaluationOptions"/>, <paramref name="modelLabel"/> or <paramref name="trainingConfigVersion"/> is null. </exception>
        internal EvaluationJobResult(EvaluationDetails evaluationOptions, string modelLabel, string trainingConfigVersion, int percentComplete)
        {
            Argument.AssertNotNull(evaluationOptions, nameof(evaluationOptions));
            Argument.AssertNotNull(modelLabel, nameof(modelLabel));
            Argument.AssertNotNull(trainingConfigVersion, nameof(trainingConfigVersion));

            EvaluationOptions = evaluationOptions;
            ModelLabel = modelLabel;
            TrainingConfigVersion = trainingConfigVersion;
            PercentComplete = percentComplete;
        }

        /// <summary> Initializes a new instance of <see cref="EvaluationJobResult"/>. </summary>
        /// <param name="evaluationOptions"> Represents the options used running the evaluation. </param>
        /// <param name="modelLabel"> Represents trained model label. </param>
        /// <param name="trainingConfigVersion"> Represents training config version. </param>
        /// <param name="percentComplete"> Represents progress percentage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EvaluationJobResult(EvaluationDetails evaluationOptions, string modelLabel, string trainingConfigVersion, int percentComplete, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EvaluationOptions = evaluationOptions;
            ModelLabel = modelLabel;
            TrainingConfigVersion = trainingConfigVersion;
            PercentComplete = percentComplete;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EvaluationJobResult"/> for deserialization. </summary>
        internal EvaluationJobResult()
        {
        }

        /// <summary> Represents the options used running the evaluation. </summary>
        public EvaluationDetails EvaluationOptions { get; }
        /// <summary> Represents trained model label. </summary>
        public string ModelLabel { get; }
        /// <summary> Represents training config version. </summary>
        public string TrainingConfigVersion { get; }
        /// <summary> Represents progress percentage. </summary>
        public int PercentComplete { get; }
    }
}
