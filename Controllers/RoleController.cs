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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: api/<RoleController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roleService.GetAll());
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_roleService.Get(id));
        }

        // POST api/<RoleController>
        [HttpPost]
        public IActionResult Create(Role role)
        {
            var result = _roleService.Create(role);
            return Ok(result);
        }

        // PUT api/<RoleController>
        [HttpPut]
        public IActionResult Update(Role role)
        {
            return Ok(_roleService.Update(role));
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_roleService.Delete(id));
        }
    }
}
