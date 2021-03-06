﻿using System.Collections.Generic;

namespace InvestmentHub.Providers.Nubank
{
    public class HttpClient : BaseHttpClient
    {
        protected override IDictionary<string, string> GetDefaultHeaders()
        {
            return new Dictionary<string, string>
            {
                { "accept", "application/json, text/plain, */*" },
                { "accept-language", "en-US,en;q=0.9,pt-BR;q=0.8,pt;q=0.7" },
                { "cache-control", "no-cache" },
                { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36" },
            };
        }

        protected override string GetAuthorizationHeader(string authToken)
            => $"Bearer {authToken}";
    }
}
