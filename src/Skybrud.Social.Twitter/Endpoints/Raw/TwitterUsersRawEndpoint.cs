using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.OAuth;
using Skybrud.Social.Twitter.Options.Users;

namespace Skybrud.Social.Twitter.Endpoints.Raw {
    
    public class TwitterUsersRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth 1.0a client.
        /// </summary>
        public TwitterOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal TwitterUsersRawEndpoint(TwitterOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the raw API response for a user with the specified ID. Any entities will not be included in the API response.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <see>
        ///     <cref>https://dev.twitter.com/docs/api/1.1/get/users/show</cref>
        /// </see>
        public SocialHttpResponse GetUser(long userId) {
            return GetUser(new TwitterGetUserOptions(userId));
        }

        /// <summary>
        /// Gets the raw API response for a user with the specified ID. 
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="includeEntities">Whether entities should be included in the API response.</param>
        /// <see>
        ///     <cref>https://dev.twitter.com/docs/api/1.1/get/users/show</cref>
        /// </see>
        public SocialHttpResponse GetUser(long userId, bool includeEntities) {
            return GetUser(new TwitterGetUserOptions(userId, includeEntities));
        }

        /// <summary>
        /// Gets the raw API response for a user with the specified screen name. Any entities will not be included in the API response.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="screenName"/> is not specified.</exception>
        public SocialHttpResponse GetUser(string screenName) {
            if (String.IsNullOrWhiteSpace(screenName)) throw new ArgumentNullException(nameof(screenName));
            return GetUser(new TwitterGetUserOptions(screenName));
        }

        /// <summary>
        /// Gets the raw API response for a user with the specified screen name.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        /// <param name="includeEntities">Whether entities should be included in the API response.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="screenName"/> is not specified.</exception>
        public SocialHttpResponse GetUser(string screenName, bool includeEntities) {
            if (String.IsNullOrWhiteSpace(screenName)) throw new ArgumentNullException(nameof(screenName));
            return GetUser(new TwitterGetUserOptions(screenName, includeEntities));
        }
        
        /// <summary>
        /// Gets the raw API response for a user with matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <exception cref="ArgumentNullException">If <paramref name="options"/> is <code>null</code>.</exception>
        public SocialHttpResponse GetUser(TwitterGetUserOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/users/show.json", options);
        }

        /// <summary>
        /// Provides a simple, relevance-based search interface to public user accounts on Twitter. Try querying by
        /// topical interest, full name, company name, location, or other criteria. Exact match searches are not
        /// supported.
        /// 
        /// Only the first 1,000 matching results are available.
        /// </summary>
        /// <param name="query">The search query to run against people search.</param>
        public SocialHttpResponse Search(string query) {
            return Search(new TwitterSearchUsersOptions {
                Query = query
            });
        }

        /// <summary>
        /// Provides a simple, relevance-based search interface to public user accounts on Twitter. Try querying by
        /// topical interest, full name, company name, location, or other criteria. Exact match searches are not
        /// supported.
        /// 
        /// Only the first 1,000 matching results are available.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse Search(TwitterSearchUsersOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/users/search.json", options);
        }

        #endregion

    }

}