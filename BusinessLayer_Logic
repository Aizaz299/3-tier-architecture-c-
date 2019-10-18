using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;
namespace B_Layer
{
    class Logic
    {
        public string MyLogic(string name, int age, string city, string profession,string email)
        {
             DataStore ds = new DataStore();
            return ds.SaveMyData(name, age, city,profession,email);
        }

        public DataSet MySearchLogic(int id)
        {
            DataStore ds = new DataStore();
            return ds.MyRetriveData(id);

        }

    }
}
