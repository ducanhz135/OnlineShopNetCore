using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Application.Catalog.Products.Dto;
using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public int Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
