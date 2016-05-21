using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Twitter.Objects.Media {
    
    /// <summary>
    /// Class representing a format of a Twitter video.
    /// </summary>
    public class TwitterVideoFormat : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the bitrate of the video, or <code>0</code> if not specified.
        /// </summary>
        public int Bitrate { get; private set; }

        /// <summary>
        /// Gets the content type of the format.
        /// </summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// Gets the URL of the format.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// Gets whether a bitrate has been specified for the format.
        /// </summary>
        public bool HasBitrate {
            get { return Bitrate > 0; }
        }

        #endregion

        #region Constructors

        private TwitterVideoFormat(JObject obj) : base(obj) {
            Bitrate = obj.GetInt32("bitrate");
            ContentType = obj.GetString("content_type");
            Url = obj.GetString("url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>TwitterVideoFormat</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static TwitterVideoFormat Parse(JObject obj) {
            return obj == null ? null : new TwitterVideoFormat(obj);
        }

        #endregion

    }

}