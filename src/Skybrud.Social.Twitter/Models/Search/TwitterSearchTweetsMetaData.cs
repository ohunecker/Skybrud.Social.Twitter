using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Search {

    public class TwitterSearchTweetsMetaData : TwitterObject {

        #region Properties

        public float CompletedIn { get; }
        
        public long MaxId { get; }
        
        public string Query { get; }
        
        public string RefreshUrl { get; }
        
        public int Count { get; }
        
        public long SinceId { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterSearchTweetsMetaData"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterSearchTweetsMetaData(JObject obj) : base(obj) {
            CompletedIn = obj.GetFloat("completed_in");
            MaxId = obj.GetInt64("max_id");
            Query = obj.GetString("query");
            RefreshUrl = obj.GetString("refresh_url");
            Count = obj.GetInt32("count");
            SinceId = obj.GetInt64("since_id");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterSearchTweetsMetaData"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterSearchTweetsMetaData"/>.</returns>
        public static TwitterSearchTweetsMetaData Parse(JObject obj) {
            return obj == null ? null : new TwitterSearchTweetsMetaData(obj);
        }

        #endregion

    }

}