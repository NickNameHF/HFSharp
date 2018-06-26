using System;
using System.Net;
using System.Net.Http;
using HFSharp.Constants;
using HFSharp.Extensions;
using HFSharp.Models.Responses;

namespace HFSharp
{
    public class HFClient
    {
        #region Constructor

        public HFClient(string accessToken)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new ArgumentNullException("accessToken");
            }

            AccessToken = accessToken;
        }

        #endregion

        #region Properties

        private string AccessToken { get; }

        #endregion

        #region Public Methods

        #region Get Methods

        public ApiVersion GetCurrentApiVersion()
        {
            ApiVersion result = GetRequest<ApiVersion>(string.Concat(HFConstants.BaseUrl, HFConstants.VersionUrl.Version));
            return result;
        }

        public UserResponse GetUserProfile(int uid)
        {
            UserResponse result = GetRequest<UserResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.UserUrl.User, uid));
            return result;
        }

        public UsersResponse GetUsersProfiles(int[] uids)
        {
            string request = string.Join(",", Array.ConvertAll(uids, item => item.ToString()));
            UsersResponse result = GetRequest<UsersResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.UsersUrl.Users, request));
            return result;
        }

        public CategoryResponse GetCategory(int fid)
        {
            CategoryResponse result = GetRequest<CategoryResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.CategoryUrl.Category, fid));
            return result;
        }

        public PostResponse GetPost(int pid)
        {
            PostResponse result = GetRequest<PostResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.PostUrl.Post, pid));
            return result;
        }

        public ThreadResponse GetThread(int tid)
        {
            ThreadResponse result = GetRequest<ThreadResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.ThreadUrl.Thread, tid));
            return result;
        }

        public ForumResponse GetForum(int fid)
        {
            ForumResponse result = GetRequest<ForumResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.ForumUrl.Forum, fid));
            return result;
        }

        public PrivateMessageResponse GetPrivateMessage(int pmid)
        {
            PrivateMessageResponse result = GetRequest<PrivateMessageResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.PrivateMessageUrl.Pm, pmid));
            return result;
        }

        public PmBoxResponse GetPmBox(int id)
        {
            PmBoxResponse result = GetRequest<PmBoxResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.PrivateMessageBoxUrls.Pmbox, id));
            return result;
        }

        public PmBoxResponse GetInbox()
        {
            PmBoxResponse result = GetRequest<PmBoxResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.PrivateMessageBoxUrls.Inbox));
            return result;
        }

        public GroupResponse GetGroup(int id)
        {
            GroupResponse result = GetRequest<GroupResponse>(string.Concat(HFConstants.BaseUrl, HFConstants.GroupUrl.Group, id));
            return result;
        }

        #endregion

        #endregion

        #region Private Methods

        private T GetRequest<T>(string url)
        {
            HttpClientHandler handler = new HttpClientHandler
                { Credentials = new NetworkCredential(AccessToken, string.Empty) };

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

            //request.Headers.Add(HFConstants.HeadersConstants.AuthorizationKey, string.Format(HFConstants.HeadersConstants.AuthorizationValue, AccessToken));
            HttpClient client = new HttpClient(handler);
            var response = client.SendAsync(request).Result;

            switch ((int)response.StatusCode)
            {
                case (int)HttpStatusCode.OK:
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    var output = result.JsonToOjbect<T>();
                    return output;
                }
                default:
                    HandleOtherStatusCodes(response.StatusCode);
                    throw new HttpRequestException(string.Format(HFConstants.StatusCodeExceptions.Default, (int)response.StatusCode, response.StatusCode));
            }
        }

        private void HandleOtherStatusCodes(HttpStatusCode statusCode)
        {
            switch ((int)statusCode)
            {
                case (int)HttpStatusCode.BadRequest:
                    throw new HttpRequestException(HFConstants.StatusCodeExceptions.BadRequest);
                case (int)HttpStatusCode.Unauthorized:
                    throw new HttpRequestException(HFConstants.StatusCodeExceptions.Unauthorized);
                case (int)HttpStatusCode.Forbidden:
                    throw new HttpRequestException(HFConstants.StatusCodeExceptions.Forbidden);
                case (int)HttpStatusCode.NotFound:
                    throw new HttpRequestException(HFConstants.StatusCodeExceptions.NotFound);
                case 429:
                    throw new HttpRequestException(HFConstants.StatusCodeExceptions.TooManyRequests);
                case (int)HttpStatusCode.InternalServerError:
                case (int)HttpStatusCode.NotImplemented:
                case (int)HttpStatusCode.BadGateway:
                case (int)HttpStatusCode.ServiceUnavailable:
                case (int)HttpStatusCode.GatewayTimeout:
                case (int)HttpStatusCode.HttpVersionNotSupported:
                    throw new HttpRequestException(string.Format(HFConstants.StatusCodeExceptions.FiveHundredXX, (int)statusCode, statusCode));
            }
        }

        #endregion
    }
}