using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.ApplicationService;

namespace WebShopSpacesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
         private readonly IUserService _UserService;

        public UsersController(IUserService UserService)
        {
            _UserService = UserService;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            try
            {
                return Ok(_UserService.ReadAllUser());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<Ticket> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater then 0");

            return Ok(_UserService.FindUserByID(id));
        }


        // POST: api/Users
        [HttpPost]
        public ActionResult<Ticket> Post([FromBody] User user)
        {
            try
            {
                return Ok(_UserService.CreateNewUser(user));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Ticket> Put(int id, [FromBody] User user)
        {
            if (id < 1 || id != user.UserId)
            {
                return BadRequest("Parameter Id and order ID must be the same");
            }

            return Ok(_UserService.UpdateUser(user));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Ticket> Delete(int id)
        {
            try
            {
                _UserService.DeleteUser(id);
                return Ok($"Order with Id: {id} is Deleted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

    }
}
