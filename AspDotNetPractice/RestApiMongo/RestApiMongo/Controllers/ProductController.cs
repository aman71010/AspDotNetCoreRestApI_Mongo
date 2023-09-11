using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiMongo.Models;
using RestApiMongo.Repository;

namespace RestApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct(Product prod)
        {
            repo.AddProduct(prod);
            return Ok("Added");
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(repo.GetProductById(id));
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllProduct()
        {
            return Ok(repo.GetAllProducts());
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            repo.DeleteProduct(id);
            return Ok("Deleted");
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult UpdateProduct(int id, Product prod)
        {
            repo.UpdateProduct(id, prod);
            return Ok("Updated");
        }
    }
}
