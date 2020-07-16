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
    [Route("api/[controller]")]
    [ApiController]
    public class SeenMovieController : ControllerBase
    {
        private readonly string _basicHttpEndpointEndpointAddress = "https://localhost:5001/SeenMovieService";

        // GET: api/SeenMovie
        [HttpGet]
        public async Task<List<SeenMovie>> Get()
        {
            var binding = new BasicHttpsBinding();
            var factory = new ChannelFactory<ISeenMovieService>(binding, new EndpointAddress(this._basicHttpEndpointEndpointAddress));
            factory.Open();
            var channel = factory.CreateChannel();
            var context = ((IContextChannel)channel);
            List<SeenMovie> result;
            using (var scope = new OperationContextScope(context))
            {
                HttpRequestMessageProperty requestMessageProperty;
                if (!OperationContext.Current.OutgoingMessageProperties.ContainsKey(HttpRequestMessageProperty.Name))
                {
                    requestMessageProperty = new HttpRequestMessageProperty();
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                }
                else
                {
                    requestMessageProperty = (HttpRequestMessageProperty)OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name];
                }
                requestMessageProperty.Headers["AuthInfo"] = "Hello";

                ((IClientChannel)channel).Open();
                result = await channel.GetAll();
                ((IClientChannel)channel).Close();
            }

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
