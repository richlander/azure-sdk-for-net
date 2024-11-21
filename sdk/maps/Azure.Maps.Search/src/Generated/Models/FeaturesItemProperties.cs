// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary> The FeaturesItemProperties. </summary>
    public partial class FeaturesItemProperties
    {
        /// <summary> Initializes a new instance of <see cref="FeaturesItemProperties"/>. </summary>
        internal FeaturesItemProperties()
        {
            MatchCodes = new ChangeTrackingList<MatchCodesEnum>();
            GeocodePoints = new ChangeTrackingList<GeocodePointsItem>();
        }

        /// <summary> Initializes a new instance of <see cref="FeaturesItemProperties"/>. </summary>
        /// <param name="type">
        /// One of:
        /// * Address
        /// * RoadBlock
        /// * RoadIntersection
        /// * Neighborhood
        /// * PopulatedPlace
        /// * Postcode1
        /// * AdminDivision1
        /// * AdminDivision2
        /// * CountryRegion
        /// </param>
        /// <param name="confidence">
        /// The level of confidence that the geocoded location result is a match. Use this value with the match code to determine for more complete information about the match.
        ///
        /// The confidence of a geocoded location is based on many factors including the relative importance of the geocoded location and the user’s location, if specified.
        /// </param>
        /// <param name="matchCodes">
        /// One or more match code values that represent the geocoding level for each location in the response.
        ///
        /// For example, a geocoded location with match codes of `Good` and `Ambiguous` means that more than one geocode location was found for the location information and that the geocode service did not have search up-hierarchy to find a match.
        ///
        /// Similarly, a geocoded location with match codes of `Ambiguous` and `UpHierarchy` implies that a geocode location could not be found that matched all the provided location information, so the geocode service had to search up-hierarchy and found multiple matches at that level. An example of up an `Ambiguous` and `UpHierarchy` result is when you provide complete address information, but the geocode service cannot locate a match for the street address and instead returns information for more than one RoadBlock value.
        ///
        /// The possible values are:
        ///
        /// `Good`: The location has only one match or all returned matches are considered strong matches. For example, a query for New York returns several Good matches.
        ///
        /// `Ambiguous`: The location is one of a set of possible matches. For example, when you query for the street address 128 Main St., the response may return two locations for 128 North Main St. and 128 South Main St. because there is not enough information to determine which option to choose.
        ///
        /// `UpHierarchy`: The location represents a move up the geographic hierarchy. This occurs when a match for the location request was not found, so a less precise result is returned. For example, if a match for the requested address cannot be found, then a match code of `UpHierarchy` with a RoadBlock entity type may be returned.
        /// </param>
        /// <param name="address"> The address of the result. </param>
        /// <param name="geocodePoints"> A collection of geocode points that differ in how they were calculated and their suggested use. </param>
        internal FeaturesItemProperties(string type, ConfidenceEnum? confidence, IReadOnlyList<MatchCodesEnum> matchCodes, Address address, IReadOnlyList<GeocodePointsItem> geocodePoints)
        {
            Type = type;
            Confidence = confidence;
            MatchCodes = matchCodes;
            Address = address;
            GeocodePoints = geocodePoints;
        }

        /// <summary>
        /// One of:
        /// * Address
        /// * RoadBlock
        /// * RoadIntersection
        /// * Neighborhood
        /// * PopulatedPlace
        /// * Postcode1
        /// * AdminDivision1
        /// * AdminDivision2
        /// * CountryRegion
        /// </summary>
        public string Type { get; }
        /// <summary>
        /// The level of confidence that the geocoded location result is a match. Use this value with the match code to determine for more complete information about the match.
        ///
        /// The confidence of a geocoded location is based on many factors including the relative importance of the geocoded location and the user’s location, if specified.
        /// </summary>
        public ConfidenceEnum? Confidence { get; }
        /// <summary>
        /// One or more match code values that represent the geocoding level for each location in the response.
        ///
        /// For example, a geocoded location with match codes of `Good` and `Ambiguous` means that more than one geocode location was found for the location information and that the geocode service did not have search up-hierarchy to find a match.
        ///
        /// Similarly, a geocoded location with match codes of `Ambiguous` and `UpHierarchy` implies that a geocode location could not be found that matched all the provided location information, so the geocode service had to search up-hierarchy and found multiple matches at that level. An example of up an `Ambiguous` and `UpHierarchy` result is when you provide complete address information, but the geocode service cannot locate a match for the street address and instead returns information for more than one RoadBlock value.
        ///
        /// The possible values are:
        ///
        /// `Good`: The location has only one match or all returned matches are considered strong matches. For example, a query for New York returns several Good matches.
        ///
        /// `Ambiguous`: The location is one of a set of possible matches. For example, when you query for the street address 128 Main St., the response may return two locations for 128 North Main St. and 128 South Main St. because there is not enough information to determine which option to choose.
        ///
        /// `UpHierarchy`: The location represents a move up the geographic hierarchy. This occurs when a match for the location request was not found, so a less precise result is returned. For example, if a match for the requested address cannot be found, then a match code of `UpHierarchy` with a RoadBlock entity type may be returned.
        /// </summary>
        public IReadOnlyList<MatchCodesEnum> MatchCodes { get; }
        /// <summary> The address of the result. </summary>
        public Address Address { get; }
        /// <summary> A collection of geocode points that differ in how they were calculated and their suggested use. </summary>
        public IReadOnlyList<GeocodePointsItem> GeocodePoints { get; }
    }
}
