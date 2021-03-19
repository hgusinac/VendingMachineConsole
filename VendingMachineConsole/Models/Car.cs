
namespace VendingMachineConsole
{
    public class Car : Product
    {
        bool diesel;
        public Car(int price, int id,bool diesel) : base(price,id)
        {
            this.diesel = diesel;
        }
        public override string Examine()
        {
            return ($"Car , {price:C}");
        }
        public override string Use()
        {
            return ("Drive safe this car is fast!!");
        }
    }
}
