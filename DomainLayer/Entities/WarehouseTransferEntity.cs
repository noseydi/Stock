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
        [Key] public string TransferID { get; set; }
        public string FromWarehouseID { get; set; }
        public string ToWarehouseID { get; set; }
        public string SerialNumber { get; set; }
        public DateTime TransferDate { get; set; }

    }
}
