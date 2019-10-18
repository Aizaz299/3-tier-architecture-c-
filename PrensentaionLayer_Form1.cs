using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_Layer;

namespace _3_tire_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             Facade fc = Facade.GetController();
             MessageBox.Show(fc.MyMessage(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text,textBox5.Text,textBox6.Text));


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Facade fc = Facade.GetController();
            ds = fc.MySearchData(int.Parse(textBox4.Text));
            dataGridView1.DataSource = ds.Tables[0];

        }
        
    }
}
