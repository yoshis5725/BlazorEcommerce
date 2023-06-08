using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyStore.Server.Data;
using MyStore.Shared.Models;


namespace MyStore.Server.Controllers;


[Route("api/[controller]")]
[ApiController]


public class ProductController : Controller
{
    // fields
    private readonly DataContext _context;


    // constructor
    public ProductController(DataContext context)
    {
        _context = context;
    }

    
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }
}