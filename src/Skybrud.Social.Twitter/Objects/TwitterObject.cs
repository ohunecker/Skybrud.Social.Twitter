using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Twitter.Objects {

    /// <summary>
    /// Class representing a basic object from the Twitter API derived from an instance of <code>JObject</code>.
    /// </summary>
    public class TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the internal <code>JObject</code> the object was created from.
        /// </summary>
        [JsonIgnore]
        public JObject JObject { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> representing the object.</param>
        protected TwitterObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}