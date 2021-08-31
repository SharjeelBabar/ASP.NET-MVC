using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EidAssignment.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Fileimage { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}