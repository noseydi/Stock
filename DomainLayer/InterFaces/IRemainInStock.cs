using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.InterFaces
{
    public interface IRemainInStock
    {
        public int StockID (int stockID);
        public string ProductSerialNumber (int productID);
        public int Count (int stockID);
    }
}
