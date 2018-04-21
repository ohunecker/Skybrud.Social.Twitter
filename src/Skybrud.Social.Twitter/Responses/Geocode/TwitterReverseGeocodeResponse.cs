using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.Models.Geocode;

namespace Skybrud.Social.Twitter.Responses.Geocode {

    /// <summary>
    /// Class representing the response of a request to the Twitter API for doing a reverse geocode search.
    /// </summary>
    public class TwitterReverseGeocodeResponse : TwitterResponse<TwitterReverseGeocodeResults> {

        #region Constructors

        private TwitterReverseGeocodeResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, TwitterReverseGeocodeResults.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="TwitterReverseGeocodeResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="TwitterReverseGeocodeResponse"/> representing the response.</returns>
        public static TwitterReverseGeocodeResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new TwitterReverseGeocodeResponse(response);
        }

        #endregion

    }

}