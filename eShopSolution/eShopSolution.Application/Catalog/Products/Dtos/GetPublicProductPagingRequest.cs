using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }

        //public string KeyWord { get; set; }

        //public List<int> CategoryIds { get; set; }


    }
}
