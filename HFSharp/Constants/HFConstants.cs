namespace HFSharp.Constants
{
    public class HFConstants
    {
        public const string BaseUrl = "https://hackforums.net/api/v1/";

        public class HeadersConstants
        {
            public const string AuthorizationKey = "Authorization";
            public const string AuthorizationValue = "Basic {0}";
        }

        public class StatusCodeExceptions
        {
            public const string BadRequest =
                "400 Bad Request - Usually this results from missing a required parameter.";

            public const string Unauthorized = "401 Unauthorized - No valid access token provided.";
            public const string Forbidden = "403 Forbidden - The access token is not valid for that request.";
            public const string NotFound = "404 Not Found - The requested item doesn't exist.";

            public const string TooManyRequests =
                "429 Too Many Requests - You have been ratelimited for making too many requests to the server.";

            public const string FiveHundredXX = "{0} {1} - Something went wrong on HackForums' side.";
            public const string Default = "{0} {1} - Error getting data from HackForums.";
        }

        public class VersionUrl
        {
            public const string Version = "?version";
        }

        public class UserUrl
        {
            public const string User = "user/";
        }

        public class UsersUrl
        {
            public const string Users = "users/";
        }

        public class CategoryUrl
        {
            public const string Category = "category/";
        }

        public class ForumUrl
        {
            public const string Forum = "forum/";
        }

        public class ThreadUrl
        {
            public const string Thread = "thread/";
        }

        public class PostUrl
        {
            public const string Post = "post/";
        }

        public class PrivateMessageUrl
        {
            public const string Pm = "pm/";
        }

        public class PrivateMessageBoxUrls
        {
            public const string Pmbox = "pmbox/";
            public const string Inbox = "inbox/";
        }

        public class GroupUrl
        {
            public const string Group = "group/";
        }
    }
}
