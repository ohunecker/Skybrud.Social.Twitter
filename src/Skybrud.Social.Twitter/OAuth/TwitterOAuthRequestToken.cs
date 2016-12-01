using System.Collections.Specialized;
using Skybrud.Social.OAuth;
using Skybrud.Social.OAuth.Objects;

namespace Skybrud.Social.Twitter.OAuth {

    public class TwitterOAuthRequestToken : SocialOAuthRequestToken {

        #region Constructors

        protected TwitterOAuthRequestToken(SocialOAuthClient client, NameValueCollection query) : base(client, query) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="str">The query string.</param>
        public new static SocialOAuthRequestToken Parse(SocialOAuthClient client, string str) {

            // Convert the query string to a NameValueCollection
            NameValueCollection query = SocialUtils.Misc.ParseQueryString(str);

            // Initialize a new instance
            return new TwitterOAuthRequestToken(client, query);

        }

        /// <summary>
        /// Parses a query string received from the API.
        /// </summary>
        /// <param name="client">The parent OAuth client.</param>
        /// <param name="query">The query string.</param>
        public new static SocialOAuthRequestToken Parse(SocialOAuthClient client, NameValueCollection query) {
            return query == null ? null : new TwitterOAuthRequestToken(client, query);
        }

        #endregion
    
    }

}