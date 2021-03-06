using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Users;

namespace Skybrud.Social.Twitter.Responses.Users {

    /// <summary>
    /// Class representing the response of a request to the Twitter API for getting information about a Twitter user.
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
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="TwitterGetUserResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="TwitterGetUserResponse"/> representing the response.</returns>
        public static TwitterGetUserResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new TwitterGetUserResponse(response);
        }

        #endregion

    }

}