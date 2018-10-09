using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.ApplicationService;

namespace WebShopSpacesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        //GET api/Tickets
        [HttpGet]
        public ActionResult<IEnumerable<Ticket>> Get()
        {
            try
            {
                return Ok(_ticketService.ReadAllTicket());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/Tickets/5 -- READ By Id
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            return Ok(_ticketService.ReadByID(id));
        }

        // POST api/Tickets
        [HttpPost]
        public ActionResult<Ticket> Post([FromBody] Ticket ticket)
        {
            try
            {
                return Ok(_ticketService.CreateNewTicket(ticket));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Tickets/5
        [HttpDelete("{id}")]
        public ActionResult<Ticket> Delete(int id)
        {
            try
            {
                _ticketService.DeleteTicket(id);
            return Ok($"Order with Id: {id} is Deleted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
