using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketReservationApplication
{
    public partial class Login : Form
    {
        Connection con;
        string userName;
        string userPass;

        public Login()
        {
            InitializeComponent();
        }

        public Login(string _user, string _pass)
        {
            userName = _user;
            userPass = _pass;
        }

        public bool getLogin(string userName, string userPass)
        {
            con = new Connection();
            bool _check;
            string query = "SELECT UserName, Password FROM admin WHERE UserName = '" + userName + "' AND Password = '" + userPass + "'";
            OleDbCommand cmd = new OleDbCommand(query, con.connect());
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _check = true;
            }
            else
            {
                _check = false;
            }
            return _check;
        }       

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainObj = new MainForm();
            MainObj.Show();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                bool login = getLogin(textBox1.Text, textBox2.Text);
                if (login == true)
                {
                    this.Close();
                    AdminDashboard ADbj = new AdminDashboard();
                    ADbj.Show();               
                }
                else if (login == false)
                {
                    MessageBox.Show("invalid username and password");
                }
                
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please enter username and password");
            }
        }
    }
}
