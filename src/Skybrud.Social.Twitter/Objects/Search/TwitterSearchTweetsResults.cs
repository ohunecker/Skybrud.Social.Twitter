using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Objects.Search {

    public class TwitterSearchTweetsResults : TwitterObject {

        #region Properties

        public TwitterStatusMessage[] Statuses { get; private set; }
        
        public TwitterSearchTweetsMetaData MetaData { get; private set; }

        #endregion

        #region Constructors

        public TwitterSearchTweetsResults(JObject obj) : base(obj) {
            Statuses = obj.GetArray("statuses", TwitterStatusMessage.Parse);
            MetaData = obj.GetObject("search_metadata", TwitterSearchTweetsMetaData.Parse);
        }

        #endregion

        #region Static methods

        public static TwitterSearchTweetsResults Parse(JObject obj) {
            return obj == null ? null : new TwitterSearchTweetsResults(obj);
        }

        #endregion

    }

}