using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaysController : ControllerBase
    {
        private IDayService _dayService;

        public DaysController(IDayService dayService)
        {
            _dayService = dayService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dayService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult getById(int dayId)
        {
            var result = _dayService.GetById(dayId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("addday")]
        public IActionResult addCategory(Day day)
        {
            var result = _dayService.Add(day);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updateday")]
        public IActionResult updateProduct(Day day)
        {
            var result = _dayService.Update(day);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deleteday")]
        public IActionResult deleteCategory(Day day)
        {
            var result = _dayService.Delete(day);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
