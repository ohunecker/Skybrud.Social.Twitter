using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {
    
    /// <summary>
    /// Class with information about a Twitter place.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/geo-objects#place</cref>
    /// </see>
    public class TwitterPlace : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the place.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the URL for the place in the Twitter API.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the type of the place.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the name of the place.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the full name of the place.
        /// </summary>
        public string FullName { get; }

        /// <summary>
        /// Gets the country code of the place.
        /// </summary>
        public string CountryCode { get; }

        /// <summary>
        /// Gets the country name of the place.
        /// </summary>
        public string Country { get; }

        /// <summary>
        /// Gets the bounding box describing the place.
        /// </summary>
        public TwitterBoundingBox BoundingBox { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterPlace"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterPlace(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Url = obj.GetString("url");
            Type = obj.GetString("place_type");
            Name = obj.GetString("name");
            FullName = obj.GetString("full_name");
            CountryCode = obj.GetString("country_code");
            Country = obj.GetString("country");
            BoundingBox = obj.GetObject("bounding_box", TwitterBoundingBox.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterPlace"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterPlace"/>.</returns>
        public static TwitterPlace Parse(JObject obj) {
            return obj == null ? null : new TwitterPlace(obj);
        }

        #endregion

    }

}