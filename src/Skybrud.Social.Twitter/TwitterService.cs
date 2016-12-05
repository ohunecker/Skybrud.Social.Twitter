using System;
using Skybrud.Social.Twitter.Endpoints;
using Skybrud.Social.Twitter.OAuth;

namespace Skybrud.Social.Twitter {

    public class TwitterService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying OAuth client.
        /// </summary>
        public TwitterOAuthClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to the Account endpoint.
        /// </summary>
        public TwitterAccountEndpoint Account { get; private set; }

        /// <summary>
        /// Gets a reference to the Favorites endpoint.
        /// </summary>
        public TwitterFavoritesEndpoint Favorites { get; private set; }

        /// <summary>
        /// Gets a reference to the Followers endpoint.
        /// </summary>
        public TwitterFollowersEndpoint Followers { get; private set; }

        /// <summary>
        /// Gets a reference to the Friends endpoint.
        /// </summary>
        public TwitterFriendsEndpoint Friends { get; private set; }

        /// <summary>
        /// Gets a reference to the Geo endpoint.
        /// </summary>
        public TwitterGeoEndpoint Geo { get; private set; }

        /// <summary>
        /// Gets a reference to the Lists endpoint.
        /// </summary>
        public TwitterListsEndpoint Lists { get; private set; }

        /// <summary>
        /// Gets a reference to the Search endpoint.
        /// </summary>
        public TwitterSearchEndpoint Search { get; private set; }

        /// <summary>
        /// Gets a reference to the Statuses endpoint.
        /// </summary>
        public TwitterStatusesEndpoint Statuses { get; private set; }

        /// <summary>
        /// Gets a reference to the Users endpoint.
        /// </summary>
        public TwitterUsersEndpoint Users { get; private set; }

        #endregion

        #region Constructors

        private TwitterService() { }

        #endregion

        #region Static methods

        /// <summary>
        /// Initializes a new instance from the specified <see cref="TwitterOAuthClient"/>.
        /// </summary>
        /// <param name="client">An instance of <see cref="TwitterOAuthClient"/>.</param>
        /// <returns>Returns a new instance of <see cref="TwitterService"/>.</returns>
        public static TwitterService CreateFromOAuthClient(TwitterOAuthClient client) {

            // This should never be null
            if (client == null) throw new ArgumentNullException("client");

            // Initialize the service
            TwitterService service = new TwitterService {
                Client = client
            };

            // Set the endpoints etc.
            service.Account = new TwitterAccountEndpoint(service);
            service.Favorites = new TwitterFavoritesEndpoint(service);
            service.Followers = new TwitterFollowersEndpoint(service);
            service.Friends = new TwitterFriendsEndpoint(service);
            service.Geo = new TwitterGeoEndpoint(service);
            service.Lists = new TwitterListsEndpoint(service);
            service.Search = new TwitterSearchEndpoint(service);
            service.Statuses = new TwitterStatusesEndpoint(service);
            service.Users = new TwitterUsersEndpoint(service);

            // Return the service
            return service;

        }

        #endregion

    }

}