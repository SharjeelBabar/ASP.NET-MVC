using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EidAssignment.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string EndTime { get; set; }
        public int Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Descrpition { get; set; }
        public string Image { get; set; }
        public virtual User Merchant { get; set; }
        public int MerchantId { get; set; }
        public virtual ProductStatus ProductStatus { get; set; }
        public int ProductStatusId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
    }
}