using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { set; get; }
        public PagingInfo PagingInfo { set; get; }
        public string CurrentCategory { set; get; }
    }
}