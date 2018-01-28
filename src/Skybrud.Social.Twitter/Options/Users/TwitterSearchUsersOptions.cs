using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Twitter.Options.Users {

    public class TwitterSearchUsersOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the search query.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Specifies the page of results to retrieve.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// The number of potential user results to retrieve per page. This value has a maximum of 20.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The entities node will be disincluded from embedded tweet objects when set to <code>false</code>.
        /// </summary>
        public bool IncludeEntities { get; set; }

        #endregion

        #region Constructors

        public TwitterSearchUsersOptions() {
            Page = 1;
            Count = 20;
            IncludeEntities = true;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Return a new instance of <see cref="IHttpQueryString"/> representing the specified options.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpQueryString"/>.</returns>
        public IHttpQueryString GetQueryString() {

            SocialHttpQueryString query = new SocialHttpQueryString();

            query.Set("q", Query);
            if (Page > 1) query.Set("page", Page);
            if (Count != 20) query.Set("count", Count);
            if (!IncludeEntities) query.Set("include_entities", "false");

            return query;

        }

        #endregion

    }

}