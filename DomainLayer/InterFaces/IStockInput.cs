using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.InterFaces
{
    public interface IStockInput
    {
        public int StockID(int id);
        public string ProductSerialNumber(string serialNumber);
        public int? AreaInUse(int productQuantity, char dimensions);
    }
}
