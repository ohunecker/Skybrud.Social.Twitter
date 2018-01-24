using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Users;

namespace Skybrud.Social.Twitter.Responses.Users {

    public class TwitterUserListResponse : TwitterResponse<TwitterUserCollection> {

        #region Constructors

        private TwitterUserListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, TwitterUserCollection.Parse);

        }

        #endregion

        #region Static methods

        public static TwitterUserListResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new TwitterUserListResponse(response);
        }

        #endregion

    }

}