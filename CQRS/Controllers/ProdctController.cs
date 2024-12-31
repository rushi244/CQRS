using CQRS.Commands;
using CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProdctController : ControllerBase
    {
        
       private readonly ISender _sender;

        public ProdctController(ISender sender) => _sender = sender;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _sender.Send(new GetProductQueries());
            return Ok(products);
        }
        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] Product p)
        {
            await _sender.Send(new AddProductCommand(p));
            return StatusCode(201);
        }
    }
}
