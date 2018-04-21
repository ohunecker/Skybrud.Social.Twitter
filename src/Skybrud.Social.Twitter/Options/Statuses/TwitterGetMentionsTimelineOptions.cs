namespace Skybrud.Social.Twitter.Options.Statuses {

    /// <summary>
    /// Class with options for getting the most recent mentions of the authenticated user.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/timelines/api-reference/get-statuses-mentions_timeline</cref>
    /// </see>
    public class TwitterGetMentionsTimelineOptions : TwitterTimelineOptions {

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public TwitterGetMentionsTimelineOptions() {
            IncludeRetweets = true;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="count"/>.
        /// </summary>
        /// <param name="count">The maximum amount of tweets to include per page.</param>
        public TwitterGetMentionsTimelineOptions(int count) {
            Count = count;
            IncludeRetweets = true;
        }

        #endregion

    }

}