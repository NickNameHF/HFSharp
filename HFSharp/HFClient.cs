using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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

            AuthToken = accessToken.ToBase64();
        }

        #endregion

        #region Properties

        private string AuthToken { get; }

        #endregion

        #region Public Methods

        #region Get Methods

        public ApiVersion GetCurrentApiVersion()
        {
            ApiVersion result = GetRequest<ApiVersion>(HFConstants.VersionUrl.Version);
            return result;
        }

        public UserResponse GetUserProfile(int uid)
        {
            UserResponse result = GetRequest<UserResponse>(string.Concat(HFConstants.UserUrl.User, uid));
            return result;
        }

        public UsersResponse GetUsersProfiles(int[] uids)
        {
            int[] maxUids = Enumerable.Range(0, 20).ToArray();
            string request = string.Join(",", Array.ConvertAll(maxUids, item => item.ToString()));
            UsersResponse result = GetRequest<UsersResponse>(string.Concat(HFConstants.UsersUrl.Users, request));
            return result;
        }

        public CategoryResponse GetCategory(int fid)
        {
            CategoryResponse result = GetRequest<CategoryResponse>(string.Concat(HFConstants.CategoryUrl.Category, fid));
            return result;
        }

        public PostResponse GetPost(int pid)
        {
            PostResponse result = GetRequest<PostResponse>(string.Concat(HFConstants.PostUrl.Post, pid));
            return result;
        }

        public ThreadResponse GetThread(int tid, int page = 1)
        {
            ThreadResponse result = GetRequest<ThreadResponse>(string.Concat(HFConstants.ThreadUrl.Thread, tid, HFConstants.ThreadUrl.PageOption, page));
            return result;
        }

        public ForumResponse GetForum(int fid)
        {
            ForumResponse result = GetRequest<ForumResponse>(string.Concat(HFConstants.ForumUrl.Forum, fid));
            return result;
        }

        public PrivateMessageResponse GetPrivateMessage(int pmid)
        {
            PrivateMessageResponse result = GetRequest<PrivateMessageResponse>(string.Concat(HFConstants.PrivateMessageUrl.Pm, pmid));
            return result;
        }

        public PmBoxResponse GetPmBox(int id)
        {
            PmBoxResponse result = GetRequest<PmBoxResponse>(string.Concat(HFConstants.PrivateMessageBoxUrls.Pmbox, id));
            return result;
        }

        public PmBoxResponse GetInbox()
        {
            PmBoxResponse result = GetRequest<PmBoxResponse>(HFConstants.PrivateMessageBoxUrls.Inbox);
            return result;
        }

        public GroupResponse GetGroup(int id)
        {
            GroupResponse result = GetRequest<GroupResponse>(string.Concat(HFConstants.GroupUrl.Group, id));
            return result;
        }

        #endregion

        #endregion

        #region Private Methods

        private T GetRequest<T>(string url)
        {
            using (HttpClient client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri(HFConstants.BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(HFConstants.MimeTypes.Json));
                client.DefaultRequestHeaders.Add(HFConstants.HeadersConstants.UserAgentKey, HFConstants.HeadersConstants.UserAgentValue);
                client.DefaultRequestHeaders.Add(HFConstants.HeadersConstants.AuthorizationKey, string.Concat(HFConstants.HeadersConstants.AuthorizationValue, AuthToken));

                var response = client.GetAsync(url).Result;
                switch ((int) response.StatusCode)
                {
                    case (int) HttpStatusCode.OK:
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        var output = result.JsonToOjbect<T>();
                        return output;
                    }
                    default:
                        HandleOtherStatusCodes(response.StatusCode);
                        throw new HttpRequestException(string.Format(HFConstants.StatusCodeExceptions.Default,
                            (int) response.StatusCode, response.StatusCode));
                }
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