using Skybrud.Social.Twitter.Endpoints.Raw;
using Skybrud.Social.Twitter.Options;
using Skybrud.Social.Twitter.Responses;
using Skybrud.Social.Twitter.Responses.Users;

namespace Skybrud.Social.Twitter.Endpoints {

    public class TwitterUsersEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Twitter service.
        /// </summary>
        public TwitterService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw users endpoint.
        /// </summary>
        public TwitterUsersRawEndpoint Raw {
            get { return Service.Client.Users; }
        }

        #endregion

        #region Constructors

        internal TwitterUsersEndpoint(TwitterService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        public TwitterGetUserResponse Show(long userId) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(userId, false));
        }

        public TwitterGetUserResponse Show(long userId, bool includeEntities) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(userId, includeEntities));
        }

        public TwitterGetUserResponse Show(string screenName) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(screenName, false));
        }

        public TwitterGetUserResponse Show(string screenName, bool includeEntities) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(screenName, includeEntities));
        }

        /// <summary>
        /// Alias of <code>Show</code>.
        /// </summary>
        public TwitterGetUserResponse GetUser(long userId) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(userId, false));
        }

        /// <summary>
        /// Alias of <code>Show</code>.
        /// </summary>
        public TwitterGetUserResponse GetUser(long userId, bool includeEntities) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(userId, includeEntities));
        }

        /// <summary>
        /// Alias of <code>Show</code>.
        /// </summary>
        public TwitterGetUserResponse GetUser(string screenName) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(screenName, false));
        }

        /// <summary>
        /// Alias of <code>Show</code>.
        /// </summary>
        public TwitterGetUserResponse GetUser(string screenName, bool includeEntities) {
            return TwitterGetUserResponse.ParseResponse(Raw.GetUser(screenName, includeEntities));
        }
        
        /// <summary>
        /// Provides a simple, relevance-based search interface to public user
        /// accounts on Twitter. Try querying by topical interest, full name,
        /// company name, location, or other criteria. Exact match searches are
        /// not supported.
        /// </summary>
        /// <param name="query">The search query to run against people search.</param>
        public TwitterUsersSearchResponse Search(string query) {
            return Search(new TwitterUsersSearchOptions {
                Query = query
            });
        }

        /// <summary>
        /// Provides a simple, relevance-based search interface to public user
        /// accounts on Twitter. Try querying by topical interest, full name,
        /// company name, location, or other criteria. Exact match searches are
        /// not supported.
        /// </summary>
        /// <param name="options">The search options.</param>
        public TwitterUsersSearchResponse Search(TwitterUsersSearchOptions options) {
            return TwitterUsersSearchResponse.ParseResponse(Raw.Search(options));
        }

        #endregion

    }

}