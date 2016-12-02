using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Objects.Account;

namespace Skybrud.Social.Twitter.Responses.Account {

    /// <summary>
    /// Class representing the response of a call to get information about the authenticated user
    /// </summary>
    public class TwitterVerifyCredentialsResponse : TwitterResponse<TwitterAccount> {

        #region Constructors

        private TwitterVerifyCredentialsResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, TwitterAccount.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="TwitterVerifyCredentialsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="TwitterVerifyCredentialsResponse"/> representing the response.</returns>
        public static TwitterVerifyCredentialsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new TwitterVerifyCredentialsResponse(response);

        }

        #endregion

    }

}