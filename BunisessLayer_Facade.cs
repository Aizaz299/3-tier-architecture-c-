using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace B_Layer
{
    public class Facade
    {
        public static Facade Instance = null;
        public static Facade GetController()
        {
            if (Instance == null)

                 Instance = new Facade();

            return Instance;
            
        }

        public string MyMessage(string name, int age, string city, string profession, string email) {

            Logic l = new Logic();
            return l.MyLogic(name, age, city,profession,email);
        }
        public DataSet MySearchData(int id) {

            Logic bl = new Logic();
            return bl.MySearchLogic(id);

        }
    }
}
