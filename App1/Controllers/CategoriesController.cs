using App1.Data;
using App1.Dtos;
using App1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ApplicationDbContext context = new ApplicationDbContext();
        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = context.categories.ToList();

            var categoryDtos = categories.Select(c => new Createcategores
            {
                Name = c.Name
            }).ToList();

            return Ok(new { categories = categoryDtos });
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = context.categories.Find(id);

            if (category == null)
                return NotFound();

            var categoryDto = new Createcategores
            {
                Name = category.Name
            };

            return Ok(new { category = categoryDto });
        }


        [HttpPost]
        public IActionResult Create(Createcategores request)
        {
            var category = new Category
            {
                Name = request.Name
            };

            context.categories.Add(category);
            context.SaveChanges();

            return Ok(new { message = "Category created successfully" });
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = context.categories.Find(id);
            if (category == null)
                return NotFound();

            context.categories.Remove(category);
            context.SaveChanges();

            return Ok(new { message = "Category deleted successfully" });
        }


        [HttpPatch("{id}")]
        public IActionResult Update(int id, Createcategores request)
        {
            var category = context.categories.Find(id);
            if (category == null)
                return NotFound();

            category.Name = request.Name;
            context.SaveChanges();

            return Ok(new { message = "Category updated successfully" });
        }
    }


}

