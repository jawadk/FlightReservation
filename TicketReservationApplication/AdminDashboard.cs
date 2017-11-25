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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void btn_AddFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlight addflight = new AddFlight();
            addflight.Show();
        }

        private void btn_ViewFlights_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllFlights AllFligths = new ViewAllFlights();
            AllFligths.Show();
        }
    }
}
