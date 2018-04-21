using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Models.Users;

namespace Skybrud.Social.Twitter.Entities {

    /// <summary>
    /// Class representing the entities of a Twitter user.
    /// </summary>
    public class TwitterUserEntities {

        #region Properties

        /// <summary>
        /// Gets a collection of entities used within the <see cref="TwitterUser.Url"/> property.
        /// </summary>
        public TwitterUserUrlEntities Url { get; }

        /// <summary>
        /// Gets a collection of entities used within the <see cref="TwitterUser.Description"/> property.
        /// </summary>
        public TwitterUserDescriptionEntities Description { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterUserEntities"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterUserEntities(JObject obj) {
            Url = obj.GetObject("url", TwitterUserUrlEntities.Parse);
            Description = obj.GetObject("description", TwitterUserDescriptionEntities.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterUserEntities"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        public static TwitterUserEntities Parse(JObject obj) {
            return obj == null ? null : new TwitterUserEntities(obj);
        }

        #endregion

    }

}