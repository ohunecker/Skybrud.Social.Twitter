using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;
using Skybrud.Social.OAuth;
using Skybrud.Social.OAuth.Models;

namespace Skybrud.Social.Twitter.OAuth {

    public class TwitterOAuthAccessToken : SocialOAuthAccessToken {

        #region Properties

        /// <summary>
        /// Gets the ID of the authenticating user.
        /// </summary>
        public long UserId { get; }

        /// <summary>
        /// Gets the screen name of the authenticating user.
        /// </summary>
        public string ScreenName { get; }

        #endregion

        #region Constructors

        protected TwitterOAuthAccessToken(SocialOAuthClient client, IHttpQueryString query) : base(client, query) {
            UserId = Int64.Parse(query["user_id"]);
            ScreenName = query["screen_name"];
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="str">The query string.</param>
        public new static TwitterOAuthAccessToken Parse(SocialOAuthClient client, string str) {

            // Convert the query string to an IHttpQueryString
            IHttpQueryString query = SocialHttpQueryString.ParseQueryString(str);

            // Initialize a new instance
            return new TwitterOAuthAccessToken(client, query);

        }

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="query">The query string.</param>
        public static TwitterOAuthAccessToken Parse(SocialOAuthClient client, IHttpQueryString query) {
            return query == null ? null : new TwitterOAuthAccessToken(client, query);
        }

        #endregion
    
    }

}