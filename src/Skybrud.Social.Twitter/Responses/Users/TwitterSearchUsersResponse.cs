using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Users;

namespace Skybrud.Social.Twitter.Responses {

    public class TwitterSearchUsersResponse : TwitterResponse<TwitterUser[]> {

        #region Constructors

        private TwitterSearchUsersResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonArray(response.Body, TwitterUser.Parse);

        }

        #endregion

        #region Static methods

        public static TwitterSearchUsersResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new TwitterSearchUsersResponse(response);
        }

        #endregion

    }

}