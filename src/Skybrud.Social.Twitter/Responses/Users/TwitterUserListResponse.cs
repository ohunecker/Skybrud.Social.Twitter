using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Users;

namespace Skybrud.Social.Twitter.Responses.Users {

    public class TwitterUserListResponse : TwitterResponse<TwitterUserCollection> {

        #region Constructors

        private TwitterUserListResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        public static TwitterUserListResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new TwitterUserListResponse(response) {
                Body = ParseJsonObject(response.Body, TwitterUserCollection.Parse)
            };

        }

        #endregion

    }

}