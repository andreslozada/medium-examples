using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StarwarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private readonly List<string> Quotes = new List<string>()
        {
            "Help me, Obi-Wan Kenobi. You’re my only hope.",
            "he Force will be with you. Always.",
            "Do. Or do not. There is no try.",
            "No. I am your father.",
            "Now, young Skywalker, you will die.",
            "Fear is the path to the dark side. Fear leads to anger; anger leads to hate; hate leads to suffering. I sense much fear in you.",
            "Chewie, we’re home.",
            "Hope."
        };

        // GET api/values
        [HttpGet("Random")]
        public ActionResult<string> Get()
        {
            Random rand = new Random();
            return Quotes[rand.Next(0, Quotes.Count - 1)];
        }
    }
}
