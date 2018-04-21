using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Entities {

    public class TwitterUserDescriptionEntities : ITwitterEntities {

        #region Properties

        public TwitterUrlEntity[] Urls { get; private set; }

        #endregion

        #region Constructors

        private TwitterUserDescriptionEntities() { }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a collection of all entities in an ascending order.
        /// </summary>
        public TwitterBaseEntity[] GetAll() {
            List<TwitterBaseEntity> temp = new List<TwitterBaseEntity>();
            temp.AddRange(Urls);
            return temp.OrderBy(x => x.StartIndex).ToArray();
        }

        /// <summary>
        /// Gets a collection of all entities in an descending order.
        /// </summary>
        public TwitterBaseEntity[] GetAllReversed() {
            List<TwitterBaseEntity> temp = new List<TwitterBaseEntity>();
            temp.AddRange(Urls);
            return temp.OrderByDescending(x => x.StartIndex).ToArray();
        }

        #endregion

        #region Static methods

        public static TwitterUserDescriptionEntities Parse(JObject entities) {
            if (entities == null) return null;
            return new TwitterUserDescriptionEntities {
                Urls = entities.GetArray("urls", TwitterUrlEntity.Parse)
            };
        }

        #endregion

    }

}