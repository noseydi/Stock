using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class WarehousesEntity
    {
        [Key] public int WarehouseID { get; set; }
        public string Warehousename { get; set; }
        public int? CityID { get; set; }
        public string AreaInSquareMeters { get; set; }

    }
}
