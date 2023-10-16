namespace Controllers;

using Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Dtos.Outgoing;
using Models;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase {
    private readonly IProductRepository _repo;
    private readonly IMapper _mapper;

    public ProductController(IMapper mapper, IProductRepository repo)
    {
        _mapper = mapper;
        _repo = repo;
    }

    [HttpGet]
    public async Task<IEnumerable<ProductInfo>> GetProductList() {
        IEnumerable<Product> products = await _repo.GetList();

        return _mapper.Map<IEnumerable<Product>, IEnumerable<ProductInfo>>(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDetail>> GetProductDetail(int id) {
        var prod = await _repo.GetDetail(id);

        if (prod == null) return NotFound(id);

        return _mapper.Map<Product, ProductDetail>(prod);
    }
}