using Newtonsoft.Json.Linq;
using Skybrud.Social.Twitter.Entities;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Twitter.Objects.Statuses {
    
    /// <summary>
    /// Class representing the extended entities property of a status message.
    /// </summary>
    public class TwitterExtendedEntities : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets an array of all media mentioned in the parent status message.
        /// </summary>
        public TwitterMediaEntity[] Media { get; private set; }

        #endregion

        #region Constructors

        private TwitterExtendedEntities(JObject obj) : base(obj) {
            Media = obj.GetArray("media", TwitterMediaEntity.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>TwitterExtendedEntities</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static TwitterExtendedEntities Parse(JObject obj) {
            return obj == null ? null : new TwitterExtendedEntities(obj);
        }

        #endregion

    }

}