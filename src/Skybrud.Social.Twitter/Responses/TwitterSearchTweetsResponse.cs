using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Search;

namespace Skybrud.Social.Twitter.Responses {

    public class TwitterSearchTweetsResponse : TwitterResponse<TwitterSearchTweetsResults> {

        #region Constructors

        private TwitterSearchTweetsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, TwitterSearchTweetsResults.Parse);

        }

        #endregion

        #region Static methods

        public static TwitterSearchTweetsResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new TwitterSearchTweetsResponse(response);
        }

        #endregion

    }

}