using Skybrud.Social.Twitter.Models;

namespace Skybrud.Social.Twitter.Enums {
    
    /// <summary>
    /// Indicates the tweet mode of requests made to the the Twitter API. 
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/tweet-updates#overview</cref>
    /// </see>
    public enum TwitterTweetMode {

        /// <summary>
        /// Indicates that tweets should be returned for compatibility. This primary means that
        /// <see cref="TwitterStatusMessage.Text"/> only contains the 140 first characters of the tweet, and
        /// <see cref="TwitterStatusMessage.Entities"/> only matches those mentioned in
        /// <see cref="TwitterStatusMessage.Text"/>. 
        /// </summary>
        Compatibility,

        /// <summary>
        /// Indicates that the tweet payload should contain all information to render Tweets that contain more than 140
        /// characters.
        /// </summary>
        Extended

    }

}