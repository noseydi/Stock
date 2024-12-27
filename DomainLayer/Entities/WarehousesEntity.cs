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
        [Key] public string WarehouseID { get; set; }
        public string Warehousename { get; set; }
        public string CityID { get; set; }
        public string AreaInSquareMeters { get; set; }

    }
}
