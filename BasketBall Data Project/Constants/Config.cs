using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBall_Data_Project.Constants
{
    public static class Config
    {
        // Api URL
        public const string ApiUrl = "https://sportscore1.p.rapidapi.com/sports/3";

        // Tabs' Titles
        public const string TeamTitle = "Teams";
        public const string LeagueTitle = "Leagues";
        public const string SeasonTitle = "Seasons";
        public const string LiveGamesTitle = "Live Games";
        public const string DetailsTitle = "Details";

        // Api Request Headers
        public const string ApiHostHeader = "x-rapidapi-host";
        public const string ApiKeyHeader = "x-rapidapi-key";
        public const string ApiHost = "sportscore1.p.rapidapi.com";
        public const string ApiKey = "5db3d1a402mshfaac0a322055c8bp160d52jsn28ee48f46c4e";
    }
}
