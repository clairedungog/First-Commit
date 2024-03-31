using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihh
{
    public partial class Login : Form
    {
        private OleDbConnection con;
        private OleDbCommand com;
        private OleDbDataReader reader;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM Users WHERE Username = '" + textBox2.Text + "' AND Password = '" + textBox1.Text + "'";

            com = new OleDbCommand(q, con);

            con.Open();
            reader = com.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Success");
                MenuScript script = new MenuScript();
                script.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid");
            }

            reader.Close();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
