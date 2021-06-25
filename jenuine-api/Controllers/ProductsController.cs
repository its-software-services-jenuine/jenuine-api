using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Its.Jenuiue.Api.Services.Products;
using Its.Jenuiue.Api.ModelsViews;
using Its.Jenuiue.Api.ModelsViews.Organization;
using Its.Jenuiue.Api.Models.Organization;
using AutoMapper;

namespace Its.Jenuiue.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService service;
        private readonly IMapper mapper;

        public ProductsController(IProductsService svc, IMapper mppr)
        {
            service = svc;
            mapper = mppr;
        }

        [HttpGet]
        [Route("org/{id}/action/GetProducts")]
        public IEnumerable<MVProduct> Get(string id) //[FromBody] MVProduct data
        {
            service.SetOrgId(id);
            var products = service.GetProducts(null, new QueryParam());

            var result = mapper.Map<IEnumerable<MProduct>, IEnumerable<MVProduct>>(products);
            return result;
        }
    }
}
