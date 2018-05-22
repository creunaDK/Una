﻿using Microsoft.AspNetCore.Mvc;
using Una.Api.Models.Slack;

namespace Una.Api.Controllers
{
    [Route("api/slack")]
    public class SlackController : Controller
    {
        [HttpPost]
        public string Post([FromBody]SlackEventWrapper value)
        {
            return value.Challenge;
        }
    }
}