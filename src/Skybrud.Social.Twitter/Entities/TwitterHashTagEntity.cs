using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Entities {

    /// <summary>
    /// Class representing an entity reference to a Twitter hashtag.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#hashtags</cref>
    /// </see>
    public class TwitterHashTagEntity : TwitterBaseEntity {

        #region Properties

        /// <summary>
        /// The name of the hashtag, minus the leading <c>#</c> character.
        /// </summary>
        public string Text { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterHashTagEntity"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterHashTagEntity(JObject obj) : base(obj) {
            Text = obj.GetString("text");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterHashTagEntity"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterHashTagEntity"/>.</returns>
        public static TwitterHashTagEntity Parse(JObject obj) {
            return obj == null ? null : new TwitterHashTagEntity(obj);
        }

        #endregion

    }

}