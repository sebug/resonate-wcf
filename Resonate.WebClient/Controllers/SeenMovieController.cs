using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Resonate.WebClient.Controllers
{
    public class SeenMovieController : Controller
    {
        private readonly ILogger<SeenMovieController> _logger;

        public SeenMovieController(ILogger<SeenMovieController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
