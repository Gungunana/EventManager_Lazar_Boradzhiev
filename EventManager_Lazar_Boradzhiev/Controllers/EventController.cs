using Data.Context;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EventManager_Lazar_Boradzhiev.Controllers
{
    [RoutePrefix("api/event")]
    public class EventController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<Event> events = new EventRepository().GetAll();

            return Ok(events);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult Get(int id)
        {
            Event _event = new EventRepository().GetById(id);

            if (_event == null)
            {
                return NotFound();
            }

            return Ok(_event);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            EventRepository repository = new EventRepository();
            Event _event = repository.GetById(id);

            if (_event == null)
            {
                return NotFound();
            }

            repository.Delete(_event);

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Post(Event _event)
        {
            EventRepository repo = new EventRepository();
            repo.Insert(_event);

            return Ok(_event);
        }

        [HttpPut]
        public IHttpActionResult Put(Event _event)
        {
            EventRepository repo = new EventRepository();
            repo.Update(_event);

            return Ok(_event);
        }
    }
}