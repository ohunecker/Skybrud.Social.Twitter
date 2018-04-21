using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {
    
    /// <summary>
    /// Class representing a bounding box as returned by the Twitter API.
    /// </summary>
    public class TwitterBoundingBox : TwitterObject {

        #region Properties

        /// <summary>
        /// The type of the bounding box.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// The set of coordinates describing the bounding box.
        /// </summary>
        public TwitterCoordinates[][] Coordinates { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterBoundingBox"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterBoundingBox(JObject obj) : base(obj) {

            // Get the array
            JArray coordinates = obj.GetArray("coordinates");

            // Initialize properties
            Type = obj.GetString("type");
            Coordinates = new TwitterCoordinates[coordinates.Count][];

            // Parse the coordinates
            for (int i = 0; i < coordinates.Count; i++) {
                Coordinates[i] = TwitterCoordinates.ParseMultiple(coordinates.GetArray(i));
            }

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterBoundingBox"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterBoundingBox"/>.</returns>
        public static TwitterBoundingBox Parse(JObject obj) {
            return obj == null ? null : new TwitterBoundingBox(obj);
        }

        #endregion

    }

}