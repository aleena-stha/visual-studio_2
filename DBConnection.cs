using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstDesktop
{
    public class DBConnection
    {
        public static SqlConnection DBConnect()
        {
            var conn = new SqlConnection();

            conn.ConnectionString = "Data Source=Aleena-44;Initial Catalog=StudentsDb;Integrated Security=True;Encrypt=False";
            

            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }
        
        public static DataTable GetTableByQuery (string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adabter=
                    new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adabter.Fill(dt);
                return dt;



            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ExecuteNonQuery(string SqlQuery) //insert,update,delete
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
