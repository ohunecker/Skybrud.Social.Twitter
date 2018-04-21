using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Geocode {
    
    public class TwitterReverseGeocodeResults : TwitterObject {

        #region Properties

        public TwitterReverseGeocodeResult Result { get; private set; }

        public TwitterReverseGeocodeQuery Query { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterReverseGeocodeResults"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterReverseGeocodeResults(JObject obj) : base(obj) {
            Result = obj.GetObject("result", x => TwitterReverseGeocodeResult.Parse(this, x));
            Query = obj.GetObject("query", x => TwitterReverseGeocodeQuery.Parse(this, x));
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterReverseGeocodeResults"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterReverseGeocodeResults"/>.</returns>
        public static TwitterReverseGeocodeResults Parse(JObject obj) {
            return obj == null ? null : new TwitterReverseGeocodeResults(obj);
        }

        #endregion

    }

}