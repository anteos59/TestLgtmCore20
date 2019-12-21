using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TestLgtmCore20.BattleNetLib
{
    internal class OAuthAccessToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
