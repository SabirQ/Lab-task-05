using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Task.DTOs
{
    public class ProductPostDto
    {
        public string Name { get; set; }
        public IFormFile Photo { get; set; }
    }
}
