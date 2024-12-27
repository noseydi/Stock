using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class ShelvesEntity
    {
        [Key] public int ShelfID { get; set; }
        public int? WarehouseID { get; set; }
        public string SpacePerShelfCM { get; set; }
        public int? Levels { get; set; }


    }
}
