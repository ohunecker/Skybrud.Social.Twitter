using Skybrud.Essentials.Strings;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Twitter.Options.Statuses {

    public class TwitterGetStatusMessageOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the status message to be found.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// When set to <code>true</code>, each tweet returned in a timeline will include a user object
        /// including only the status authors numerical ID. Omit this parameter to receive
        /// the complete user object.
        /// </summary>
        public bool TrimUser { get; set; }

        /// <summary>
        /// When set to <code>true</code>, any Tweets returned that have been retweeted by the
        /// authenticating user will include an additional <code>current_user_retweet</code>
        /// node, containing the ID of the source status for the retweet.
        /// </summary>
        public bool IncludeMyRetweet { get; set; }

        /// <summary>
        /// The entities node will be disincluded when set to <code>false</code>.
        /// </summary>
        public bool IncludeEntities { get; set; }

        /// <summary>
        /// Gets or sets the tweet mode, qhich determines the JSON payload of each tweet. Default is <see cref="TwitterTweetMode.Compatibility"/>.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/tweets/tweet-updates#overview</cref>
        /// </see>
        public TwitterTweetMode TweetMode { get; set; }

        #endregion

        #region Constructors

        public TwitterGetStatusMessageOptions() { }

        public TwitterGetStatusMessageOptions(long statusId) {
            Id = statusId;
        }

        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {
            SocialHttpQueryString query = new SocialHttpQueryString();
            query.Set("id", Id);
            if (TrimUser) query.Add("trim_user", "true");
            if (IncludeMyRetweet) query.Add("include_my_retweet", "true");
            if (IncludeEntities) query.Add("include_entities", "true");
            if (TweetMode != TwitterTweetMode.Compatibility) query.Add("tweet_mode", StringUtils.ToCamelCase(TweetMode));
            return query;
        }

        #endregion

    }

}