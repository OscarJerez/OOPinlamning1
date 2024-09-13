
using System.Reflection;

namespace OOPinlamning1
    //Inkapsling Exempel
{
    public class Clubmenbers
    {
        private string membersname;
        private string gender;

        public Clubmenbers(string membersname, string gender)
        {
            Membersname = membersname;
            Gender = gender;
        }

        public string Membersname
        {
            get { return membersname; }
            set { membersname = value; }

        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }



    }
}
