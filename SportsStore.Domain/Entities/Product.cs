using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SportsStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue= false)]
        public int ProductID { get; set; }
        
        [Required(ErrorMessage="Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { set; get; }
        
        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage = "Please enter a positive price")]
        public decimal Price { set; get; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { set; get; }

        public byte[] ImageData { set; get; }

        public string ImageMimeType { set; get; }
    }
}
