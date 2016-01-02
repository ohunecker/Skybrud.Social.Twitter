using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Twitter.Objects.Geocode {
    
    public class TwitterReverseGeocodeResult : TwitterObject {

        #region Properties

        public TwitterReverseGeocodeResults Results { get; private set; }
        
        public TwitterPlace[] Places { get; private set; }

        #endregion

        #region Constructors

        private TwitterReverseGeocodeResult(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static TwitterReverseGeocodeResult Parse(TwitterReverseGeocodeResults results, JObject obj) {
            return new TwitterReverseGeocodeResult(obj) {
                Results = results,
                Places = obj.GetArray("places", TwitterPlace.Parse)
            };
        }

        #endregion

    }

}