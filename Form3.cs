using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SUPERMARKET
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }
        public string constring = "Data Source=DESKTOP-GFJKAGE\\SQLEXPRESS;Initial Catalog=\"Supermarket system Managment\";Integrated Security=True;Trust Server Certificate=True";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into loginform(Username,Password)values('" + txtusername.Text.ToString() + "','" + txtpassword.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("connection made successfuly..!");
            }
        }
    }
}
