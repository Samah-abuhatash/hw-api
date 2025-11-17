using App1.Data;
using App1.Dtos;
using App1.Models;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProudctsController : ControllerBase
    {
        ApplicationDbContext context = new ApplicationDbContext();

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = context.proudcts.ToList();

           
            var productDto = new List<Createproudct>();

           
            foreach (var product in products)  
            {
                productDto.Add(new Createproudct()
                {
                    Name = product.Name,
                     Description = product.Description
                });
            }

            
            return Ok(new { products = productDto });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = context.proudcts.Find(id);

            if (product == null)
                return NotFound();

           
            var productDto = new Createproudct()
            {
                Name = product.Name,
                Description=product.Description

            };

          
            return Ok(new { productDto });
        }

        [HttpPost("")]
        public IActionResult Create(Createproudct request)
        {
            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
              
            };
            context.proudcts.Add(product);
            context.SaveChanges();

            return Ok(new { message = "success" });
        }
        [HttpDelete("")]
        public IActionResult Delete(int id)
        {

            var product = context.proudcts.Find(id);
            context.proudcts.Remove(product);
            context.SaveChanges();
            return Ok(new { message = "success" });


        }
        [HttpPatch("{id}")]
        public IActionResult update(Product request,int id )
        {
            var product = context.proudcts.Find(id);
            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            context.SaveChanges();
            return Ok(new { message = "success" });

        }
    }
}
