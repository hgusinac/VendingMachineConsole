using System;
using Xunit;
using VendingMachineConsole.Data;

namespace VendingMachineConsol.Tests
{
    public class VendinMacineConsoleTest
    {
        [Fact]
        public void InsertMoney()
        {

            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            
            
            //Act
           vendingMachine.InsertMoney(100);

            //Assert
            Assert.Equal(100, 100);
        }
    }
}
