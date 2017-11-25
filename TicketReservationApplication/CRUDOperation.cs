using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationApplication
{
    class CRUDOperation
    {
        //Connection con;

        public static void addFlightInsertion(string flightName, string fromCity, string toCity, string departureTD, string arrivalDT, string flightType, int price)
        {
            Connection con = new Connection();
            string insertQuery;
            insertQuery = String.Format("INSERT INTO `flights` (`name`, `fromcity`, `tocity`, `FlightDeparture`, `FlightArrival`, `FlightType`, `Price`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", flightName, fromCity, toCity, departureTD, arrivalDT, flightType, price).ToString();
            OleDbCommand cmd = new OleDbCommand(insertQuery, con.connect());
            cmd.ExecuteNonQuery();
        }

        public DataTable getTable(string query)
        {
            Connection con = new Connection();
            try
            {
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con.connect());
                adapter.Fill(table);
                return table;
            }
            catch (Exception excp)
            {
                throw excp;
            }
        }
    }
}
