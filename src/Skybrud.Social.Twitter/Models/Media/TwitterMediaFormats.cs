using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Models.Media {
   
    /// <summary>
    /// Class representing a collection of formats of a given media.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/tweets/data-dictionary/overview/entities-object#media-size</cref>
    /// </see>
    public class TwitterMediaFormats : TwitterObject, IEnumerable<TwitterMediaFormat> {

        private readonly TwitterMediaFormat[] _all;

        #region Properties

        /// <summary>
        /// Gets a reference to the <c>small</c> media format.
        /// </summary>
        public TwitterMediaFormat Small { get; }
        
        /// <summary>
        /// Gets a reference to the <c>thumb</c> media format.
        /// </summary>
        public TwitterMediaFormat Thumb { get; }
        
        /// <summary>
        /// Gets a reference to the <c>medium</c> media format.
        /// </summary>
        public TwitterMediaFormat Medium { get; }
        
        /// <summary>
        /// Gets a reference to the <c>large</c> media format.
        /// </summary>
        public TwitterMediaFormat Large { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterMediaFormats"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterMediaFormats(JObject obj) : base(obj) {
            Small = obj.GetObject("small", TwitterMediaFormat.Parse);
            Thumb = obj.GetObject("thumb", TwitterMediaFormat.Parse);
            Medium = obj.GetObject("medium", TwitterMediaFormat.Parse);
            Large = obj.GetObject("large", TwitterMediaFormat.Parse);
            _all = new[] {Small, Thumb, Medium, Large};
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IEnumerator{TwitterMediaFormat}"/> for iterating through the sizez of the media.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<TwitterMediaFormat> GetEnumerator() {
            return ((IEnumerable<TwitterMediaFormat>) _all).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="TwitterMediaFormats"/> from the specified <see cref="JObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="TwitterMediaFormats"/>.</returns>
        public static TwitterMediaFormats Parse(JObject obj) {
            return obj == null ? null : new TwitterMediaFormats(obj);
        }

        #endregion

    }

}