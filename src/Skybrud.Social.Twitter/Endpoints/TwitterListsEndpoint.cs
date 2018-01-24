using Skybrud.Social.Twitter.Endpoints.Raw;
using Skybrud.Social.Twitter.Options.Lists;
using Skybrud.Social.Twitter.Responses.Lists;

namespace Skybrud.Social.Twitter.Endpoints {
    
    /// <summary>
    /// Implementation of the lists endpoint.
    /// </summary>
    public class TwitterListsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Twitter service.
        /// </summary>
        public TwitterService Service { get; }

        /// <summary>
        /// Gets a reference to the raw lists endpoint.
        /// </summary>
        public TwitterListsRawEndpoint Raw => Service.Client.Lists;

        #endregion

        #region Constructors

        internal TwitterListsEndpoint(TwitterService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets information about the list with the specified <code>listId</code>.
        /// </summary>
        /// <param name="listId">The ID of the list.</param>
        public TwitterListResponse GetList(long listId) {
            return TwitterListResponse.ParseResponse(Raw.GetList(listId));
        }

        /// <summary>
        /// Gets information about the list with the specified <code>listId</code>.
        /// </summary>
        /// <param name="userId">The ID of the user owning the list.</param>
        /// <param name="slug">The slug of the list.</param>
        public TwitterListResponse GetList(long userId, string slug) {
            return TwitterListResponse.ParseResponse(Raw.GetList(userId, slug));
        }

        /// <summary>
        /// Gets information about the list with the specified <code>listId</code>.
        /// </summary>
        /// <param name="screenName">The screen name of the user owning the list.</param>
        /// <param name="slug">The slug of the list.</param>
        public TwitterListResponse GetList(string screenName, string slug) {
            return TwitterListResponse.ParseResponse(Raw.GetList(screenName, slug));
        }

        /// <summary>
        /// Gets information about the list matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public TwitterListResponse GetList(TwitterGetListOptions options) {
            return TwitterListResponse.ParseResponse(Raw.GetList(options));
        }

        /// <summary>
        /// Gets a list of list of the authenticated user.
        /// </summary>
        /// <returns></returns>
        public TwitterListsResponse GetLists() {
            return TwitterListsResponse.ParseResponse(Raw.GetLists());
        }

        /// <summary>
        /// Gets a list of lists of the user with the specified <code>userId</code>.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        public TwitterListsResponse GetLists(long userId) {
            return TwitterListsResponse.ParseResponse(Raw.GetLists(userId));
        }

        /// <summary>
        /// Gets a list of lists of the user with the specified <code>screenName</code>.
        /// </summary>
        /// <param name="screenName">The screen name of the user.</param>
        public TwitterListsResponse GetLists(string screenName) {
            return TwitterListsResponse.ParseResponse(Raw.GetLists(screenName));
        }

        
        /// <summary>
        /// Creates a new list for the authenticated user. Note that you can create up to 1000 lists per account. The created list will be public.
        /// </summary>
        /// <param name="name">The name of the list.</param>
        /// <returns>An instance of <see cref="TwitterCreateListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-create</cref>
        /// </see>
        public TwitterCreateListResponse CreateList(string name) {
            return CreateList(new TwitterCreateListOptions(name));
        }

        /// <summary>
        /// Creates a new list for the authenticated user. Note that you can create up to 1000 lists per account.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="TwitterCreateListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-create</cref>
        /// </see>
        public TwitterCreateListResponse CreateList(TwitterCreateListOptions options) {
            return TwitterCreateListResponse.ParseResponse(Raw.CreateList(options));
        }

        /// <summary>
        /// Deletes the specified list. The authenticated user must own the list to be able to destroy it.
        /// </summary>
        /// <param name="listId"></param>
        /// <returns>An instance of <see cref="TwitterDeleteListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-destroy</cref>
        /// </see>
        public TwitterDeleteListResponse DeleteList(long listId) {
            return DeleteList(new TwitterDeleteListOptions(listId));
        }

        /// <summary>
        /// Deletes the specified list. The authenticated user must own the list to be able to destroy it.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="TwitterDeleteListResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-destroy</cref>
        /// </see>
        public TwitterDeleteListResponse DeleteList(TwitterDeleteListOptions options) {
            return TwitterDeleteListResponse.ParseResponse(Raw.DeleteList(options));
        }

        /// <summary>
        /// Adds a member to a list. The authenticated user must own the list to be able to add members to it. Note that lists cannot have more than 5,000 members.
        /// </summary>
        /// <param name="listId">The numeric ID of the list.</param>
        /// <param name="userId">The numeric ID of the user.</param>
        /// <returns>An instance of <see cref="TwitterAddMemberResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-members-create</cref>
        /// </see>
        public TwitterAddMemberResponse AddMember(long listId, long userId) {
            return AddMember(new TwitterAddMemberOptions(listId, userId));
        }

        /// <summary>
        /// Adds a member to a list. The authenticated user must own the list to be able to add members to it. Note that lists cannot have more than 5,000 members.
        /// </summary>
        /// <param name="listId">The numeric ID of the list.</param>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>An instance of <see cref="TwitterAddMemberResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-members-create</cref>
        /// </see>
        public TwitterAddMemberResponse AddMember(long listId, string screenName) {
            return AddMember(new TwitterAddMemberOptions(listId, screenName));
        }

        /// <summary>
        /// Adds a member to a list. The authenticated user must own the list to be able to add members to it. Note that lists cannot have more than 5,000 members.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="TwitterAddMemberResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-members-create</cref>
        /// </see>
        public TwitterAddMemberResponse AddMember(TwitterAddMemberOptions options) {
            return TwitterAddMemberResponse.ParseResponse(Raw.AddMember(options));
        }

        /// <summary>
        /// Removes the specified member from the list. The authenticated user must be the list’s owner to remove members from the list.
        /// </summary>
        /// <param name="listId">The numeric ID of the list.</param>
        /// <param name="userId">The numeric ID of the user.</param>
        /// <returns>An instance of <see cref="TwitterRemoveMemberResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-members-destroy</cref>
        /// </see>
        public TwitterRemoveMemberResponse RemoveMember(long listId, long userId) {
            return RemoveMember(new TwitterRemoveMemberOptions(listId, userId));
        }

        /// <summary>
        /// Removes the specified member from the list. The authenticated user must be the list’s owner to remove members from the list.
        /// </summary>
        /// <param name="listId">The numeric ID of the list.</param>
        /// <param name="screenName">The screen name of the user.</param>
        /// <returns>An instance of <see cref="TwitterRemoveMemberResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-members-destroy</cref>
        /// </see>
        public TwitterRemoveMemberResponse RemoveMember(long listId, string screenName) {
            return RemoveMember(new TwitterRemoveMemberOptions(listId, screenName));
        }

        /// <summary>
        /// Removes the specified member from the list. The authenticated user must be the list’s owner to remove members from the list.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="TwitterRemoveMemberResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developer.twitter.com/en/docs/accounts-and-users/create-manage-lists/api-reference/post-lists-members-destroy</cref>
        /// </see>
        public TwitterRemoveMemberResponse RemoveMember(TwitterRemoveMemberOptions options) {
            return TwitterRemoveMemberResponse.ParseResponse(Raw.RemoveMember(options));
        }

        #endregion

    }

}