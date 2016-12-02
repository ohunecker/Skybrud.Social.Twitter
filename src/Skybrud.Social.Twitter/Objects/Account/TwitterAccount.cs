using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Objects.Users;

namespace Skybrud.Social.Twitter.Objects.Account {
    
    /// <see>
    ///     <cref>https://dev.twitter.com/docs/platform-objects/users</cref>
    /// </see>
    /// <see>
    ///     <cref>https://dev.twitter.com/rest/reference/get/account/verify_credentials</cref>
    /// </see>
    public class TwitterAccount : TwitterUser {

        #region Properties

        /// <summary>
        /// Gets the email address of the authenticated user. Use the <see cref="HasEmail"/> property to check whether
        /// an email address was specified in the response.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets whether an email address was specified in the response.
        /// </summary>
        public bool HasEmail {
            get { return !String.IsNullOrEmpty(Email); }
        }

        #endregion

        #region Constructors

        protected TwitterAccount(JObject obj) : base(obj) {
            Email = obj.GetString("email");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterAccount"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="TwitterAccount"/>.</returns>
        public static new TwitterAccount Parse(JObject obj) {
            return obj == null ? null : new TwitterAccount(obj);
        }

        #endregion

    }

}