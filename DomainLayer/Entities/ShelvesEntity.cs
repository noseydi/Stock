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
        [Key] public string ShelfID { get; set; }
        public string WarehouseID { get; set; }
        public string SpacePerShelfCM { get; set; }
        public string Levels { get; set; }


    }
}
