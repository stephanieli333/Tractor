using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Tractor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TractorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public TractorController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Card DrawCard(Deck deck)
        {
            return deck.draw();
        }
        [HttpGet]
        public IEnumerable<Card> GetHand(Player p)
        {
            return p.Hand;
        }
        [HttpGet]
        public Boolean CheckIfValidMove(IEnumerable<Card> play)
        {

            return false;
        }
    }
}
