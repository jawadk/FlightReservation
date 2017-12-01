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
    public partial class ReserveFlights : Form
    {
        public ReserveFlights()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void lable_Firstname_Click(object sender, EventArgs e)
        {

        }

        private void btn_SearchFight_Click(object sender, EventArgs e)
        {
            try
            {
                string query;

                if (comboBox5.Text == "ALL" || comboBox5.Text == "")
                {
                    query = "SELECT * From `flights` WHERE `fromcity` = '" + comboBox1.Text + "' AND  `tocity` = '" + comboBox2.Text + "' AND  `FlightDeparture` LIKE '%" + dateTimePicker1.Value.ToString().Split(' ')[0] + "%' AND  `FlightArrival` LIKE '%" + dateTimePicker2.Value.ToString().Split(' ')[0] + "%'";
                }
                else
                {
                    query = "SELECT * From `flights` WHERE `fromcity` = '" + comboBox1.Text + "' AND  `tocity` = '" + comboBox2.Text + "' AND  `FlightDeparture` LIKE '%" + dateTimePicker1.Value.ToString().Split(' ')[0] + "%' AND  `FlightArrival` LIKE '%" + dateTimePicker2.Value.ToString().Split(' ')[0] + "%' AND `FlightType` = '" + comboBox5.Text + "'";
                }
                DataTable dtable = new DataTable();
                CRUDOperation crud = new CRUDOperation();

                
                
                dtable = crud.getTable(query);
                dataGridView1.DataSource = dtable;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Booking";
                btn.Text = "Book Now";
                btn.Name = "btn";

                //Button test = new Button();
                //dataGridView1.Columns["Booking"].c

                btn.UseColumnTextForButtonValue = true;
                

                

                
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }


            //this.Hide();
            //FightsDetail Flightobj = new FightsDetail();
            //Flightobj.Show ();

        }

        private void ReserveFlights_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            //dateTimePicker2.Format = DateTimePickerFormat.Custom;
            //dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            try
            {
                Connection con = new Connection();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                //Write here your code...
                MessageBox.Show("Congrats..!!! Beta your flight has been booked. :P :P :P ;) :) :D :D :D :D :D :D :D :D :D :D :D");
            }
        }
    }
}
