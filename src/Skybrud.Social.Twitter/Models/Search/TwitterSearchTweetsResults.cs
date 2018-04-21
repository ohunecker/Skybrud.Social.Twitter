using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Models.Statuses;

namespace Skybrud.Social.Twitter.Models.Search {

    public class TwitterSearchTweetsResults : TwitterObject {

        #region Properties

        public TwitterStatusMessage[] Statuses { get; }
        
        public TwitterSearchTweetsMetaData MetaData { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterSearchTweetsResults"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterSearchTweetsResults(JObject obj) : base(obj) {
            Statuses = obj.GetArray("statuses", TwitterStatusMessage.Parse);
            MetaData = obj.GetObject("search_metadata", TwitterSearchTweetsMetaData.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterSearchTweetsResults"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterSearchTweetsResults"/>.</returns>
        public static TwitterSearchTweetsResults Parse(JObject obj) {
            return obj == null ? null : new TwitterSearchTweetsResults(obj);
        }

        #endregion

    }

}