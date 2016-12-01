using System;
using System.Collections.Specialized;
using Skybrud.Social.OAuth;
using Skybrud.Social.OAuth.Objects;

namespace Skybrud.Social.Twitter.OAuth {

    public class TwitterOAuthAccessToken : SocialOAuthAccessToken {

        #region Properties

        public long UserId { get; private set; }

        public string ScreenName { get; private set; }

        #endregion

        #region Constructors

        protected TwitterOAuthAccessToken(SocialOAuthClient client, NameValueCollection query) : base(client, query) {
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

            // Convert the query string to a NameValueCollection
            NameValueCollection query = SocialUtils.Misc.ParseQueryString(str);

            // Initialize a new instance
            return new TwitterOAuthAccessToken(client, query);

        }

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="query">The query string.</param>
        public new static TwitterOAuthAccessToken Parse(SocialOAuthClient client, NameValueCollection query) {
            return query == null ? null : new TwitterOAuthAccessToken(client, query);
        }

        #endregion
    
    }

}