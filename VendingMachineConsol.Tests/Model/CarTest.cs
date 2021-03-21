using System.Text;
using Xunit;
using VendingMachineConsol;
using VendingMachineConsole.Data;
using VendingMachineConsole;

namespace VendingMachineConsol.Tests.Model
{

    public class CarTest
    {
        [Fact]
        public void TestConstructor()
        {

            //Arrange
            Car car;


            //Act
            car = new Car(500, 3, true);

            //Assert
            Assert.Equal(500, car.price);

        }
        [Fact]
        public void Test_Examine()
        {
            //Arrange
            Car car = new Car(500, 3, true);
            string result;

            // Act
            result = car.Examine();

            //Assert
            Assert.Equal("Car , 500,00 kr 3 True", result);
        }
        [Fact]
        public void Test_Use()
        {
            //Arrange
            Car car = new Car(500, 3, true);
            string result;

            // Act
            result = car.Use();

            //Assert
            Assert.Equal("Drive safe this car is fast!!", result);
        }

    }
}
