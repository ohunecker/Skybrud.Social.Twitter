using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {

    public class TwitterCoordinates : TwitterObject {

        #region Properties

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        #endregion
        
        #region Constructors

        private TwitterCoordinates(JObject obj) : base(obj) {
            Latitude = obj.GetArray("coordinates").GetDouble(1);
            Longitude = obj.GetArray("coordinates").GetDouble(0);
        }

        #endregion

        #region Static methods

        public static TwitterCoordinates Parse(JObject obj) {
            return obj == null ? null : new TwitterCoordinates(obj);
        }

        public static TwitterCoordinates Parse(JArray array) {
            if (array == null) return null;
            return new TwitterCoordinates(null) {
                Latitude = array.GetDouble(1),
                Longitude = array.GetDouble(0)
            };
        }

        public static TwitterCoordinates[] ParseMultiple(JArray array) {
            if (array == null) return new TwitterCoordinates[0];
            TwitterCoordinates[] temp = new TwitterCoordinates[array.Count];
            for (int i = 0; i < array.Count; i++) {
                temp[i] = Parse(array.GetArray(i));
            }
            return temp;
        }

        #endregion

    }

}