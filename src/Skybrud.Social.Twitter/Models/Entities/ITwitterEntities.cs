namespace Skybrud.Social.Twitter.Models.Entities {
    
    /// <summary>
    /// Class representing a collection of Twitter entities.
    /// </summary>
    public interface ITwitterEntities {

        /// <summary>
        /// Gets a collection of all entities in an ascending order.
        /// </summary>
        TwitterBaseEntity[] GetAll();

        /// <summary>
        /// Gets a collection of all entities in a descending order.
        /// </summary>
        TwitterBaseEntity[] GetAllReversed();
    
    }

}