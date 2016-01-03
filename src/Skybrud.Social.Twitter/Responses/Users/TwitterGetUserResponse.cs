using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Objects;

namespace Skybrud.Social.Twitter.Responses.Users {

    /// <summary>
    /// Class representing the response of a call to get information about a single Twitter user.
    /// </summary>
    public class TwitterGetUserResponse : TwitterResponse<TwitterUser> {

        #region Constructors

        private TwitterGetUserResponse(SocialHttpResponse response) : base(response) {
            
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, TwitterUser.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>TwitterGetUserResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <code>TwitterGetUserResponse</code> representing the response.</returns>
        public static TwitterGetUserResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Initialize the response object
            return new TwitterGetUserResponse(response);

        }

        #endregion

    }

}