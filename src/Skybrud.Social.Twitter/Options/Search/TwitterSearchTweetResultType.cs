namespace Skybrud.Social.Twitter.Options.Search {

    /// <summary>
    /// Enum class indicating the type of tweets thats should be returned when performing a search.
    /// </summary>
    public enum TwitterSearchTweetResultType {

        /// <summary>
        /// Include both popular and real time results in the response.
        /// </summary>
        Mixed,

        /// <summary>
        /// Return only the most recent results in the response.
        /// </summary>
        Recent,

        /// <summary>
        /// Return only the most popular results in the response.
        /// </summary>
        Popular

    }

}