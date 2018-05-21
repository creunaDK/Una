namespace Una.Api.Models.Slack
{
    public class SlackVerificationMessage
    {
        public string Token { get; set; }

        public string Challenge { get; set; }

        public string Type { get; set; }
    }
}
