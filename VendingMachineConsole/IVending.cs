using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsole
{
    public interface IVending
    {
        public Product Purchase(int productId);

        public List<Product> ShowAll();

        public bool InsertMoney(int money);

        public string EndTransaction();
    }
}
