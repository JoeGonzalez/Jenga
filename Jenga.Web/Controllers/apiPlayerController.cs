using Jenga.Models;
using Jenga.Web.Adapters;
using Jenga.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jenga.Web.Controllers
{
    public class apiPlayerController : ApiController
    {
        private IJenga _adapter;
        public apiPlayerController() 
        {
            _adapter = new JengaAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(int id = -1) 
        {
            if (id == -1)
            {
                return Ok(_adapter.GetPlayers());
            }
            else 
            {
                return Ok(_adapter.GetPlayer(id));
            }
        }
        [HttpPost]
        public IHttpActionResult Post(Players Players)
        {
            _adapter.CreatePlayer(Players);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delte() 
        {
            return Ok();
        }
    }
}
