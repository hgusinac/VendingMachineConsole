using System;
using VendingMachineConsole.Data;

namespace VendingMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            Console.WriteLine(vendingMachine.ShowAll());
            Console.WriteLine(vendingMachine.InsertMoney(1000));
            Console.WriteLine(vendingMachine.Purchase(1).Use());
            Console.WriteLine(vendingMachine.EndTransaction());
        }
    }
}
