using Newtonsoft.Json;

namespace Una.Api.Models.Slack
{
    public class SlackMessageEvent
    {
        public string Type { get; set; }

        public string Channel { get; set; }

        public string User { get; set; }

        public string Text { get; set; }

        public string Ts { get; set; }

        [JsonProperty(PropertyName = "event_ts")]
        public string EventTs { get; set; }

        [JsonProperty(PropertyName = "channel_type")]
        public string ChannelType { get; set; }
    }
}
