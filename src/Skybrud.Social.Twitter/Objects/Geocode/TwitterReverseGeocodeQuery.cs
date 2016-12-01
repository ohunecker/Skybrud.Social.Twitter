using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Objects.Geocode {
    
    public class TwitterReverseGeocodeQuery : TwitterObject {

        #region Properties

        public TwitterReverseGeocodeResults Results { get; private set; }

        public string Url { get; private set; }

        public string Type { get; private set; }

        #endregion

        #region Constructors

        private TwitterReverseGeocodeQuery(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static TwitterReverseGeocodeQuery Parse(TwitterReverseGeocodeResults results, JObject obj) {
            return new TwitterReverseGeocodeQuery(obj) {
                Results = results,
                Url = obj.GetString("url"),
                Type = obj.GetString("type")
            };
        }

        #endregion

    }

}