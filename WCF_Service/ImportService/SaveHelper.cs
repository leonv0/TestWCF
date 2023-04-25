using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportService
{
    internal class SaveHelper
    {
        public SaveHelper(string connectionString, Person person)
        {

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[SavePerson]", con);
            cmd.CommandTimeout = 10;
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@Flight_Number", SqlDbType.VarChar).Value = person.Flight_Number;
            cmd.Parameters.Add("@Flight_Sheduled_Time", SqlDbType.Time).Value = person.Flight_Sheduled_Time;
            cmd.Parameters.Add("@Flight_Sheduled_Date", SqlDbType.Date).Value = person.Flight_Sheduled_Date;
            cmd.Parameters.Add("@Estimate_Arriva", SqlDbType.DateTime).Value = person.Estimate_Arrival;
            cmd.Parameters.Add("@Arrival", SqlDbType.DateTime).Value = person.Arrival;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = person.Name;
            cmd.Parameters.Add("@Reservation_Number", SqlDbType.VarChar).Value = person.Reservation_Number;
            cmd.Parameters.Add("@DocumentNumber", SqlDbType.VarChar).Value = person.DocumentNumber;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
