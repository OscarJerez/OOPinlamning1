namespace OOPinlamning1
{
    //Polymorphism exempel
    public class Furniture

    {
        public string name;

        public string type;

        public virtual void UseageOfFuriture()
        {
            Console.WriteLine("This furiture is for indoor useage");
        }

    }
    public class Bed : Furniture
    {
        public override void UseageOfFuriture()
        {
            Console.WriteLine("The bed is used in the bedroom");
        }
    }
    public class Sofa : Furniture
    {
        public override void UseageOfFuriture()
        {
            Console.WriteLine("The sofa is used in the livingroom");
        }
    }
}

