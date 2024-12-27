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
        [Key] public string TransactionID { get; set; }
        public string TransactionType { get; set; }
        public string WarehouseID { get; set; }
        public string ProductID { get; set; }
        public string SerialNumber { get; set; }
        public string Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
