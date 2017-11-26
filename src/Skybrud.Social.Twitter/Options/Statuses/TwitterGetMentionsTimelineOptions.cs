namespace Skybrud.Social.Twitter.Options.Statuses {
    
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-mentions_timeline</cref>
    /// </see>
    public class TwitterGetMentionsTimelineOptions : TwitterTimelineOptions {
        
        #region Constructors
        public TwitterGetMentionsTimelineOptions() {
            IncludeRetweets = true;
        }

        public TwitterGetMentionsTimelineOptions(int count) {
            Count = count;
            IncludeRetweets = true;
        }

        #endregion

    }

}