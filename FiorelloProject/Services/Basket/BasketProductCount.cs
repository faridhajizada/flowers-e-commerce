﻿//using System;
//using Azure.Core;
//using FiorelloProject.ViewModels;
//using Newtonsoft.Json;

//namespace FiorelloProject.Services.Basket
//{
//    public class BasketProductCount : IBasketProductCount
//    {

//        private readonly HttpContextAccessor _contextAccessor;

//        public BasketProductCount(HttpContextAccessor contextAccessor)
//        {
//            _contextAccessor = contextAccessor;
//        }

//        public int CalculateBasketProductCount()
//        {


//            string basket = _contextAccessor.HttpContext.Request.Cookies["basket"];
//            var products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

//            return products.Sum(p => p.BasketCount);
//        }
//    }
//}

//using FiorelloProject.Services.Basket;
//using FiorelloProject.ViewModels;
//using Newtonsoft.Json;

//namespace FirelloProject.Services.Basket
//{
//    public class BasketProductCount : IBasketProductCount
//    {
//        private readonly IHttpContextAccessor _httpContextAccessor;

//        public BasketProductCount(IHttpContextAccessor httpContextAccessor)
//        {
//            _httpContextAccessor = httpContextAccessor;
//        }

//        public int CalculateBasketProductCount()
//        {
//            string basket = _httpContextAccessor.HttpContext.Request.Cookies["basket"];
//            var products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
//            return products.Sum(p => p.BasketCount);
//        }
//    }
//}

