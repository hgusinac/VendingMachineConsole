using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using VendingMachineConsol;
using VendingMachineConsole.Data;
using VendingMachineConsole;

namespace VendingMachineConsol.Tests.Model
{
    
   public class SandwichTest
    {
        [Fact]
        public void TestConstructor()
        {

            //Arrange
            Sandwich sandwich;

            //Act
            sandwich = new Sandwich(100,2,true);

            //Assert
            Assert.Equal(100,sandwich.price);

        }
        [Fact]
        public void Test_Examine()
        {
            //Arrange
            Sandwich sandwich = new Sandwich(100, 2, true);
            string result;

            // Act
            result = sandwich.Examine();

            //Assert
            Assert.Equal("Sandwich , 100,00 kr 2 True ", result);
        }
        [Fact]
        public void Test_Use()
        {
            //Arrange
            Sandwich sandwich = new Sandwich(100,2,true);
            string result;

            // Act
            result = sandwich.Use();

            //Assert
            Assert.Equal("Best  Sandwich in  town!!", result);
        }

    }
}
