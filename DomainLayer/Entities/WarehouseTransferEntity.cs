//using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class WarehouseTransferEntity
    {
        [Key] public int TransferID { get; set; }
        public int? FromWarehouseID { get; set; }
        public int? ToWarehouseID { get; set; }
        public string SerialNumber { get; set; }
        public DateTime TransferDate { get; set; }

    }
}
