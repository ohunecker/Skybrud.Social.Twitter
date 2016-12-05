using Skybrud.Social.Http;
using Skybrud.Social.Twitter.OAuth;
using Skybrud.Social.Twitter.Options;

namespace Skybrud.Social.Twitter.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the followers endpoint.
    /// </summary>
    public class TwitterFollowersRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth 1.0a client.
        /// </summary>
        public TwitterOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal TwitterFollowersRawEndpoint(TwitterOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Membmer methods

        /// <summary>
        /// Gets a list of IDs representing the followers of a given user.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/ids</cref>
        /// </see>
        public SocialHttpResponse GetIds(long userId) {
            return GetIds(new TwitterFollowersIdsOptions {
                UserId = userId
            });
        }

        /// <summary>
        /// Gets a list of IDs representing the followers of a given user.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/ids</cref>
        /// </see>
        public SocialHttpResponse GetIds(string screenName) {
            return GetIds(new TwitterFollowersIdsOptions {
                ScreenName = screenName
            });
        }

        /// <summary>
        /// Gets a list of IDs representing the followers of a given user.
        /// </summary>
        /// <param name="options">The options for the call.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/ids</cref>
        /// </see>
        public SocialHttpResponse GetIds(TwitterFollowersIdsOptions options) {
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/ids.json", options);
        }

        /// <summary>
        /// Gets a list of followers for a given user using the default options.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/list</cref>
        /// </see>
        public SocialHttpResponse GetList(long userId) {
            return GetList(new TwitterFollowersListOptions {
                UserId = userId
            });
        }

        /// <summary>
        /// Gets a list of followers for a given user using the default options.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/list</cref>
        /// </see>
        public SocialHttpResponse GetList(string screenName) {
            return GetList(new TwitterFollowersListOptions {
                ScreenName = screenName
            });
        }

        /// <summary>
        /// Gets a list of followers for a given user using the specified options.
        /// </summary>
        /// <param name="options">The options for the call.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/list</cref>
        /// </see>
        public SocialHttpResponse GetList(TwitterFollowersListOptions options) {
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/list.json", options);
        }

        #endregion

    }

}