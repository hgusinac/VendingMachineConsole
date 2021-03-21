using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;



namespace VendingMachineConsole.Data

{
    public class VendingMachine : IVending
    {
        private int moneyPool = 0;
        private readonly int[] denominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
       public  List<Product> products = new List<Product>();

        public VendingMachine()
        {
            Additems();
            
        }
        public Product Purchase(int productId)
        {
            Product purchase;

            //hitta produktetn och få fram priset.  hur mycket pengar har du så får du produkt eller null. find by id
            foreach (Product product in products)
            {
                if (product.id == productId)
                {
                    if (product.price <= moneyPool)
                    {
                        moneyPool = moneyPool - product.price;
                        return product;
                    }
                    else
                    {
                        throw new Exception("Not enough money"); 
                    }

                }
            }
            return null;
        }
        public List<Product> ShowAll()// ändra produkterna till en sb som retunerar en string. 
        {
            return products;
           
        }


        public bool InsertMoney(int money)
        {
            if (denominations.Contains(money))
            {
                moneyPool = money + moneyPool;
                return true;
            }
            else
            {
                return false;
            }

        }
        public string EndTransaction()
        {
            StringBuilder sb = new StringBuilder();


            foreach (int coin in denominations)
            {
                if (moneyPool / coin > 0)
                {
                    sb.Append($"Returning: {moneyPool / coin} * {coin}");
                }
                moneyPool %= coin;
            }
            return sb.ToString();

        }
        public void Additems()
        {
            products.Add(new Car(500, 1, true));
            products.Add(new Car(500, 2, true));
            products.Add(new Sandwich(50, 3, true));
            products.Add(new Sandwich(50, 4, true));
            products.Add(new Drink(25, 5, false));
            products.Add(new Drink(25, 6, false));

        }
    }
}
