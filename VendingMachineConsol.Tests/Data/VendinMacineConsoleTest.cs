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
            VendingMachine vm = new VendingMachine();
            int moneyPool = 200;
            
            //Act
           vm.InsertMoney(100);
            vm.InsertMoney(100);

            //Assert
            Assert.Equal(200, moneyPool);
        }

    }
}
