using BasketBall_Data_Project.Models.Event;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BasketBall_Data_Project.Models
{
    public class Datum
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_more")]
        public string StatusMore { get; set; }

        [JsonProperty("time_details")]
        public TimeDetails TimeDetails { get; set; }

        [JsonProperty("home_team")]
        public HomeTeam HomeTeam { get; set; }

        [JsonProperty("away_team")]
        public AwayTeam AwayTeam { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("home_score")]
        public HomeScore HomeScore { get; set; }

        [JsonProperty("away_score")]
        public AwayScore AwayScore { get; set; }

        [JsonProperty("winner_code")]
        public int WinnerCode { get; set; }

        [JsonProperty("aggregated_winner_code")]
        public object AggregatedWinnerCode { get; set; }

        [JsonProperty("result_only")]
        public bool ResultOnly { get; set; }

        [JsonProperty("coverage")]
        public int? Coverage { get; set; }

        [JsonProperty("ground_type")]
        public string GroundType { get; set; }

        [JsonProperty("series_count")]
        public int? SeriesCount { get; set; }

        [JsonProperty("medias_count")]
        public int? MediasCount { get; set; }

        [JsonProperty("status_lineup")]
        public int? StatusLineup { get; set; }

        [JsonProperty("first_supply")]
        public int? FirstSupply { get; set; }

        [JsonProperty("cards_code")]
        public string CardsCode { get; set; }

        [JsonProperty("lasted_period")]
        public string LastedPeriod { get; set; }

        [JsonProperty("default_period_count")]
        public int? DefaultPeriodCount { get; set; }

        [JsonProperty("attendance")]
        public int? Attendance { get; set; }

        [JsonProperty("cup_match_order")]
        public int? CupMatchOrder { get; set; }

        [JsonProperty("cup_match_in_round")]
        public int? CupMatchInRound { get; set; }
    }

    public class Links
    {

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public object Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class Link
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class Meta
    {

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("links")]
        public IList<Link> Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("to")]
        public int To { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Events
    {

        [JsonProperty("data")]
        public ObservableCollection<Datum> Data { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
