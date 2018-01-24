using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Lists;

namespace Skybrud.Social.Twitter.Responses.Lists {
    
    /// <summary>
    /// Class respresenting the response for a created list.
    /// </summary>
    public class TwitterDeleteListResponse : TwitterResponse<TwitterList> {

        #region Constructors

        private TwitterDeleteListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, TwitterList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="TwitterDeleteListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="TwitterDeleteListResponse"/> representing the response.</returns>
        public static TwitterDeleteListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new TwitterDeleteListResponse(response);
        }

        #endregion

    }

}