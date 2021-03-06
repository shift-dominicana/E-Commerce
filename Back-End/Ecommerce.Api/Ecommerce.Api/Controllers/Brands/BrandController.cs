﻿using BussinesLayer.Interfaces.Brands;
using Common.Models.Brands;
using DataLayer.ViewModels.Brands;
using Ecommerce.Api.Controllers.Core;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers.Brands
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : CoreController<IBrandsService, Brand, BrandViewModel>
    {
        private IBrandsService _brandService;

        public BrandController(IBrandsService service) : base(service)
        {
            this._brandService = service;
        }

    }
}
