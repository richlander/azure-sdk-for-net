// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Maps.Weather.Models
{
    /// <summary> The HourlyForecast. </summary>
    public partial class HourlyForecast
    {
        /// <summary> Initializes a new instance of <see cref="HourlyForecast"/>. </summary>
        internal HourlyForecast()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HourlyForecast"/>. </summary>
        /// <param name="timestamp"> Date and time of the forecast in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </param>
        /// <param name="iconCode"> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </param>
        /// <param name="iconPhrase"> Phrase description of the weather icon. </param>
        /// <param name="hasPrecipitation"> Indicates the presence or absence of precipitation. True indicates the presence of precipitation, false indicates the absence of precipitation. </param>
        /// <param name="isDaylight"> Specifies whether or not it is daylight. True indicates day light. </param>
        /// <param name="temperature"> Temperature being returned. </param>
        /// <param name="realFeelTemperature"> RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade. </param>
        /// <param name="wetBulbTemperature"> The temperature to which air may be cooled by evaporating water into it at constant pressure until it reaches saturation. </param>
        /// <param name="dewPoint"> The dewpoint temperature in specified unit. The dewpoint temperature is the temperature that the air must be cooled to in order to reach saturation. </param>
        /// <param name="wind"> Wind details being returned including speed and direction. </param>
        /// <param name="windGust"> Wind gust. Wind gust is a sudden, brief increase in speed of the wind. </param>
        /// <param name="relativeHumidity"> Relative humidity is the amount of water vapor present in air expressed as a percentage of the amount needed for saturation at the same temperature. </param>
        /// <param name="visibility"> Visibility in specified unit. A measure of the distance at which an object or light can be clearly discerned. </param>
        /// <param name="cloudCeiling"> Cloud ceiling in specified unit. The ceiling is a measurement of the height of the base of the lowest clouds. </param>
        /// <param name="uvIndex">
        /// Measure of the strength of the ultraviolet radiation from the sun. Supported values are:
        ///   * `0-2` - Low danger from the sun's UV rays or the average person.
        ///   * `3-5` - Moderate risk of harm from unprotected sun exposure.
        ///   * `6-7` - High risk of harm from unprotected sun exposure.
        ///   * `8-10` - Very high risk of harm from unprotected sun exposure.
        ///   * `11+` - Extreme risk of harm from unprotected sun exposure.
        /// </param>
        /// <param name="uvIndexDescription"> Phrase associated with the `uvIndex`. </param>
        /// <param name="precipitationProbability"> Percent representing the probability of precipitation. For example, '20'. </param>
        /// <param name="rainProbability"> Percent representing the probability of rain. For example, '50'. </param>
        /// <param name="snowProbability"> Percent representing the probability of snow. For example, '50'. </param>
        /// <param name="iceProbability"> Percent representing the probability of snow. For example, '5'. </param>
        /// <param name="totalLiquid"> Total liquid equivalent of precipitation during the forecast period. </param>
        /// <param name="rain"> Rain. </param>
        /// <param name="snow"> Snow. </param>
        /// <param name="ice"> Ice. </param>
        /// <param name="cloudCover"> Percent representing cloud cover. </param>
        internal HourlyForecast(DateTimeOffset? timestamp, IconCode? iconCode, string iconPhrase, bool? hasPrecipitation, bool? isDaylight, WeatherValue temperature, WeatherValue realFeelTemperature, WeatherValue wetBulbTemperature, WeatherValue dewPoint, WindDetails wind, WindDetails windGust, int? relativeHumidity, WeatherValue visibility, WeatherValue cloudCeiling, int? uvIndex, string uvIndexDescription, int? precipitationProbability, int? rainProbability, int? snowProbability, int? iceProbability, WeatherValue totalLiquid, WeatherValue rain, WeatherValue snow, WeatherValue ice, int? cloudCover)
        {
            Timestamp = timestamp;
            IconCode = iconCode;
            IconPhrase = iconPhrase;
            HasPrecipitation = hasPrecipitation;
            IsDaylight = isDaylight;
            Temperature = temperature;
            RealFeelTemperature = realFeelTemperature;
            WetBulbTemperature = wetBulbTemperature;
            DewPoint = dewPoint;
            Wind = wind;
            WindGust = windGust;
            RelativeHumidity = relativeHumidity;
            Visibility = visibility;
            CloudCeiling = cloudCeiling;
            UvIndex = uvIndex;
            UvIndexDescription = uvIndexDescription;
            PrecipitationProbability = precipitationProbability;
            RainProbability = rainProbability;
            SnowProbability = snowProbability;
            IceProbability = iceProbability;
            TotalLiquid = totalLiquid;
            Rain = rain;
            Snow = snow;
            Ice = ice;
            CloudCover = cloudCover;
        }

        /// <summary> Date and time of the forecast in ISO 8601 format, for example, 2019-10-27T19:39:57-08:00. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Numeric value representing an image that displays the `iconPhrase`. Please refer to [Weather services in Azure Maps](/azure/azure-maps/weather-services-concepts#weather-icons) for details. </summary>
        public IconCode? IconCode { get; }
        /// <summary> Phrase description of the weather icon. </summary>
        public string IconPhrase { get; }
        /// <summary> Indicates the presence or absence of precipitation. True indicates the presence of precipitation, false indicates the absence of precipitation. </summary>
        public bool? HasPrecipitation { get; }
        /// <summary> Specifies whether or not it is daylight. True indicates day light. </summary>
        public bool? IsDaylight { get; }
        /// <summary> Temperature being returned. </summary>
        public WeatherValue Temperature { get; }
        /// <summary> RealFeel™ Temperature being returned. Describes what the temperature really feels like in the shade. </summary>
        public WeatherValue RealFeelTemperature { get; }
        /// <summary> The temperature to which air may be cooled by evaporating water into it at constant pressure until it reaches saturation. </summary>
        public WeatherValue WetBulbTemperature { get; }
        /// <summary> The dewpoint temperature in specified unit. The dewpoint temperature is the temperature that the air must be cooled to in order to reach saturation. </summary>
        public WeatherValue DewPoint { get; }
        /// <summary> Wind details being returned including speed and direction. </summary>
        public WindDetails Wind { get; }
        /// <summary> Wind gust. Wind gust is a sudden, brief increase in speed of the wind. </summary>
        public WindDetails WindGust { get; }
        /// <summary> Relative humidity is the amount of water vapor present in air expressed as a percentage of the amount needed for saturation at the same temperature. </summary>
        public int? RelativeHumidity { get; }
        /// <summary> Visibility in specified unit. A measure of the distance at which an object or light can be clearly discerned. </summary>
        public WeatherValue Visibility { get; }
        /// <summary> Cloud ceiling in specified unit. The ceiling is a measurement of the height of the base of the lowest clouds. </summary>
        public WeatherValue CloudCeiling { get; }
        /// <summary>
        /// Measure of the strength of the ultraviolet radiation from the sun. Supported values are:
        ///   * `0-2` - Low danger from the sun's UV rays or the average person.
        ///   * `3-5` - Moderate risk of harm from unprotected sun exposure.
        ///   * `6-7` - High risk of harm from unprotected sun exposure.
        ///   * `8-10` - Very high risk of harm from unprotected sun exposure.
        ///   * `11+` - Extreme risk of harm from unprotected sun exposure.
        /// </summary>
        public int? UvIndex { get; }
        /// <summary> Phrase associated with the `uvIndex`. </summary>
        public string UvIndexDescription { get; }
        /// <summary> Percent representing the probability of precipitation. For example, '20'. </summary>
        public int? PrecipitationProbability { get; }
        /// <summary> Percent representing the probability of rain. For example, '50'. </summary>
        public int? RainProbability { get; }
        /// <summary> Percent representing the probability of snow. For example, '50'. </summary>
        public int? SnowProbability { get; }
        /// <summary> Percent representing the probability of snow. For example, '5'. </summary>
        public int? IceProbability { get; }
        /// <summary> Total liquid equivalent of precipitation during the forecast period. </summary>
        public WeatherValue TotalLiquid { get; }
        /// <summary> Rain. </summary>
        public WeatherValue Rain { get; }
        /// <summary> Snow. </summary>
        public WeatherValue Snow { get; }
        /// <summary> Ice. </summary>
        public WeatherValue Ice { get; }
        /// <summary> Percent representing cloud cover. </summary>
        public int? CloudCover { get; }
    }
}
