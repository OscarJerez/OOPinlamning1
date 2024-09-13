namespace OOPinlamning1
{
    public class Program
    {
        //HERE IS HERITAGE EXAMPLE
        static void Main(string[] args)
        {
            Sports allsport = new Sports();
            allsport.Kick();

            TaekwonDo Offense = new TaekwonDo();
            Offense.Kick();

            TaekwonDo Colorbelt1 = new TaekwonDo();
            Colorbelt1.ColorBelts();

            //HERE IS POLYMORPHISM EXAMPLE

            Furniture furniture = new Furniture();
            furniture.UseageOfFuriture();

            Sofa sofa = new Sofa();
            sofa.UseageOfFuriture();

            Bed bed = new Bed();
            bed.UseageOfFuriture();

            //HERE IS ENCAPSULATION EXAMPLE

            //Clubmenbers clubmember1 = new Clubmenbers("Lord Oscar, Male"); false

            //HERE IS ABSTRACT EXAMPLE

            Boxing boxing = new Boxing();
            boxing.Punch();

            
            





            //Oscar Jerez Arias



            Console.ReadLine();
        }
    }
    

    
}