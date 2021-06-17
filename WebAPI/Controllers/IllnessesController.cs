using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Entities.Concrate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IllnessesController : ControllerBase
    {
        private IIllnessService _illnessService;

        public IllnessesController(IIllnessService illnessService)
        {
            _illnessService = illnessService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _illnessService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult getById(int illnessId)
        {
            var result = _illnessService.GetById(illnessId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("addillness")]
        public IActionResult addCategory(Illness illness)
        {
            var result = _illnessService.Add(illness);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updateillness")]
        public IActionResult updateProduct(Illness illness)
        {
            var result = _illnessService.Update(illness);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deleteillness")]
        public IActionResult deleteCategory(Illness illness)
        {
            var result = _illnessService.Delete(illness);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
