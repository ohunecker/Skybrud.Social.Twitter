using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;
using Skybrud.Social.OAuth;
using Skybrud.Social.OAuth.Models;

namespace Skybrud.Social.Twitter.OAuth {

    public class TwitterOAuthRequestToken : SocialOAuthRequestToken {

        #region Constructors

        protected TwitterOAuthRequestToken(SocialOAuthClient client, IHttpQueryString query) : base(client, query) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="str">The query string.</param>
        public new static SocialOAuthRequestToken Parse(SocialOAuthClient client, string str) {

            // Convert the query string to a NameValueCollection
            IHttpQueryString query = SocialHttpQueryString.ParseQueryString(str);

            // Initialize a new instance
            return new TwitterOAuthRequestToken(client, query);

        }

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="query">The query string.</param>
        public static SocialOAuthRequestToken Parse(SocialOAuthClient client, IHttpQueryString query) {
            return query == null ? null : new TwitterOAuthRequestToken(client, query);
        }

        #endregion
    
    }

}