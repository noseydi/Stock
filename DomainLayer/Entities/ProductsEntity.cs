using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class ProductsEntity
    {
        [Key] public int ProductID { get; set; }
        public string ProductName { get; set; }
        public char? Dimensions { get; set; }
    }
}
