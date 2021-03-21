namespace VendingMachineConsole
{
    public abstract class Product
    {

        public readonly int price;
        public int id;

        public Product(int price,int id)
        {
            this.price = price;
            this.id = id;

        }

       
        public abstract string Examine();
        public abstract string Use();

    }
}