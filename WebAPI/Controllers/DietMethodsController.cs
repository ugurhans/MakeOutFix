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
    public class DietMethodsController : ControllerBase
    {
        private IDietMethodService _dietMethodService;

        public DietMethodsController(IDietMethodService dietMethodService)
        {
            _dietMethodService = dietMethodService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dietMethodService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult getById(int dietMethodId)
        {
            var result = _dietMethodService.GetById(dietMethodId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("adddietmethod")]
        public IActionResult addCategory(DietMethod dietMethod)
        {
            var result = _dietMethodService.Add(dietMethod);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatedietmethod")]
        public IActionResult updateProduct(DietMethod dietMethod)
        {
            var result = _dietMethodService.Update(dietMethod);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletedietmethod")]
        public IActionResult deleteCategory(DietMethod dietMethod)
        {
            var result = _dietMethodService.Delete(dietMethod);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
