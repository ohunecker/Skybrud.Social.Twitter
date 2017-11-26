namespace Skybrud.Social.Twitter.Options.Statuses {
    
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-home_timeline</cref>
    /// </see>
    public class TwitterGetHomeTimelineOptions : TwitterTimelineOptions {
        
        #region Constructors
        public TwitterGetHomeTimelineOptions() {
            IncludeRetweets = true;
        }

        public TwitterGetHomeTimelineOptions(int count) {
            Count = count;
            IncludeRetweets = true;
        }

        #endregion

    }

}