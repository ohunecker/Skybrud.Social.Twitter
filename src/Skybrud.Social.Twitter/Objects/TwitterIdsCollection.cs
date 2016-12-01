using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Objects {

    public class TwitterIdsCollection : TwitterObject {

        #region Properties

        /// <summary>
        /// Gets the array with the IDs returned in the response.
        /// </summary>
        public long[] Ids { get; private set; }

        /// <summary>
        /// Gets the cursor pointing to the next page in the result set.
        /// </summary>
        public long NextCursor { get; private set; }

        /// <summary>
        /// Gets the cursor pointing to the previous page in the result set.
        /// </summary>
        public long PreviousCursor { get; private set; }

        #endregion

        #region Constructors

        private TwitterIdsCollection(JObject obj) : base(obj) {
            Ids = obj.GetInt64Array("ids");
            NextCursor = obj.GetInt64("next_cursor");
            PreviousCursor = obj.GetInt64("previous_cursor");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>TwitterIdsCollection</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static TwitterIdsCollection Parse(JObject obj) {
            return obj == null ? null : new TwitterIdsCollection(obj);
        }

        #endregion
    
    }

}