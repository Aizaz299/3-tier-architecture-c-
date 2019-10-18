using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DataLayer
{
    public class DataStore
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aziaz\source\repos\3 tire project\DataLayer\Database1.mdf;Integrated Security=True");

        public string SaveMyData(string name, int age, string city, string profession, string email)
        {
            SqlCommand comm = new SqlCommand("insert into std(Name,age,City,profession,email)values('" + name + "','" + age + "','" + city + "','"+profession+"','"+email+"')", con);
            con.Open();
            comm.ExecuteNonQuery();


            return "DATA SAVED";
        }

        public DataSet MyRetriveData(int id)
        {

            DataSet dset = new DataSet();
            SqlDataAdapter adop = new SqlDataAdapter("select * from std where id =" + id + "", con);
            adop.Fill(dset);
            adop.Dispose();
            return dset;

        }

        // DataSet dset = new DataSet();
        //SqlDataAdapter adop = new SqlDataAdapter("con);
    }
       

            
        
}
