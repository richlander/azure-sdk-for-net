// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Translation.Document
{
    /// <summary> Glossary / translation memory for the request. </summary>
    public partial class TranslationGlossary
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

        /// <summary> Initializes a new instance of <see cref="TranslationGlossary"/>. </summary>
        /// <param name="glossaryUri">
        /// Location of the glossary.
        /// We will use the file extension to extract the
        /// formatting if the format parameter is not supplied.
        ///
        /// If the translation
        /// language pair is not present in the glossary, it will not be applied
        /// </param>
        /// <param name="format"> Format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="glossaryUri"/> or <paramref name="format"/> is null. </exception>
        public TranslationGlossary(Uri glossaryUri, string format)
        {
            Argument.AssertNotNull(glossaryUri, nameof(glossaryUri));
            Argument.AssertNotNull(format, nameof(format));

            GlossaryUri = glossaryUri;
            Format = format;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationGlossary"/>. </summary>
        /// <param name="glossaryUri">
        /// Location of the glossary.
        /// We will use the file extension to extract the
        /// formatting if the format parameter is not supplied.
        ///
        /// If the translation
        /// language pair is not present in the glossary, it will not be applied
        /// </param>
        /// <param name="format"> Format. </param>
        /// <param name="formatVersion"> Optional Version.  If not specified, default is used. </param>
        /// <param name="storageSource"> Storage Source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslationGlossary(Uri glossaryUri, string format, string formatVersion, TranslationStorageSource? storageSource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GlossaryUri = glossaryUri;
            Format = format;
            FormatVersion = formatVersion;
            StorageSource = storageSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationGlossary"/> for deserialization. </summary>
        internal TranslationGlossary()
        {
        }
        /// <summary> Storage Source. </summary>
        public TranslationStorageSource? StorageSource { get; set; }
    }
}
