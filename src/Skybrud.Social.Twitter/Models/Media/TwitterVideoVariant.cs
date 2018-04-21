using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Media {
    
    /// <summary>
    /// Class representing a format of a Twitter video.
    /// </summary>
    public class TwitterVideoVariant : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the bitrate of the video, or <c>0</c> if not specified.
        /// </summary>
        public int Bitrate { get; }

        /// <summary>
        /// Gets whether a bitrate has been specified for the format.
        /// </summary>
        public bool HasBitrate => Bitrate > 0;

        /// <summary>
        /// Gets the content type of the format.
        /// </summary>
        public string ContentType { get; }

        /// <summary>
        /// Gets the URL of the format.
        /// </summary>
        public string Url { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterVideoVariant"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterVideoVariant(JObject obj) : base(obj) {
            Bitrate = obj.GetInt32("bitrate");
            ContentType = obj.GetString("content_type");
            Url = obj.GetString("url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterVideoVariant"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterVideoVariant"/>.</returns>
        public static TwitterVideoVariant Parse(JObject obj) {
            return obj == null ? null : new TwitterVideoVariant(obj);
        }

        #endregion

    }

}