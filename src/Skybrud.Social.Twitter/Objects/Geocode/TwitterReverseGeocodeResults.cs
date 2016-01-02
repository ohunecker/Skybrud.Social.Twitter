using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Twitter.Objects.Geocode {
    
    public class TwitterReverseGeocodeResults : TwitterObject {

        #region Properties

        public TwitterReverseGeocodeResult Result { get; private set; }

        public TwitterReverseGeocodeQuery Query { get; private set; }

        #endregion

        #region Constructors

        private TwitterReverseGeocodeResults(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static TwitterReverseGeocodeResults Parse(JObject obj) {
            if (obj == null) return null;
            TwitterReverseGeocodeResults results = new TwitterReverseGeocodeResults(obj);
            results.Result = obj.GetObject("result", x => TwitterReverseGeocodeResult.Parse(results, x));
            results.Query = obj.GetObject("query", x => TwitterReverseGeocodeQuery.Parse(results, x));
            return results;
        }

        #endregion

    }

}