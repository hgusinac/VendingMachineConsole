using System;
using Xunit;
using VendingMachineConsole.Data;
using System.Collections.Generic;
using VendingMachineConsole;

namespace VendingMachineConsol.Tests
{
    public class VendinMacineConsoleTest
    {
        public List<Product> Products { get; private set; }

        [Fact]
        public void Constructor()
        {

            //Arrange
            VendingMachine vendingMachine;

            //Act
            vendingMachine = new VendingMachine();
            //Assert
            Assert.Equal("", vendingMachine.EndTransaction());

        }
        [Fact]
        public void InsertMoney()
        {




        }

        [Fact]
        public void Showall()
        {
            VendingMachine vendingMachine = new VendingMachine();
            string productList;

            //Act
            productList = vendingMachine.ShowAll();

            //Assert
            Assert.Equal("1, Car,  500,00 kr 1 True\n2  Car , 500,00 kr 2 True\n3, Car, 500, 00 kr 3 True\n3, Sandwich, 50, 00 kr 3 True\n4, Sandwich, 50, 00 kr 4 True\n5, Drink, 25, 00 kr 5 False\n6, Drink, 25, 00 kr 6 False", productList);

       


        }


    }
}
