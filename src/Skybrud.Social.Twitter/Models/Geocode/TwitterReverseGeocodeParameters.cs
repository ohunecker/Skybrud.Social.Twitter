using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {
    
    /// <summary>
    /// Class with the reverse geocode parameters sent to the Twitter API.
    /// </summary>
    public class TwitterReverseGeocodeParameters : TwitterObject {

        #region Properties

        /// <summary>
        /// The original query sent to the Twitter API.
        /// </summary>
        public TwitterReverseGeocodeQuery Query { get; }

        /// <summary>
        /// The accuracy.
        /// </summary>
        public int Accuracy { get; }

        /// <summary>
        /// The granularity.
        /// </summary>
        public TwitterGranularity Granularity { get; }

        /// <summary>
        /// The coordinnates.
        /// </summary>
        public TwitterCoordinates Coordinates { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterReverseGeocodeParameters"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        private TwitterReverseGeocodeParameters(TwitterReverseGeocodeQuery query, JObject obj) : base(obj) {
            Query = query;
            Accuracy = obj.GetInt32("accuracy");
            Granularity = obj.GetString("granularity", TwitterUtils.ParseGranularity);
            Coordinates = obj.GetObject("coordinates", TwitterCoordinates.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterReverseGeocodeParameters"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterReverseGeocodeParameters"/>.</returns>
        public static TwitterReverseGeocodeParameters Parse(TwitterReverseGeocodeQuery query, JObject obj) {
            return obj == null ? null : new TwitterReverseGeocodeParameters(query, obj);
        }

        #endregion

    }

}