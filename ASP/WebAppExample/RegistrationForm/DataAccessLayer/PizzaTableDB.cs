using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using RegistrationForm.Models;

namespace RegistrationForm.DataAccessLayer
{
    public class PizzaFormDB
    {
        string connstr = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = StemDBAyush;" +
            " Integrated Security = True";
        SqlConnection con = null;
        SqlCommand cmd = null;


        public int insertPizzaTable(PizzaOrder model)
        {

            try
            {
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into PizzaForm values(@nm,@phn,@amt)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nm", model.CustomerName);
                cmd.Parameters.AddWithValue("@phn", model.PhoneNum);
                cmd.Parameters.AddWithValue("@amt", model.Amount);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
    }
}
