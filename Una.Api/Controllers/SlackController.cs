using Microsoft.AspNetCore.Mvc;
using Slack.Webhooks;
using Una.Api.Models.Slack;

namespace Una.Api.Controllers
{
    [Route("api/slack")]
    public class SlackController : Controller
    {
        [HttpPost]
        public string Post([FromBody]SlackEventWrapper value)
        {
            if (!string.IsNullOrEmpty(value.Challenge))
            {
                return value.Challenge;
            }

            if (value.Event.Type.Equals("message") && !string.IsNullOrEmpty(value.Event.User))
            {
                var slackClient = new SlackClient("https://hooks.slack.com/services/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");

                var slackMessage = new SlackMessage
                {
                    Channel = value.Event.Channel,
                    Text = $"I\'m sorry, I don\'t understand! Sometimes I have an easier time with a few simple keywords.",
                    IconEmoji = Emoji.Pizza,
                    Username = "Una Bot"
                };

                slackClient.Post(slackMessage);
            }

            return string.Empty;
        }
    }
}