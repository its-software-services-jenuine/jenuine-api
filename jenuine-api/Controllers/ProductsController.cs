using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Its.Jenuiue.Api.Services.Products;
using Its.Jenuiue.Api.ModelsViews.Organization;

namespace Its.Jenuiue.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService service;

        public ProductsController(IProductsService svc)
        {
            service = svc;
        }

        [HttpGet]
        [Route("org/{id}/action/GetProducts")]
        public IEnumerable<MVProduct> Get(string id) //[FromBody] MVProduct data
        {
            service.SetOrgId(id);
            //var results = service.GetProducts(null, data.QueryParam);
Console.WriteLine("DEBUG [GetProducts] OrgId=[{0}]", id);
            return new List<MVProduct>();
        }
    }
}
