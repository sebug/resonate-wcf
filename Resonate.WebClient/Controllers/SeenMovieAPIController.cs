using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resonate.Services.Contracts;
using Resonate.Services.Entities;

namespace Resonate.WebClient.Controllers
{
    [Route("api/SeenMovie")]
    [ApiController]
    public class SeenMovieAPIController : ControllerBase
    {
        private readonly ISeenMovieService SeenMovieService;

        public SeenMovieAPIController(ISeenMovieService seenMovieService)
        {
            this.SeenMovieService = seenMovieService;
        }

        // GET: api/SeenMovie
        [HttpGet]
        public async Task<List<SeenMovie>> Get()
        {
            var result = await this.SeenMovieService.GetAll();

            return result;
        }

        // GET: api/SeenMovie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SeenMovie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SeenMovie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
