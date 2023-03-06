using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApiApp.Data;
using MyWebApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly ProductContext _context;

        public CategoryController(ProductContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categoryList = _context.Categories.ToList();
            return Ok(categoryList);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var categoryList = _context.Categories.SingleOrDefault(cate => cate.CategoryID == id);
            if (categoryList != null)
            {
                return Ok(categoryList);
            } else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreateNew(Categories categories)
        {
            try
            {
                var category = new Categories
                {
                    CategoryName = categories.CategoryName,
                };
                _context.Add(category);
                _context.SaveChanges();
                return Ok(category);
            } catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Categories categories)
        {
            try
            {
                var categoryList = _context.Categories.SingleOrDefault(cate => cate.CategoryID == id);
                if (categoryList != null)
                {
                    categoryList.CategoryName = categories.CategoryName;
                    _context.SaveChanges();
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
