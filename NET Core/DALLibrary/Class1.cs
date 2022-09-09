using System;
using System.Data;
using System.Data.SqlClient;

namespace DALLibrary
{
    public class DBConnect
    {
        string connect = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=StemDB;Integrated Security=true;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        public int InsertNewCustomer(ModelCustomer cm)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", cm.CustName);
                cmd.Parameters.AddWithValue("@add", cm.CustAddress);
                cmd.Parameters.AddWithValue("@mno", cm.CusMobile);
                cmd.Parameters.AddWithValue("@email", cm.CustEmail);
                cmd.Parameters.AddWithValue("@gen", cm.CustGender);
                cmd.Parameters.AddWithValue("@pwd", cm.Password);
                SqlParameter cid = new SqlParameter("@cid", SqlDbType.Int);
                cid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(cid);
                var res = cmd.ExecuteNonQuery();
                if (res == 1) return (int)cid.Value;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return 0;
        }


        public int InsertNewBook(ModelBook bm)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@title", bm.Title);
                cmd.Parameters.AddWithValue("@cat", bm.Category);
                cmd.Parameters.AddWithValue("@auth", bm.AuthorName);
                cmd.Parameters.AddWithValue("@pages", bm.Pages);
                cmd.Parameters.AddWithValue("@price", bm.Price);

                SqlParameter isbn = new SqlParameter("@isbn", SqlDbType.Int);
                isbn.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(isbn);
                var res = cmd.ExecuteNonQuery();
                if (res == 1) return (int)isbn.Value;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
    }
}
