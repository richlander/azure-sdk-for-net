// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents the comparison between the expected and the predicted intent for an utterance. </summary>
    public partial class UtteranceIntentsEvaluationResult
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

        /// <summary> Initializes a new instance of <see cref="UtteranceIntentsEvaluationResult"/>. </summary>
        /// <param name="expectedIntent"> Represents the utterance's expected intent. </param>
        /// <param name="predictedIntent"> Represents the utterance's predicted intent. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expectedIntent"/> or <paramref name="predictedIntent"/> is null. </exception>
        internal UtteranceIntentsEvaluationResult(string expectedIntent, string predictedIntent)
        {
            Argument.AssertNotNull(expectedIntent, nameof(expectedIntent));
            Argument.AssertNotNull(predictedIntent, nameof(predictedIntent));

            ExpectedIntent = expectedIntent;
            PredictedIntent = predictedIntent;
        }

        /// <summary> Initializes a new instance of <see cref="UtteranceIntentsEvaluationResult"/>. </summary>
        /// <param name="expectedIntent"> Represents the utterance's expected intent. </param>
        /// <param name="predictedIntent"> Represents the utterance's predicted intent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UtteranceIntentsEvaluationResult(string expectedIntent, string predictedIntent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpectedIntent = expectedIntent;
            PredictedIntent = predictedIntent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UtteranceIntentsEvaluationResult"/> for deserialization. </summary>
        internal UtteranceIntentsEvaluationResult()
        {
        }

        /// <summary> Represents the utterance's expected intent. </summary>
        public string ExpectedIntent { get; }
        /// <summary> Represents the utterance's predicted intent. </summary>
        public string PredictedIntent { get; }
    }
}
