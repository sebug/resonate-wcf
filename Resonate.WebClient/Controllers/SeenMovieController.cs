using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resonate.Services.Contracts;

namespace Resonate.WebClient.Controllers
{
    public class SeenMovieController : Controller
    {
        private readonly ILogger<SeenMovieController> _logger;
        private readonly ISeenMovieService _seenMovieService;

        public SeenMovieController(ILogger<SeenMovieController> logger,
            ISeenMovieService seenMovieService)
        {
            _logger = logger;
            _seenMovieService = seenMovieService;
        }

        public async Task<IActionResult> Index()
        {
            var seenMovies = await this._seenMovieService.GetAll();
            return View(seenMovies);
        }
    }
}
