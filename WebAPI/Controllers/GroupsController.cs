using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private IGroupService _groupService;
        public GroupsController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet(template:"getall")]
        public IActionResult GetList()
        {
            var result = _groupService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
            
        }
        [HttpGet(template: "getbyid")]
        public IActionResult Get(int groupId)
        {
            var result = _groupService.GetById(groupId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPost(template: "add")]
        public IActionResult Add(Group group)
        {
            var result = _groupService.Add(group);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPost(template: "delete")]
        public IActionResult Delete(Group group)
        {
            var result = _groupService.Delete(group);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPost(template: "update")]
        public IActionResult Update(Group group)
        {
            var result = _groupService.Update(group);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
    }
}
