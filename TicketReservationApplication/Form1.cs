using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicketReservationApplication
{
    public partial class Form1 : Form
    {
        Connection con;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open the new form
            FightsDetail obj = new FightsDetail();
            obj.Show();

            //Close the Current Form
            this.Hide();

        }

        private void radio_btn_TwoWay_CheckedChanged(object sender, EventArgs e)
        {
            //Showing Arrival Label and dropdown on radio button click
            label_Arrival.Show();
            dateTimePicker2.Show();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            label_Arrival.Hide();
            dateTimePicker2.Hide();

            con = new Connection();

            string query = "select CityName from City";
            SqlCommand da = new SqlCommand(query, con.Connect());
            SqlDataReader reader = da.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
                comboBox2.Items.Add(reader[0].ToString());                                                
            }                 
        }

        private void radio_btn_Oneway_CheckedChanged(object sender, EventArgs e)
        {
            //Showing Arrival Label and dropdown on radio button click
            label_Arrival.Hide();
            dateTimePicker2.Hide();
        }
    }
}
