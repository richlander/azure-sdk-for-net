// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents the options for assigning Azure resources to a project. </summary>
    public partial class AssignDeploymentResourcesDetails
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

        /// <summary> Initializes a new instance of <see cref="AssignDeploymentResourcesDetails"/>. </summary>
        /// <param name="resourcesMetadata"> Represents the metadata for the resources to be assigned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcesMetadata"/> is null. </exception>
        public AssignDeploymentResourcesDetails(IEnumerable<ResourceMetadata> resourcesMetadata)
        {
            Argument.AssertNotNull(resourcesMetadata, nameof(resourcesMetadata));

            ResourcesMetadata = resourcesMetadata.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AssignDeploymentResourcesDetails"/>. </summary>
        /// <param name="resourcesMetadata"> Represents the metadata for the resources to be assigned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssignDeploymentResourcesDetails(IList<ResourceMetadata> resourcesMetadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourcesMetadata = resourcesMetadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssignDeploymentResourcesDetails"/> for deserialization. </summary>
        internal AssignDeploymentResourcesDetails()
        {
        }

        /// <summary> Represents the metadata for the resources to be assigned. </summary>
        public IList<ResourceMetadata> ResourcesMetadata { get; }
    }
}
