using Newtonsoft.Json;

namespace Una.Api.Models.Slack
{
    public class SlackEventWrapper
    {
        [JsonProperty(PropertyName = "team_id")]
        public string TeamId { get; set; }

        [JsonProperty(PropertyName = "api_app_id")]
        public string ApiAppId { get; set; }
        
        [JsonProperty(PropertyName = "authed_teams")]
        public string[] AuthedTeams { get; set; }

        [JsonProperty(PropertyName = "event_id")]
        public string EventId { get; set; }

        [JsonProperty(PropertyName = "event_time")]
        public string EventTime { get; set; }
        
        public string Token { get; set; }

        public SlackMessageEvent Event { get; set; }

        public string Type { get; set; }

        public string Challenge { get; set; }
    }
}
