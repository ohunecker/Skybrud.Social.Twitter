using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Interfaces;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Twitter.Entities;
using Skybrud.Social.Twitter.Objects.Statuses;

namespace Skybrud.Social.Twitter.Objects {

    public class TwitterStatusMessage : TwitterObject, ISocialTimelineEntry {

        #region Properties

        /// <summary>
        /// Gets the ID of the tweet.
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Gets the date and time for when the tweet was created in UTC/GMT.
        /// </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets the text or message of the tweet.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Gets the source/client used for making the tweet.
        /// </summary>
        public string Source { get; private set; }
        
        public bool IsTruncated { get; private set; }

        public TwitterReplyTo InReplyTo { get; private set; }

        public int RetweetCount { get; private set; }

        public int FavoriteCount { get; private set; }

        /// <summary>
        /// Gets whether the authenticated user has favorited the tweet.
        /// </summary>
        public bool HasFavorited { get; private set; }
        
        /// <summary>
        /// Gets whether the authenticated user has retweeted the tweet.
        /// </summary>
        public bool HasRetweeted { get; private set; }

        public TwitterStatusMessageEntities Entities { get; private set; }

        /// <summary>
        /// Gets a reference to extended entities mentioned in the status message.
        /// </summary>
        public TwitterExtendedEntities ExtendedEntities { get; private set; }

        // public TwitterContributor[] Contributors { get; private set; }
        
        public TwitterCoordinates Coordinates { get; private set; }
        
        public TwitterPlace Place { get; private set; }

        /// <summary>
        /// Information about the user who made the tweet. May be <code>NULL</code>.
        /// </summary>
        public TwitterUser User { get; private set; }

        public bool IsPossiblyOffensive { get; private set; }

        public string Language { get; private set; }

        public DateTime SortDate {
            get { return CreatedAt; }
        }

        /// <summary>
        /// Gets whether the status message has any extended entities.
        /// </summary>
        public bool HasExtendedEntities {
            get { return ExtendedEntities != null; }
        }

        #endregion

        #region Constructors

        private TwitterStatusMessage(JObject obj) : base(obj) {

            // Parse basic properties
            Id = obj.GetInt64("id");
            Text = obj.GetString("text");
            Source = obj.GetString("source");
            IsTruncated = obj.GetBoolean("truncated");

            // Twitter has some strange date formats
            CreatedAt = obj.GetString("created_at", TwitterUtils.ParseDateTimeUtc);

            // Parse the reply information
            if (obj.HasValue("in_reply_to_status_id")) {
                InReplyTo = new TwitterReplyTo {
                    StatusId = obj.GetInt64("in_reply_to_status_id"),
                    StatusIdStr = obj.GetString("in_reply_to_status_id_str"),
                    UserId = obj.GetInt64("in_reply_to_user_id"),
                    UserIdStr = obj.GetString("in_reply_to_user_id_str"),
                    ScreenName = obj.GetString("in_reply_to_screen_name")
                };
            }

            RetweetCount = obj.GetInt32("retweet_count");
            FavoriteCount = obj.GetInt32("favorite_count");

            // Related to the authenticating user
            HasFavorited = obj.GetBoolean("favorited");
            HasRetweeted = obj.GetBoolean("retweeted");

            // Parse the entities (if any)
            Entities = obj.GetObject("entities", TwitterStatusMessageEntities.Parse);

            ExtendedEntities = obj.GetObject("extended_entities", TwitterExtendedEntities.Parse);

            // For some weird reason Twitter flips the coordinates by writing longitude before latitude
            // See: https://dev.twitter.com/docs/platform-objects/tweets#obj-coordinates)
            Coordinates = obj.GetObject("coordinates", TwitterCoordinates.Parse);

            // See: https://dev.twitter.com/docs/platform-objects/tweets#obj-contributors
            /*if (tweet.contributors != null) {
                List<TwitterContributor> contributors = new List<TwitterContributor>();
                foreach (dynamic contributor in tweet.contributors) {
                    contributors.Add(new TwitterContributor {
                        UserId = contributor.id,
                        ScreenName = contributor.screen_name
                    });
                }
                msg.Contributors = contributors.ToArray();
            }*/

            User = obj.GetObject("user", TwitterUser.Parse);
            Place = obj.GetObject("place", TwitterPlace.Parse);

            IsPossiblyOffensive = obj.GetBoolean("possibly_sensitive");
            Language = obj.GetString("lang");

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>TwitterStatusMessage</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static TwitterStatusMessage Parse(JObject obj) {
            return obj == null ? null : new TwitterStatusMessage(obj);
        }

        #endregion

    }

}