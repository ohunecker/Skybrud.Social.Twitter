using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {
    
    public class TwitterReverseGeocodeQuery : TwitterObject {

        #region Properties

        public TwitterReverseGeocodeResults Results { get; private set; }

        public string Url { get; private set; }

        public string Type { get; private set; }

        #endregion

        #region Constructors

        protected TwitterReverseGeocodeQuery(TwitterReverseGeocodeResults results, JObject obj) : base(obj) {
            Results = results;
            Url = obj.GetString("url");
            Type = obj.GetString("type");
        }

        #endregion

        #region Static methods

        public static TwitterReverseGeocodeQuery Parse(TwitterReverseGeocodeResults results, JObject obj) {
            return new TwitterReverseGeocodeQuery(results, obj);
        }

        #endregion

    }

}