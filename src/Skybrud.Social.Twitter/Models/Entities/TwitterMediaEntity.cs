using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Models.Media;

namespace Skybrud.Social.Twitter.Models.Entities {
    
    /// <summary>
    /// Class representing an entity reference to an image or video.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#media</cref>
    /// </see>
    public class TwitterMediaEntity : TwitterBaseEntity {

        #region Properties

        /// <summary>
        /// Gets the Twitter ID of the media.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Gets the Twitter ID (as a string) of the media.
        /// </summary>
        public string IdStr { get; }
        
        /// <summary>
        /// Gets the HTTP URL of the media. 
        /// </summary>
        public string MediaUrl { get; }

        /// <summary>
        /// Gets the HTTPS URL of the media. 
        /// </summary>
        public string MediaUrlHttps { get; }
        
        /// <summary>
        /// Gets the shortened URL of the media.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the display URL of the reference. Notice that longer URLs may be truncated.
        /// </summary>
        public string DisplayUrl { get; }

        /// <summary>
        /// Gets the expanded (full) URL behind the reference.
        /// </summary>
        public string ExpandedUrl { get; }

        /// <summary>
        /// Gets the type of the media.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets an object with references to the resized formats of the media.
        /// </summary>
        public TwitterMediaSizes Sizes { get; }

        /// <summary>
        /// Gets an object with video information if the media is a video, otherwise <c>null</c>.
        /// </summary>
        public TwitterVideoInfo VideoInfo { get; }

        /// <summary>
        /// Gets whether the media entity has any video information.
        /// </summary>
        public bool HasVideoInfo => VideoInfo != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterMediaEntity"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterMediaEntity(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            IdStr = obj.GetString("id_str");
            MediaUrl = obj.GetString("media_url");
            MediaUrlHttps = obj.GetString("media_url_https");
            Url = obj.GetString("url");
            DisplayUrl = obj.GetString("display_url");
            ExpandedUrl = obj.GetString("expanded_url");
            Type = obj.GetString("type");
            Sizes = obj.GetObject("sizes", TwitterMediaSizes.Parse);
            VideoInfo = obj.GetObject("video_info", TwitterVideoInfo.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterMediaEntity"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterMediaEntity"/>.</returns>
        public static TwitterMediaEntity Parse(JObject obj) {
            return obj == null ? null : new TwitterMediaEntity(obj);
        }

        #endregion

    }

}