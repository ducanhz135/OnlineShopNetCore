using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.Catalog.Products.Dto;
using eShopSolution.Application.Catalog.Products.Dtos;
using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public int Delete(int productId)
        {
            throw new NotImplementedException();
        }


        public PagedResult<ProductViewModel> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
