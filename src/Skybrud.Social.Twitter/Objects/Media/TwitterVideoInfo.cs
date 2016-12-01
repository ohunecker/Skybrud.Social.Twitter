using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Objects.Media {
    
    /// <summary>
    /// Class representing a resized format of a given media.
    /// </summary>
    public class TwitterVideoInfo : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets a 2-element array with the aspect ratio of the video.
        /// </summary>
        public int[] AspectRatio { get; private set; }

        /// <summary>
        /// Gets the duration of the video. For animated GIFs a duration won't be specified.
        /// </summary>
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// Gets an array of all variants/formats of the video.
        /// </summary>
        public TwitterVideoFormat[] Variants { get; private set; }

        /// <summary>
        /// Gets whether a duration has been specified for the video.
        /// </summary>
        public bool HasDuration {
            get { return Duration.TotalMilliseconds > 0; }
        }

        #endregion

        #region Constructors

        private TwitterVideoInfo(JObject obj) : base(obj) {
            AspectRatio = obj.GetInt32Array("aspect_ratio");
            Duration = obj.GetDouble("duration_millis", TimeSpan.FromMilliseconds);
            Variants = obj.GetArray("variants", TwitterVideoFormat.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>TwitterVideoInfo</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static TwitterVideoInfo Parse(JObject obj) {
            return obj == null ? null : new TwitterVideoInfo(obj);
        }

        #endregion

    }

}