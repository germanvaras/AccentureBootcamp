using DemoNorthwind.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly NorthwindContext context;
        public CategoryController(NorthwindContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public dynamic Get()
        {
            dynamic categories = (from c in context.Categories
                                        select new { c.CategoryName });
            return categories;
        }
        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            dynamic customer = (from c in context.Categories
                                where c.CategoryId == id 
                                select new { c.CategoryName });
            return customer;

        }
    }
}
