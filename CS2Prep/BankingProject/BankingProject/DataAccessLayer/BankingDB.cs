using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using BankingProject.Models;

namespace BankingProject.DataAccessLayer
{
    public class BankingDB
    {
        string connect = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=StemDB;Integrated Security=true;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        public string Login(int cid, string password)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_LoginCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@pass", password);
                r = cmd.ExecuteReader();
                string result = "";
                if (r.Read()) result = "Login Success";
                else result = "Login Failure";

                return result;
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int InsertCustomer(CustomerModel cm)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", cm.CustName);
                cmd.Parameters.AddWithValue("@add", cm.CustAddress);
                cmd.Parameters.AddWithValue("@mno", cm.MobNo);
                cmd.Parameters.AddWithValue("@email", cm.EmailId);
                cmd.Parameters.AddWithValue("@gen", cm.Gender);
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

        public long InsertAccounts(AccountsModel am)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertAccounts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", am.CustId);
                cmd.Parameters.AddWithValue("@acctype", am.AccountType);
                cmd.Parameters.AddWithValue("@status", am.Status);
                SqlParameter accid = new SqlParameter("@accid", SqlDbType.BigInt);
                accid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(accid);
                var res = cmd.ExecuteNonQuery();
                if (res == 1) return (long)accid.Value;

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

        public string InsertTransaction(TransactionModel tm)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accno", tm.AccountNo);
                cmd.Parameters.AddWithValue("@tt", tm.TransType);
                cmd.Parameters.AddWithValue("@tamt", tm.TransAmount);
                SqlParameter tid = new SqlParameter("@tid", SqlDbType.Int);
                tid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(tid);
                var res = cmd.ExecuteNonQuery();
                if (res > 0) return "The Transaction ID is : " + tid.Value;

            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return "";
        }
    }
}