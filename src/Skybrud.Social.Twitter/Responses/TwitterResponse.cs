using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Http;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Exceptions;
using Skybrud.Social.Twitter.Objects.Common;

namespace Skybrud.Social.Twitter.Responses {

    /// <summary>
    /// Class representing a response from the Twitter API.
    /// </summary>
    public class TwitterResponse : SocialResponse {

        #region Properties

        /// <summary>
        /// Gets information about rate limiting.
        /// </summary>
        public TwitterRateLimiting RateLimiting { get; private set; }

        #endregion

        #region Constructors

        protected TwitterResponse(SocialHttpResponse response) : base(response) {
            RateLimiting = TwitterRateLimiting.GetFromResponse(response);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            JObject obj = ParseJsonObject(response.Body);

            // For some types of errors, Twitter will only respond with an error message
            if (obj.HasValue("error")) {
                throw new TwitterHttpException(response, obj.GetString("error"), 0);
            }

            // However in most cases, Twitter responds with an array of errors
            JArray errors = obj.GetArray("errors");

            // Get the first error (don't remember ever seeing multiple errors in the same response)
            JObject error = errors.GetObject(0);

            // Throw the exception
            throw new TwitterHttpException(response, error.GetString("message"), error.GetInt32("code"));

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Twitter API.
    /// </summary>
    public class TwitterResponse<T> : TwitterResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        protected TwitterResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }

}