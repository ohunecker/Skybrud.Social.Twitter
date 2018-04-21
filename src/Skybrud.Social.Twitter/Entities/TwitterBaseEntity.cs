using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Models;

namespace Skybrud.Social.Twitter.Entities {

    /// <summary>
    /// Abstract class representing a Twitter entity reference.
    /// </summary>
    public abstract class TwitterBaseEntity : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the start index of the entity reference.
        /// </summary>
        public int StartIndex { get; }

        /// <summary>
        /// Gets the end index of the entity reference.
        /// </summary>
        public int EndIndex { get; }

        /// <summary>
        /// Gets an array with the start and end index of the entity reference.
        /// </summary>
        public int[] Indices => new[] { StartIndex, EndIndex };

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="TwitterBaseEntity"/> parsed from the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The <see cref="JObject"/> to be parsed.</param>
        protected TwitterBaseEntity(JObject obj) : base(obj) {
            StartIndex = obj.GetArray("indices").GetInt32(0);
            EndIndex = obj.GetArray("indices").GetInt32(1);
        }

        #endregion

    }

}