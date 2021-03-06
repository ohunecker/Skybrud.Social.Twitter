using Skybrud.Social.Http;
using Skybrud.Social.Twitter.OAuth;
using Skybrud.Social.Twitter.Options;

namespace Skybrud.Social.Twitter.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the <strong>Followers</strong> endpoint.
    /// </summary>
    public class TwitterFollowersRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth 1.0a client.
        /// </summary>
        public TwitterOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal TwitterFollowersRawEndpoint(TwitterOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Membmer methods

        /// <summary>
        /// Gets a list of IDs representing the followers of the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/ids</cref>
        /// </see>
        public SocialHttpResponse GetIds(long userId) {
            return GetIds(new TwitterFollowersIdsOptions(userId));
        }

        /// <summary>
        /// Gets a list of IDs representing the followers of the user with the specified <paramref name="screenName"/>.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/ids</cref>
        /// </see>
        public SocialHttpResponse GetIds(string screenName) {
            return GetIds(new TwitterFollowersIdsOptions(screenName));
        }

        /// <summary>
        /// Gets a list of IDs representing the followers of the user matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/ids</cref>
        /// </see>
        public SocialHttpResponse GetIds(TwitterFollowersIdsOptions options) {
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/ids.json", options);
        }

        /// <summary>
        /// Gets a list of followers of the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/list</cref>
        /// </see>
        public SocialHttpResponse GetList(long userId) {
            return GetList(new TwitterFollowersListOptions(userId));
        }

        /// <summary>
        /// Gets a list of followers of the user with the specified <paramref name="screenName"/>.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/list</cref>
        /// </see>
        public SocialHttpResponse GetList(string screenName) {
            return GetList(new TwitterFollowersListOptions(screenName));
        }

        /// <summary>
        /// Gets a list of followers of the user matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://dev.twitter.com/rest/reference/get/followers/list</cref>
        /// </see>
        public SocialHttpResponse GetList(TwitterFollowersListOptions options) {
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/followers/list.json", options);
        }

        #endregion

    }

}