namespace VendingMachineConsole
{
    public class Sandwich : Product
    {
        bool lchf;
        public Sandwich(int price, int id,bool lchf) : base(price, id)

        {
            this.lchf = lchf;
        }
        public override string Examine()
        {
            return ($"Sandwich , {price:C} {id} {lchf} ");
        }
        public override string Use()
        {
            return ("Best  Sandwich in  town!!");
        }
    }
}