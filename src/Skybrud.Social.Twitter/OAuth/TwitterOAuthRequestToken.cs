using System.Collections.Specialized;
using Skybrud.Social.OAuth;
using Skybrud.Social.OAuth.Objects;

namespace Skybrud.Social.Twitter.OAuth {
    
    public class TwitterOAuthRequestToken : OAuthRequestToken {

        #region Constructors

        protected TwitterOAuthRequestToken(OAuthClient client, NameValueCollection query) : base(client, query) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="str">The query string.</param>
        public new static OAuthRequestToken Parse(OAuthClient client, string str) {

            // Convert the query string to a NameValueCollection
            NameValueCollection query = SocialUtils.ParseQueryString(str);

            // Initialize a new instance
            return new TwitterOAuthRequestToken(client, query);

        }

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="query">The query string.</param>
        public new static OAuthRequestToken Parse(OAuthClient client, NameValueCollection query) {
            return query == null ? null : new TwitterOAuthRequestToken(client, query);
        }

        #endregion
    
    }

}