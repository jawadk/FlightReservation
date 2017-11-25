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

namespace TicketReservationApplication
{
    public partial class AddFlight : Form
    {
        Connection con;

        public AddFlight()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_FlightName.Text != "")
                {
                    if (dateTimePicker1.Text != "" && dateTimePicker2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && txtbox_Amount.Text != "" && comboBox3.Text != "")
                    {
                        if (comboBox1.Text != comboBox2.Text)
                        {
                            CRUDOperation.addFlightInsertion(txtbox_FlightName.Text, comboBox1.Text, comboBox2.Text, dateTimePicker2.Text, dateTimePicker1.Text, comboBox3.Text, Convert.ToInt32(txtbox_Amount.Text));
                            MessageBox.Show("Congrats. New flight has been added in system");

                            this.Hide();
                            AdminDashboard admindash = new AdminDashboard();
                            admindash.Show();                            
                        }
                        else
                        {
                            MessageBox.Show("Departure and Arrival flights can not be same");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Flight Date/time, Amount and Flight types details are required");
                    }
                }
                else
                {
                    MessageBox.Show("Enter PIA flight name");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error occurred");
            }
            
        }


        private void AddFlight_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            try
            {
                con = new Connection();
                string q = "Select name from city";
                OleDbCommand cmd = new OleDbCommand(q, con.connect());
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                    comboBox2.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't find the Correct ID");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }
    }
}
