using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Twitter.Objects.Media {
    
    /// <summary>
    /// Class representing a resized format of a given media.
    /// </summary>
    public class TwitterMediaFormat : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the alias of the format.
        /// </summary>
        public string Alias { get; private set; }

        /// <summary>
        /// Gets the width of the format.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Gets the height of the size.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Gets the resize mode of the size.
        /// </summary>
        public string Resize { get; private set; }

        #endregion

        #region Constructors

        private TwitterMediaFormat(string alias, JObject obj) : base(obj) {
            Alias = alias;
            Width = obj.GetInt32("w");
            Height = obj.GetInt32("h");
            Resize = obj.GetString("resize");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>TwitterMediaFormat</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="alias">The alias of the format.</param>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static TwitterMediaFormat Parse(string alias, JObject obj) {
            return obj == null ? null : new TwitterMediaFormat(alias, obj);
        }

        #endregion

    }

}