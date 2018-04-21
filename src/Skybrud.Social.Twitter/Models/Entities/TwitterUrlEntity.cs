using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Entities {
    
    /// <summary>
    /// Class representing an entity reference to an external URL.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#urls</cref>
    /// </see>
    public class TwitterUrlEntity : TwitterBaseEntity {

        #region Properties

        /// <summary>
        /// Gets the shortened URL behind the reference.
        /// 
        /// Eg <c>https://t.co/KBE0ENLPD3</c>.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the expanded (full) URL behind the reference.
        /// 
        /// Eg. <c>https://github.com/abjerner/</c>.
        /// </summary>
        public string ExpandedUrl { get; }

        /// <summary>
        /// Gets the display URL of the reference. Notice that longer URLs may be truncated.
        /// 
        /// Eg. <c>github.com/abjerner/</c> or <c>github.com/abjerner/Skybr…</c>
        /// </summary>
        public string DisplayUrl { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterUrlEntity"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterUrlEntity(JObject obj) : base(obj) {
            Url = obj.GetString("url");
            ExpandedUrl = obj.GetString("expanded_url");
            DisplayUrl = obj.GetString("display_url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterUrlEntity"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterUrlEntity"/>.</returns>
        public static TwitterUrlEntity Parse(JObject obj) {
            return obj == null ? null : new TwitterUrlEntity(obj);
        }

        #endregion

    }

}