using RestSharpSpot.Api.Objects;
using RestSharpSpot.API;
using System.Collections.Generic;

namespace RestSharpSpot.Api.Services.UsersProfile
{
    public class UsersProfileApi : BaseApi
    {
        public UsersProfileApi(string clientID, string key, string responseType, string redirectUri) : base(clientID, key, responseType, redirectUri)
        {
        }

        public PrivateUser GetCurrentUserProfile()
        {
            return Rest.SendRequestAndGetData<PrivateUser>("v1/me");
        }

        public PublicUser GetUserProfile(string userId)
        {
            var urlSegmentParameter = new KeyValuePair<string, string>("user_id", userId);
            return Rest.SendRequestAndGetData<PublicUser>("/v1/users/{user_id}", urlSegmentParameter);
        }
    }
}