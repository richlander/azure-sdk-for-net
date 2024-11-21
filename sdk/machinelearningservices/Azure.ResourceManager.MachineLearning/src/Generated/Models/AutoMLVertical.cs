// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// AutoML vertical class.
    /// Base class for AutoML verticals - TableVertical/ImageVertical/NLPVertical
    /// Please note <see cref="AutoMLVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ClassificationTask"/>, <see cref="MachineLearningForecasting"/>, <see cref="ImageClassification"/>, <see cref="ImageClassificationMultilabel"/>, <see cref="ImageInstanceSegmentation"/>, <see cref="ImageObjectDetection"/>, <see cref="AutoMLVerticalRegression"/>, <see cref="TextClassification"/>, <see cref="TextClassificationMultilabel"/> and <see cref="TextNer"/>.
    /// </summary>
    public abstract partial class AutoMLVertical
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutoMLVertical"/>. </summary>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainingData"/> is null. </exception>
        protected AutoMLVertical(MachineLearningTableJobInput trainingData)
        {
            Argument.AssertNotNull(trainingData, nameof(trainingData));

            TrainingData = trainingData;
        }

        /// <summary> Initializes a new instance of <see cref="AutoMLVertical"/>. </summary>
        /// <param name="taskType"> [Required] Task type for AutoMLJob. </param>
        /// <param name="logVerbosity"> Log verbosity for the job. </param>
        /// <param name="trainingData"> [Required] Training data input. </param>
        /// <param name="targetColumnName">
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoMLVertical(TaskType taskType, MachineLearningLogVerbosity? logVerbosity, MachineLearningTableJobInput trainingData, string targetColumnName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TaskType = taskType;
            LogVerbosity = logVerbosity;
            TrainingData = trainingData;
            TargetColumnName = targetColumnName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutoMLVertical"/> for deserialization. </summary>
        internal AutoMLVertical()
        {
        }

        /// <summary> [Required] Task type for AutoMLJob. </summary>
        internal TaskType TaskType { get; set; }
        /// <summary> Log verbosity for the job. </summary>
        [WirePath("logVerbosity")]
        public MachineLearningLogVerbosity? LogVerbosity { get; set; }
        /// <summary> [Required] Training data input. </summary>
        [WirePath("trainingData")]
        public MachineLearningTableJobInput TrainingData { get; set; }
        /// <summary>
        /// Target column name: This is prediction values column.
        /// Also known as label column name in context of classification tasks.
        /// </summary>
        [WirePath("targetColumnName")]
        public string TargetColumnName { get; set; }
    }
}
