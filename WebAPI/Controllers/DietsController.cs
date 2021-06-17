using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Entities.Concrate;
using Entities.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietsController : ControllerBase
    {
        private IDietService _dietService;
        private IDayService _dayService;

        public DietsController(IDietService dietService, IDayService dayService)
        {
            _dietService = dietService;
            _dayService = dayService;
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
            //Add Days
            var result = _dietService.Add(diet);
            var existDay = diet.Days;
            foreach (var varDay in existDay)
            {
                varDay.DietId = diet.Id;
                _dayService.Add(varDay);
            }
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
