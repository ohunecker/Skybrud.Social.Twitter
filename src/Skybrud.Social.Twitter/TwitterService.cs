using System;
using Skybrud.Social.Twitter.Endpoints;
using Skybrud.Social.Twitter.OAuth;

namespace Skybrud.Social.Twitter {

    public class TwitterService {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying OAuth client.
        /// </summary>
        public TwitterOAuthClient Client { get; }

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
        public TwitterGeocodeEndpoint Geocode { get; private set; }

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

        private TwitterService(TwitterOAuthClient client) {

            // Set the client
            Client = client;
            
            // Set the endpoints etc.
            Account = new TwitterAccountEndpoint(this);
            Favorites = new TwitterFavoritesEndpoint(this);
            Followers = new TwitterFollowersEndpoint(this);
            Friends = new TwitterFriendsEndpoint(this);
            Geocode = new TwitterGeocodeEndpoint(this);
            Lists = new TwitterListsEndpoint(this);
            Search = new TwitterSearchEndpoint(this);
            Statuses = new TwitterStatusesEndpoint(this);
            Users = new TwitterUsersEndpoint(this);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initializes a new instance from the specified <see cref="TwitterOAuthClient"/>.
        /// </summary>
        /// <param name="client">An instance of <see cref="TwitterOAuthClient"/>.</param>
        /// <returns>Returns a new instance of <see cref="TwitterService"/>.</returns>
        public static TwitterService CreateFromOAuthClient(TwitterOAuthClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return new TwitterService(client);
        }

        #endregion

    }

}