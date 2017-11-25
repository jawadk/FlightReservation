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
    public partial class FightsDetail : Form
    {
        public FightsDetail()
        {
            InitializeComponent();
        }

        private void FightsDetail_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flight_review_form flightbook = new Flight_review_form();
            flightbook.Show();
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                         
    }
}
