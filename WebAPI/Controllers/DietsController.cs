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
    public class DietsController : ControllerBase
    {
        private IDietService _dietService;

        public DietsController(IDietService dietService)
        {
            _dietService = dietService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dietService.GetAllDays();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getalldto")]
        public IActionResult GetAllDto()
        {
            var result = _dietService.GetAllDietDto();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getalldtobyid")]
        public IActionResult GetAllDtoById(int methodId)
        {
            var result = _dietService.GetAllDietDtoByMethod(methodId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult getById(int dietId)
        {
            var result = _dietService.GetById(dietId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("adddiet")]
        public IActionResult addCategory(Diet diet)
        {
            var result = _dietService.Add(diet);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatediet")]
        public IActionResult updateProduct(Diet diet)
        {
            var result = _dietService.Update(diet);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletediet")]
        public IActionResult deleteCategory(Diet diet)
        {
            var result = _dietService.Delete(diet);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
