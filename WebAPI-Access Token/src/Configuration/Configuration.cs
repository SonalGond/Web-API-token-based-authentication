using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Access_Token.src.Configuration
{
    public class Configuration
    {
        public string DomainUrl { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string ClientSecret { get; set; }
        public string OauthClientKey { get; set; }
        public string JwtTtlInSeconds { get; set; }
        public string TimeOutInSeconds { get; set; }
        public string UrlDigestSalt { get; set; }
    }
}