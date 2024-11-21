// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents security alert timeline item. </summary>
    public partial class SecurityAlertTimelineItem : EntityTimelineItem
    {
        /// <summary> Initializes a new instance of <see cref="SecurityAlertTimelineItem"/>. </summary>
        /// <param name="azureResourceId"> The alert azure resource id. </param>
        /// <param name="displayName"> The alert name. </param>
        /// <param name="severity"> The alert severity. </param>
        /// <param name="endOn"> The alert end time. </param>
        /// <param name="startOn"> The alert start time. </param>
        /// <param name="generatedOn"> The alert generated time. </param>
        /// <param name="alertType"> The name of the alert type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureResourceId"/>, <paramref name="displayName"/> or <paramref name="alertType"/> is null. </exception>
        internal SecurityAlertTimelineItem(ResourceIdentifier azureResourceId, string displayName, SecurityInsightsAlertSeverity severity, DateTimeOffset endOn, DateTimeOffset startOn, DateTimeOffset generatedOn, string alertType)
        {
            Argument.AssertNotNull(azureResourceId, nameof(azureResourceId));
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(alertType, nameof(alertType));

            AzureResourceId = azureResourceId;
            DisplayName = displayName;
            Severity = severity;
            EndOn = endOn;
            StartOn = startOn;
            GeneratedOn = generatedOn;
            AlertType = alertType;
            Techniques = new ChangeTrackingList<string>();
            Kind = EntityTimelineKind.SecurityAlert;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAlertTimelineItem"/>. </summary>
        /// <param name="kind"> The entity query kind type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="azureResourceId"> The alert azure resource id. </param>
        /// <param name="productName"> The alert product name. </param>
        /// <param name="description"> The alert description. </param>
        /// <param name="displayName"> The alert name. </param>
        /// <param name="severity"> The alert severity. </param>
        /// <param name="endOn"> The alert end time. </param>
        /// <param name="startOn"> The alert start time. </param>
        /// <param name="generatedOn"> The alert generated time. </param>
        /// <param name="alertType"> The name of the alert type. </param>
        /// <param name="intent"> The intent of the alert. </param>
        /// <param name="techniques"> The techniques of the alert. </param>
        internal SecurityAlertTimelineItem(EntityTimelineKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier azureResourceId, string productName, string description, string displayName, SecurityInsightsAlertSeverity severity, DateTimeOffset endOn, DateTimeOffset startOn, DateTimeOffset generatedOn, string alertType, SecurityInsightsKillChainIntent? intent, IReadOnlyList<string> techniques) : base(kind, serializedAdditionalRawData)
        {
            AzureResourceId = azureResourceId;
            ProductName = productName;
            Description = description;
            DisplayName = displayName;
            Severity = severity;
            EndOn = endOn;
            StartOn = startOn;
            GeneratedOn = generatedOn;
            AlertType = alertType;
            Intent = intent;
            Techniques = techniques;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAlertTimelineItem"/> for deserialization. </summary>
        internal SecurityAlertTimelineItem()
        {
        }

        /// <summary> The alert azure resource id. </summary>
        [WirePath("azureResourceId")]
        public ResourceIdentifier AzureResourceId { get; }
        /// <summary> The alert product name. </summary>
        [WirePath("productName")]
        public string ProductName { get; }
        /// <summary> The alert description. </summary>
        [WirePath("description")]
        public string Description { get; }
        /// <summary> The alert name. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; }
        /// <summary> The alert severity. </summary>
        [WirePath("severity")]
        public SecurityInsightsAlertSeverity Severity { get; }
        /// <summary> The alert end time. </summary>
        [WirePath("endTimeUtc")]
        public DateTimeOffset EndOn { get; }
        /// <summary> The alert start time. </summary>
        [WirePath("startTimeUtc")]
        public DateTimeOffset StartOn { get; }
        /// <summary> The alert generated time. </summary>
        [WirePath("timeGenerated")]
        public DateTimeOffset GeneratedOn { get; }
        /// <summary> The name of the alert type. </summary>
        [WirePath("alertType")]
        public string AlertType { get; }
        /// <summary> The intent of the alert. </summary>
        [WirePath("intent")]
        public SecurityInsightsKillChainIntent? Intent { get; }
        /// <summary> The techniques of the alert. </summary>
        [WirePath("techniques")]
        public IReadOnlyList<string> Techniques { get; }
    }
}
