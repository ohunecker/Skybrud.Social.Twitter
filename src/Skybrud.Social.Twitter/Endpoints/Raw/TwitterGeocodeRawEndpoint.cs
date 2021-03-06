using System;
using Skybrud.Social.Http;
using Skybrud.Social.Twitter.OAuth;
using Skybrud.Social.Twitter.Options.Geocode;

namespace Skybrud.Social.Twitter.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the <strong>Geocode</strong> endpoint.
    /// </summary>
    public class TwitterGeocodeRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public TwitterOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal TwitterGeocodeRawEndpoint(TwitterOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the place with the specified <paramref name="placeId"/>.
        /// </summary>
        /// <param name="placeId">The ID of the place.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/geo/place-information/api-reference/get-geo-id-place_id</cref>
        /// </see>
        public SocialHttpResponse GetPlace(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException(nameof(placeId));
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/geo/id/" + placeId + ".json");
        }

        /// <summary>
        /// Given a <paramref name="latitude"/> and a <paramref name="longitude"/>, searches for up to 20 places that
        /// can be used as a <c>place_id</c> when updating a status. This request is an informative call
        /// and will deliver generalized results about geography.
        /// </summary>
        /// <param name="latitude">The latitude to search around. This parameter will be ignored
        /// unless it is inside the range -90.0 to +90.0 (North is positive) inclusive. It will
        /// also be ignored if there isn't a corresponding <paramref name="longitude"/> parameter.</param>
        /// <param name="longitude">The longitude to search around. The valid ranges for longitude
        /// is -180.0 to +180.0 (East is positive) inclusive. This parameter will be ignored if
        /// outside that range, if it is not a number, if <c>geo_enabled</c> is disabled, or
        /// if there not a corresponding <paramref name="latitude"/> parameter.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/geo/places-near-location/api-reference/get-geo-reverse_geocode</cref>
        /// </see>
        public SocialHttpResponse ReverseGeocode(double latitude, double longitude) {
            return ReverseGeocode(new TwitterReverseGeocodeOptions(latitude, longitude));
        }

        /// <summary>
        /// Given a latitude and a longitude, searches for up to 20 places that can be used as
        /// a <c>place_id</c> when updating a status. This request is an informative call
        /// and will deliver generalized results about geography.
        /// </summary>
        /// <param name="options">The options used when making the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/geo/places-near-location/api-reference/get-geo-reverse_geocode</cref>
        /// </see>
        public SocialHttpResponse ReverseGeocode(TwitterReverseGeocodeOptions options) {
            return Client.DoHttpGetRequest("https://api.twitter.com/1.1/geo/reverse_geocode.json", options);
        }

        #endregion

    }

}