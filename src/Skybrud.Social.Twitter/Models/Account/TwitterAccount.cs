using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Models.Users;

namespace Skybrud.Social.Twitter.Models.Account {

    /// <summary>
    /// Class with information about the authenticated user. Most properties are inherited from the <see cref="TwitterUser"/> class.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/user-object</cref>
    /// </see>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/manage-account-settings/api-reference/get-account-verify_credentials</cref>
    /// </see>
    public class TwitterAccount : TwitterUser {

        #region Properties

        /// <summary>
        /// Gets the email address of the authenticated user. Use the <see cref="HasEmail"/> property to check whether
        /// an email address was specified in the response.
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Gets whether an email address was specified in the response.
        /// </summary>
        public bool HasEmail => !String.IsNullOrEmpty(Email);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterAccount"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterAccount(JObject obj) : base(obj) {
            Email = obj.GetString("email");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterAccount"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterAccount"/>.</returns>
        public new static TwitterAccount Parse(JObject obj) {
            return obj == null ? null : new TwitterAccount(obj);
        }

        #endregion

    }

}