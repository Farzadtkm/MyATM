using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace CDICollegeATMMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=ATM;integrated security=true");
            SqlCommand cmd = new SqlCommand("INSERT INTO Information(Name, Email, Phone, PIN) VALUES(@Name, @Email, @Phone, @PIN)", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", Nametxt.Text);
            cmd.Parameters.AddWithValue("@Email", emailTxt.Text);
            cmd.Parameters.AddWithValue("@Phone", phoneNumberTxt.Text);
            cmd.Parameters.AddWithValue("@PIN", pinTxt.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            string path = "C:\\Users\\Farzad Torkaman\\Desktop\\MyATM\\Customers.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(Nametxt.Text + "," + pinTxt.Text + "," + phoneNumberTxt.Text + "," + emailTxt.Text);
            }

            if (i != 0)
            {
                MessageBox.Show(i + " Data Saved");
            }
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supervisor supervisor = new Supervisor();
            supervisor.Show();
        }
    }
}
