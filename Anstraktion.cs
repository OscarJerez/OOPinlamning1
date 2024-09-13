namespace OOPinlamning1
{
    public abstract class Taekwondo
    {
        public abstract void Punch();
    }
    public class Boxing : Taekwondo
    {
        public override void Punch()
        {
            Console.WriteLine("In boxing you do not kick, you use only your punches!");
        }
    }
}
