using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationApplication
{
    public partial class ViewAllFlights : Form
    {
        public ViewAllFlights()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDash = new AdminDashboard();
            adminDash.Show();

        }

        private void ViewAllFlights_Load(object sender, EventArgs e)
        {
            //Select Quert to search all patients
            try
            {
                DataTable flight_table = new DataTable();
                CRUDOperation crud = new CRUDOperation();
                flight_table = crud.getTable("SELECT * From flights");
                dataGridView1.DataSource = flight_table;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message + " Sorry; Couldn't Search the Data");
            }
        }
    }
}
