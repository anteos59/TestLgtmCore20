﻿using System;
using TestLgtmCore20.BattleNetLib;

namespace TestLgtmCore20
{
    class Program
    {
        static void Main(string[] args)
        {
            OAuthAccessToken accessToken = new OAuthAccessToken();
            accessToken.AccessToken = "Test LGTM Dotnet Core 3.0";
            Console.WriteLine(accessToken.AccessToken);
        }
    }
}
