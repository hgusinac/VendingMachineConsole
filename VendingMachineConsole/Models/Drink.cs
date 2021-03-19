namespace VendingMachineConsole
{
    public class Drink : Product
    {
        bool cold;
        public Drink(int price, int id, bool cold) : base(price, id)
        {
          this.cold = cold;
        }

        public override string Examine()
        {
            return ($"Drink, {price:C} {id} {cold}");

        }

        public override string Use()
        {
            return "Drink slow its cold";
        }
    }
}
