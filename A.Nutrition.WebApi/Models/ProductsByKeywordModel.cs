using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using A.Nutrition.WebApi.Models;

namespace A.Nutrition.WebApi.Models
{
    [DataContract]
    public class ProductsByKeywordModel
    {
        public ProductsByKeywordModel()
        {
            this.Products = new HashSet<ProductModel>();
        }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "keyword")]
        public string Keyword { get; set; }

        [DataMember(Name = "products")]
        public ICollection<A.Nutrition.WebApi.Models.ProductModel> Products { get; set; }
    }
}