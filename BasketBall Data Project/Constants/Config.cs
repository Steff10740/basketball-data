using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBall_Data_Project.Constants
{
    public class Config
    {
        // Api EndPoints
        public const string teamURL = "https://sportscore1.p.rapidapi.com/sports/3/teams";
        public const string leagueURL = "https://sportscore1.p.rapidapi.com/sports/3/leagues";
        public const string seasonURL = "https://sportscore1.p.rapidapi.com/sports/3/seasons";

        // Tabs' Titles
        public const string teamTitle = "Teams";
        public const string leagueTitle = "Leagues";
        public const string seasonTitle = "Seasons";

        // Api Request Headers
        public const string ApiHostHeader = "x-rapidapi-host";
        public const string ApiKeyHeader = "x-rapidapi-key";
        public const string ApiHost = "sportscore1.p.rapidapi.com";
        public const string ApiKey = "";
    }
}
