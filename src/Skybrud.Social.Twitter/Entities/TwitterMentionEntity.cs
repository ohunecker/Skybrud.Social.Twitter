using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Entities {

    /// <summary>
    /// Class representing an entity reference to another Twitter user.
    /// </summary>
    public class TwitterMentionEntity : TwitterBaseEntity {

        #region Properties

        /// <summary>
        /// Gets the Twitter user ID of the referenced user.
        /// </summary>
        public long UserId { get; private set; }
        
        /// <summary>
        /// Gets the Twitter user ID (as a string) of the referenced user.
        /// </summary>
        public string UserIdStr { get; private set; }
        
        /// <summary>
        /// Gets the screen name of the referenced user.
        /// </summary>
        public string ScreenName { get; private set; }

        /// <summary>
        /// Gets the display name of the referenced user.
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterMentionEntity"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterMentionEntity(JObject obj) : base(obj) {
            UserId = obj.GetInt64("id");
            UserIdStr = obj.GetString("id_str");
            ScreenName = obj.GetString("screen_name");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterMentionEntity"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterMentionEntity"/>.</returns>
        public static TwitterMentionEntity Parse(JObject obj) {
            return obj == null ? null : new TwitterMentionEntity(obj);
        }

        #endregion

    }

}