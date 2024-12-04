// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> A single message within an agent thread, as provided during that thread's creation for its initial state. </summary>
    public partial class ThreadMessageOptions
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

        /// <summary> Initializes a new instance of <see cref="ThreadMessageOptions"/>. </summary>
        /// <param name="role">
        /// The role of the entity that is creating the message. Allowed values include:
        /// - `user`: Indicates the message is sent by an actual user and should be used in most
        /// cases to represent user-generated messages.
        /// - `assistant`: Indicates the message is generated by the agent. Use this value to insert
        /// messages from the agent into the
        /// conversation.
        /// </param>
        /// <param name="content">
        /// The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via
        /// a separate call to the create message API.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public ThreadMessageOptions(MessageRole role, string content)
        {
            Argument.AssertNotNull(content, nameof(content));

            Role = role;
            Content = content;
            Attachments = new ChangeTrackingList<MessageAttachment>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessageOptions"/>. </summary>
        /// <param name="role">
        /// The role of the entity that is creating the message. Allowed values include:
        /// - `user`: Indicates the message is sent by an actual user and should be used in most
        /// cases to represent user-generated messages.
        /// - `assistant`: Indicates the message is generated by the agent. Use this value to insert
        /// messages from the agent into the
        /// conversation.
        /// </param>
        /// <param name="content">
        /// The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via
        /// a separate call to the create message API.
        /// </param>
        /// <param name="attachments"> A list of files attached to the message, and the tools they should be added to. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadMessageOptions(MessageRole role, string content, IList<MessageAttachment> attachments, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Role = role;
            Content = content;
            Attachments = attachments;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessageOptions"/> for deserialization. </summary>
        internal ThreadMessageOptions()
        {
        }

        /// <summary>
        /// The role of the entity that is creating the message. Allowed values include:
        /// - `user`: Indicates the message is sent by an actual user and should be used in most
        /// cases to represent user-generated messages.
        /// - `assistant`: Indicates the message is generated by the agent. Use this value to insert
        /// messages from the agent into the
        /// conversation.
        /// </summary>
        public MessageRole Role { get; }
        /// <summary>
        /// The textual content of the initial message. Currently, robust input including images and annotated text may only be provided via
        /// a separate call to the create message API.
        /// </summary>
        public string Content { get; }
        /// <summary> A list of files attached to the message, and the tools they should be added to. </summary>
        public IList<MessageAttachment> Attachments { get; set; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
