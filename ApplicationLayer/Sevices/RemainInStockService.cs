using DomainLayer.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Sevices
{
    internal class RemainInStockService : IRemainInStock
    {
        public int Count(int stockID, int productQuantity, char dimensions)
        {
            throw new NotImplementedException();
        }

        public string ProductSerialNumber(int productID)
        {
            throw new NotImplementedException();
        }

        public int StockID(int stockID)
        {
            throw new NotImplementedException();
        }
    }
}
