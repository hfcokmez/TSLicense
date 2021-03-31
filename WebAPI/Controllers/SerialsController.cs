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
    public class SerialsController : ControllerBase
    {
        private ISerialService _serialService;
        public SerialsController(ISerialService serialService)
        {
            _serialService = serialService;
        }
        [HttpGet(template: "getall")]
        public IActionResult GetList()
        {
            var result = _serialService.GetList();
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
        public IActionResult GetById(int serialId)
        {
            var result = _serialService.GetById(serialId);
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
        public IActionResult Add(Serial serial)
        {
            var result = _serialService.Add(serial);
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
        public IActionResult Delete(Serial serial)
        {
            var result = _serialService.Delete(serial);
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
        public IActionResult Update(Serial serial)
        {
            var result = _serialService.Update(serial);
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
