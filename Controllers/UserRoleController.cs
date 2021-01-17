using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Entities;
using Notes_App.IServices;

namespace Notes_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService _userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        // GET: api/<UserRoleController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userRoleService.GetAll());
        }

        // GET api/<UserRoleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userRoleService.Get(id));
        }

        // POST api/<UserRoleController>
        [HttpPost]
        public IActionResult Create(UserRole userRole)
        {
            var result = _userRoleService.Create(userRole);
            return Ok(result);
        }

        // PUT api/<UserRoleController>
        [HttpPut]
        public IActionResult Update(UserRole userRole)
        {
            return Ok(_userRoleService.Update(userRole));
        }

        // DELETE api/<UserRoleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_userRoleService.Delete(id));
        }
    }
}
