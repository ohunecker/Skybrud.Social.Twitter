namespace Skybrud.Social.Twitter.Options.Statuses {
    
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-retweets_of_me</cref>
    /// </see>
    public class TwitterGetRetweetsOfMeTimelineOptions : TwitterTimelineOptions {
        
        #region Constructors
        public TwitterGetRetweetsOfMeTimelineOptions() {
            IncludeRetweets = true;
        }

        public TwitterGetRetweetsOfMeTimelineOptions(int count) {
            Count = count;
            IncludeRetweets = true;
        }

        #endregion

    }

}