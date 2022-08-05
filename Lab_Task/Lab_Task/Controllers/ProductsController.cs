using Lab_Task.DTOs;
using Lab_Task.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(ProductPostDto dto) 
        {
            if (!dto.Photo.CheckImg(2)) return BadRequest();

           
        }
    }
}
