using System.Text;
using Xunit;
using VendingMachineConsol;
using VendingMachineConsole.Data;
using VendingMachineConsole;

namespace VendingMachineConsol.Tests.Model
{

    public class DrinkTest
    {
        [Fact]
        public void TestConstructor()
        {

            //Arrange
            Drink drink;

            //Act
            drink = new Drink(50, 1, true);

            //Assert
            Assert.Equal(50, drink.price);

        }
        [Fact]
        public void Test_Examine()
        {
            //Arrange
            Drink drink = new Drink(50, 1, true);
            string result;

            // Act
            result = drink.Examine();

            //Assert
            Assert.Equal("Drink, 50,00 kr 1 True", result);
        }
        [Fact]
        public void Test_Use()
        {
            //Arrange
            Drink drink = new Drink(50, 1, true);
            string result;

            // Act
            result = drink.Use();

            //Assert
            Assert.Equal("Drink slow its cold", result);
        }

    }
}
