using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Twitter.Options.Lists {

    /// <summary>
    /// Options for a call to the Twitter API for deleting a list.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-destroy</cref>
    /// </see>
    public class TwitterDestroyListOptions : IHttpPostOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the numerical ID of the list.
        /// </summary>
        public long ListId { get; set; }

        // TODO: Add support for the "owner_screen_name" property

        // TODO: Add support for the "owner_id" property

        // TODO: Add support for the "slug" property

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public TwitterDestroyListOptions() { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="listId"/>.
        /// </summary>
        /// <param name="listId">The numerical ID of the list.</param>
        public TwitterDestroyListOptions(long listId) {
            ListId = listId;
        }
        
        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {
            return new SocialHttpQueryString();
        }

        public IHttpPostData GetPostData() {
            SocialHttpPostData data = new SocialHttpPostData();
            data.Add("list_id", ListId);
            return data;
        }

        #endregion

    }

}