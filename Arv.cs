namespace OOPinlamning1
{
    //Arv Exempel
    public class Sports
    {
        public string name;

        public string age;


        public void Kick()
        {
            Console.WriteLine("In this sport you can kick");
        }
        public void Stretch()
        {
            Console.WriteLine("In this sport you have to stretch");
        }
    }

    public class TaekwonDo : Sports
    {

        public new void Kick()

        {
            Console.WriteLine("In TaeKwon-Do you kick and punch!");
        }
        public new void ColorBelts()

        {
            Console.WriteLine("In TaeKwon-Do you have color belts to decide your rank");
        }
    }
}

        
