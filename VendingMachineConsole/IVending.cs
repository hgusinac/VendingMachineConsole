using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsole
{
    public interface IVending
    {
        public Product Purchase(int productId);

        public string ShowAll();

        public bool InsertMoney(int money);

        public string EndTransaction();
    }
}
