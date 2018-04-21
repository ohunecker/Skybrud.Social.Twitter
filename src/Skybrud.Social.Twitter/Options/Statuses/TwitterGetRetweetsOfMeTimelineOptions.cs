namespace Skybrud.Social.Twitter.Options.Statuses {

    /// <summary>
    /// Class with options for getting tweets of the authenticated user that recently has been retweeted.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/post-and-engage/api-reference/get-statuses-retweets_of_me</cref>
    /// </see>
    public class TwitterGetRetweetsOfMeTimelineOptions : TwitterTimelineOptions {

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public TwitterGetRetweetsOfMeTimelineOptions() {
            IncludeRetweets = true;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="count"/>.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to include per page.</param>
        public TwitterGetRetweetsOfMeTimelineOptions(int count) {
            Count = count;
            IncludeRetweets = true;
        }

        #endregion

    }

}