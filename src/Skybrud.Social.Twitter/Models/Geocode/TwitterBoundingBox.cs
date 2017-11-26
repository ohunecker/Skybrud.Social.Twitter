using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {
    
    public class TwitterBoundingBox : TwitterObject {

        #region Properties

        /// <summary>
        /// The type of the bounding box.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// The set of coordinates describing the bounding box.
        /// </summary>
        public TwitterCoordinates[][] Coordinates { get; private set; }

        #endregion

        #region Constructors

        private TwitterBoundingBox(JObject obj) : base(obj) {

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

        public static TwitterBoundingBox Parse(JObject obj) {
            return obj == null ? null : new TwitterBoundingBox(obj);
        }

        #endregion

    }

}