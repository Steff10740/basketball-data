using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BasketBall_Data_Project.Models
{
    public class TimeDetails
    {

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("initial")]
        public int Initial { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("extra")]
        public int Extra { get; set; }
    }

    public class NameTranslations
    {

        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("ru")]
        public string Ru { get; set; }

        [JsonProperty("de")]
        public string De { get; set; }

        [JsonProperty("zh")]
        public string Zh { get; set; }

        [JsonProperty("tr")]
        public string Tr { get; set; }

        [JsonProperty("el")]
        public string El { get; set; }

        [JsonProperty("pt")]
        public string Pt { get; set; }

        [JsonProperty("nl")]
        public string Nl { get; set; }

        [JsonProperty("es")]
        public string Es { get; set; }

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("it")]
        public string It { get; set; }
    }

    public class Details
    {

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_i_s_o")]
        public string CountryISO { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("plays")]
        public string Plays { get; set; }

        [JsonProperty("residence")]
        public string Residence { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("height_meters")]
        public double HeightMeters { get; set; }

        [JsonProperty("prize_current")]
        public string PrizeCurrent { get; set; }

        [JsonProperty("prize_total")]
        public string PrizeTotal { get; set; }

        [JsonProperty("prize_current_euros")]
        public int PrizeCurrentEuros { get; set; }

        [JsonProperty("prize_total_euros")]
        public int PrizeTotalEuros { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }

    public class HomeTeam
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public NameTranslations NameTranslations { get; set; }

        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("name_full")]
        public string NameFull { get; set; }

        [JsonProperty("name_code")]
        public string NameCode { get; set; }

        [JsonProperty("has_sub")]
        public bool HasSub { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("is_nationality")]
        public bool IsNationality { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("foundation")]
        public string Foundation { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }

    public class AwayTeam
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class HomeScore
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("display")]
        public int Display { get; set; }

        [JsonProperty("period_1")]
        public int Period1 { get; set; }

        [JsonProperty("normal_time")]
        public int NormalTime { get; set; }

        [JsonProperty("period_2")]
        public int? Period2 { get; set; }

        [JsonProperty("period_3")]
        public int? Period3 { get; set; }

        [JsonProperty("period_4")]
        public int? Period4 { get; set; }

        [JsonProperty("over_time")]
        public int? OverTime { get; set; }

        [JsonProperty("penalties")]
        public int? Penalties { get; set; }

        [JsonProperty("point")]
        public string Point { get; set; }
    }

    public class AwayScore
    {

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("display")]
        public int Display { get; set; }

        [JsonProperty("period_1")]
        public int Period1 { get; set; }

        [JsonProperty("normal_time")]
        public int NormalTime { get; set; }

        [JsonProperty("period_2")]
        public int? Period2 { get; set; }

        [JsonProperty("period_3")]
        public int? Period3 { get; set; }

        [JsonProperty("period_4")]
        public int? Period4 { get; set; }

        [JsonProperty("over_time")]
        public int? OverTime { get; set; }

        [JsonProperty("penalties")]
        public int? Penalties { get; set; }

        [JsonProperty("point")]
        public string Point { get; set; }
    }

    public class RoundInfo
    {

        [JsonProperty("round")]
        public int Round { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("cupRoundType")]
        public int CupRoundType { get; set; }
    }

    public class Outcome1
    {

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("change")]
        public int Change { get; set; }
    }

    public class OutcomeX
    {

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("change")]
        public int Change { get; set; }
    }

    public class Outcome2
    {

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("change")]
        public int Change { get; set; }
    }

    public class MainOdds
    {

        [JsonProperty("outcome_1")]
        public Outcome1 Outcome1 { get; set; }

        [JsonProperty("outcome_X")]
        public OutcomeX OutcomeX { get; set; }

        [JsonProperty("outcome_2")]
        public Outcome2 Outcome2 { get; set; }
    }

    public class BallPossession
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class TotalShots
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class ShotsOnTarget
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class ShotsOffTarget
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class BlockedShots
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class Fouls
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class FreeThrows
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class FieldGoals
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class Rebounds
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class TimeSpentInLead
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class Shots
    {

        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }

    public class MainStat
    {

        [JsonProperty("ball_possession")]
        public BallPossession BallPossession { get; set; }

        [JsonProperty("total_shots")]
        public TotalShots TotalShots { get; set; }

        [JsonProperty("shots_on_target")]
        public ShotsOnTarget ShotsOnTarget { get; set; }

        [JsonProperty("shots_off_target")]
        public ShotsOffTarget ShotsOffTarget { get; set; }

        [JsonProperty("blocked_shots")]
        public BlockedShots BlockedShots { get; set; }

        [JsonProperty("fouls")]
        public Fouls Fouls { get; set; }

        [JsonProperty("free_throws")]
        public FreeThrows FreeThrows { get; set; }

        [JsonProperty("field_goals")]
        public FieldGoals FieldGoals { get; set; }

        [JsonProperty("rebounds")]
        public Rebounds Rebounds { get; set; }

        [JsonProperty("time_spent_in_lead")]
        public TimeSpentInLead TimeSpentInLead { get; set; }

        [JsonProperty("shots")]
        public Shots Shots { get; set; }
        }

    public class EventDataChange
    {
        [JsonProperty("change_timestamp")]
        public int ChangeTimestamp { get; set; }

        [JsonProperty("items")]
        public IList<string> Items { get; set; }
    }

    public class Periods
    {
        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("period_1")]
        public string Period1 { get; set; }

        [JsonProperty("period_2")]
        public string Period2 { get; set; }

        [JsonProperty("period_3")]
        public string Period3 { get; set; }

        [JsonProperty("period_4")]
        public string Period4 { get; set; }

        [JsonProperty("over_time")]
        public string OverTime { get; set; }

        [JsonProperty("penalties")]
        public string Penalties { get; set; }

        [JsonProperty("period_5")]
        public string Period5 { get; set; }

        [JsonProperty("point")]
        public string Point { get; set; }
    }

    public class PeriodsTime
    {

        [JsonProperty("current_time")]
        public int CurrentTime { get; set; }

        [JsonProperty("period_1_time")]
        public int Period1Time { get; set; }

        [JsonProperty("period_2_time")]
        public int Period2Time { get; set; }

        [JsonProperty("period_3_time")]
        public int Period3Time { get; set; }

        [JsonProperty("period_4_time")]
        public int Period4Time { get; set; }
    }

    public class Sport
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Season
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year_start")]
        public int YearStart { get; set; }

        [JsonProperty("year_end")]
        public int? YearEnd { get; set; }
    }

    public class Host
    {

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }

    public class Fact
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class League
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("host")]
        public Host Host { get; set; }

        [JsonProperty("tennis_points")]
        public int TennisPoints { get; set; }

        [JsonProperty("facts")]
        public IList<Fact> Facts { get; set; }
    }

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
        public int? WinnerCode { get; set; }

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

        [JsonProperty("main_stat")]
        public MainStat MainStat { get; set; }

        [JsonProperty("event_data_change")]
        public EventDataChange EventDataChange { get; set; }

        [JsonProperty("periods")]
        public Periods Periods { get; set; }

        [JsonProperty("periods_time")]
        public PeriodsTime PeriodsTime { get; set; }

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

        [JsonProperty("sport")]
        public Sport Sport { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }
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

    public class Event
    {

        [JsonProperty("data")]
        public ObservableCollection<Datum> Data { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
