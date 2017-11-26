using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Search;

namespace Skybrud.Social.Twitter.Responses {

    public class TwitterSearchTweetsResponse : TwitterResponse<TwitterSearchTweetsResults> {

        #region Constructors

        private TwitterSearchTweetsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        public static TwitterSearchTweetsResponse ParseResponse(SocialHttpResponse response) {

            // Some input validation
            if (response == null) throw new ArgumentNullException("response");

            // Validate the response
            ValidateResponse(response);

            // Initialize the response object
            return new TwitterSearchTweetsResponse(response) {
                Body = ParseJsonObject(response.Body, TwitterSearchTweetsResults.Parse)
            };

        }

        #endregion

    }

}