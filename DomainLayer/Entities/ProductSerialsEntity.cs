using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class ProductSerialsEntity
    {
        [Key] public string SerialNumber { get; set; }
        public int? ProductID { get; set; }
        public int ShelfID { get; set; }
        public string Position { get; set; }
    }
}
