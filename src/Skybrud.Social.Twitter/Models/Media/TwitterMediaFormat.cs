using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Media {
    
    /// <summary>
    /// Class representing a resized format of a given media.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#size</cref>
    /// </see>
    public class TwitterMediaFormat : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the alias of the format.
        /// </summary>
        public string Alias { get; }

        /// <summary>
        /// Gets the width of the format.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height of the size.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the resize mode of the size.
        /// </summary>
        public string Resize { get; }

        #endregion

        #region Constructors

        private TwitterMediaFormat(JObject obj) : base(obj) {
            JProperty property = obj.Parent as JProperty;
            Alias = property?.Name;
            Width = obj.GetInt32("w");
            Height = obj.GetInt32("h");
            Resize = obj.GetString("resize");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterMediaFormat"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterMediaFormat"/>.</returns>
        public static TwitterMediaFormat Parse(JObject obj) {
            return obj == null ? null : new TwitterMediaFormat(obj);
        }

        #endregion

    }

}