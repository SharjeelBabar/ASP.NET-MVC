using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EidAssignment.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ShippingAddress { get; set; }
        public virtual User Client { get; set; }
        public int ClientId { get; set; }
        
        public virtual Product Products { get; set; }
        public int ProductId { get; set; }
        public virtual OrderStatus OrderStatus{ get; set; }
        public int OrderStatusId { get; set; }
        public int Amount { get; set; }
    }
}