// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Geodata information for a given IP address. </summary>
    public partial class EnrichmentIPGeodata
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

        /// <summary> Initializes a new instance of <see cref="EnrichmentIPGeodata"/>. </summary>
        internal EnrichmentIPGeodata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EnrichmentIPGeodata"/>. </summary>
        /// <param name="asn"> The autonomous system number associated with this IP address. </param>
        /// <param name="carrier"> The name of the carrier for this IP address. </param>
        /// <param name="city"> The city this IP address is located in. </param>
        /// <param name="cityCf"> A numeric rating of confidence that the value in the 'city' field is correct, on a scale of 0-100. </param>
        /// <param name="continent"> The continent this IP address is located on. </param>
        /// <param name="country"> The county this IP address is located in. </param>
        /// <param name="countryCf"> A numeric rating of confidence that the value in the 'country' field is correct on a scale of 0-100. </param>
        /// <param name="ipAddr"> The dotted-decimal or colon-separated string representation of the IP address. </param>
        /// <param name="ipRoutingType"> A description of the connection type of this IP address. </param>
        /// <param name="latitude"> The latitude of this IP address. </param>
        /// <param name="longitude"> The longitude of this IP address. </param>
        /// <param name="organization"> The name of the organization for this IP address. </param>
        /// <param name="organizationType"> The type of the organization for this IP address. </param>
        /// <param name="region"> The geographic region this IP address is located in. </param>
        /// <param name="state"> The state this IP address is located in. </param>
        /// <param name="stateCf"> A numeric rating of confidence that the value in the 'state' field is correct on a scale of 0-100. </param>
        /// <param name="stateCode"> The abbreviated name for the state this IP address is located in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnrichmentIPGeodata(string asn, string carrier, string city, int? cityCf, string continent, string country, int? countryCf, string ipAddr, string ipRoutingType, string latitude, string longitude, string organization, string organizationType, string region, string state, int? stateCf, string stateCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Asn = asn;
            Carrier = carrier;
            City = city;
            CityCf = cityCf;
            Continent = continent;
            Country = country;
            CountryCf = countryCf;
            IPAddr = ipAddr;
            IPRoutingType = ipRoutingType;
            Latitude = latitude;
            Longitude = longitude;
            Organization = organization;
            OrganizationType = organizationType;
            Region = region;
            State = state;
            StateCf = stateCf;
            StateCode = stateCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The autonomous system number associated with this IP address. </summary>
        [WirePath("asn")]
        public string Asn { get; }
        /// <summary> The name of the carrier for this IP address. </summary>
        [WirePath("carrier")]
        public string Carrier { get; }
        /// <summary> The city this IP address is located in. </summary>
        [WirePath("city")]
        public string City { get; }
        /// <summary> A numeric rating of confidence that the value in the 'city' field is correct, on a scale of 0-100. </summary>
        [WirePath("cityCf")]
        public int? CityCf { get; }
        /// <summary> The continent this IP address is located on. </summary>
        [WirePath("continent")]
        public string Continent { get; }
        /// <summary> The county this IP address is located in. </summary>
        [WirePath("country")]
        public string Country { get; }
        /// <summary> A numeric rating of confidence that the value in the 'country' field is correct on a scale of 0-100. </summary>
        [WirePath("countryCf")]
        public int? CountryCf { get; }
        /// <summary> The dotted-decimal or colon-separated string representation of the IP address. </summary>
        [WirePath("ipAddr")]
        public string IPAddr { get; }
        /// <summary> A description of the connection type of this IP address. </summary>
        [WirePath("ipRoutingType")]
        public string IPRoutingType { get; }
        /// <summary> The latitude of this IP address. </summary>
        [WirePath("latitude")]
        public string Latitude { get; }
        /// <summary> The longitude of this IP address. </summary>
        [WirePath("longitude")]
        public string Longitude { get; }
        /// <summary> The name of the organization for this IP address. </summary>
        [WirePath("organization")]
        public string Organization { get; }
        /// <summary> The type of the organization for this IP address. </summary>
        [WirePath("organizationType")]
        public string OrganizationType { get; }
        /// <summary> The geographic region this IP address is located in. </summary>
        [WirePath("region")]
        public string Region { get; }
        /// <summary> The state this IP address is located in. </summary>
        [WirePath("state")]
        public string State { get; }
        /// <summary> A numeric rating of confidence that the value in the 'state' field is correct on a scale of 0-100. </summary>
        [WirePath("stateCf")]
        public int? StateCf { get; }
        /// <summary> The abbreviated name for the state this IP address is located in. </summary>
        [WirePath("stateCode")]
        public string StateCode { get; }
    }
}
