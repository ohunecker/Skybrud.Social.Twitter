using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Twitter.Exceptions {

    /// <summary>
    /// Exception class representing an error received from the Twitter API.
    /// </summary>
    public class TwitterHttpException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>.
        /// </summary>
        public SocialHttpResponse Response { get; }

        /// <summary>
        /// Gets the error code received from the Twitter API. Not all errors have an error code.
        /// </summary>
        public int Code { get; }

        #endregion

        #region Constructors

        internal TwitterHttpException(SocialHttpResponse response, string message) : base(message) {
            Response = response;
        }

        internal TwitterHttpException(SocialHttpResponse response, string message, int code) : base(message) {
            Response = response;
            Code = code;
        }

        #endregion

    }

}