using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;
using Skybrud.Social.Twitter.Enums;

namespace Skybrud.Social.Twitter.Objects.Geocode {
    
    public class TwitterReverseGeocodeParameters : TwitterObject {

        #region Properties

        public TwitterReverseGeocodeQuery Query { get; private set; }

        public int Accuracy { get; private set; }

        public TwitterGranularity Granularity { get; private set; }

        public TwitterCoordinates Coordinates { get; private set; }

        #endregion

        #region Constructors

        private TwitterReverseGeocodeParameters(TwitterReverseGeocodeQuery query, JObject obj) : base(obj) {
            Query = query;
            Accuracy = obj.GetInt32("accuracy");
            Granularity = obj.GetString("granularity", TwitterUtils.ParseGranularity);
            Coordinates = obj.GetObject("coordinates", TwitterCoordinates.Parse);
        }

        #endregion

        #region Static methods

        public static TwitterReverseGeocodeParameters Parse(TwitterReverseGeocodeQuery query, JObject obj) {
            return obj == null ? null : new TwitterReverseGeocodeParameters(query, obj);
        }

        #endregion

    }

}