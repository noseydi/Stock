using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class InventoryTransactionsEntity
    {
        [Key] public int TransactionID { get; set; }
        public string TransactionType { get; set; }
        public int? WarehouseID { get; set; }
        public int? ProductID { get; set; }
        public string SerialNumber { get; set; }
        public int? Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
