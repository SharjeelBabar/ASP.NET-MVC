using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EidAssignment.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrition  { get; set; }
        public string Icon { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId  { get; set; }
    }
}