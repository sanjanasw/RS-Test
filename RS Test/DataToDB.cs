using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RS_Test
{
    class DataToDB
    {
        public String addData(int i, String StudentName, String Grade, String SchoolName, String Passout)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SHATTER\Documents\Test_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Insert into Test(Id , Name, Grade, School, Pdate) values ('" + i +"','" + StudentName + "','" + Grade + "','" + SchoolName + "','" + Passout + "');";
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "Added Succesfull......";
            }
            catch (SqlException ex)
            {
                return Convert.ToString(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public String delData()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SHATTER\Documents\Test_DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Delete From Test;";
            Console.WriteLine(query);
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "Delete Succesfull......";
            }
            catch (SqlException ex)
            {
                return Convert.ToString(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
