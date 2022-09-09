using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using ASPNETSecurity.Models;

namespace ASPNETSecurity.DataAccessLayer
{
    public class DBMethods
    {
        string connect = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=StemDB;Integrated Security=True;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        public bool Login(string email, string password)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                string query = "SELECT * FROM Login WHERE email=@em AND password=@pwd";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@pwd", password);
                r = cmd.ExecuteReader();
                if (r.Read()) return true;
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public int InsertReunion(ReunionModel model)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertReunion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@attn", model.Attendance);
                cmd.Parameters.AddWithValue("@fn", model.FName);
                cmd.Parameters.AddWithValue("@ln", model.LName);
                cmd.Parameters.AddWithValue("@pn", model.PhNo);
                cmd.Parameters.AddWithValue("@meals", model.Meals);
                cmd.Parameters.AddWithValue("@games", model.Games);
                cmd.Parameters.AddWithValue("@ques", model.Questions);
                SqlParameter memid = new SqlParameter("@memid", SqlDbType.Int);
                memid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(memid);
                var res = cmd.ExecuteNonQuery();
                if (res > 0) return (int)memid.Value;
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return 0;
        }


        public int InsertStudent(TaskModel model)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fn", model.Name);
                cmd.Parameters.AddWithValue("@acc", model.accounts);
                cmd.Parameters.AddWithValue("@mar", model.marketing);
                cmd.Parameters.AddWithValue("@com", model.computing);
                cmd.Parameters.AddWithValue("@total", model.totalMarks);
                cmd.Parameters.AddWithValue("@aggregate", model.aggMarks);
                cmd.Parameters.AddWithValue("@grade", model.totalGrade);


                SqlParameter roll = new SqlParameter("@roll", SqlDbType.Int);
                roll.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(roll);
                var res = cmd.ExecuteNonQuery();
                if (res > 0) return (int)roll.Value;
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return 0;
        }


        public List<ReunionModel> SelectReunion()
        {
            List<ReunionModel> data = new List<ReunionModel>();

            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_SelectReunion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var r = cmd.ExecuteReader();

                while (r.Read())
                {
                    ReunionModel m = new ReunionModel();
                    m.MemId = (int)r[0];
                    m.Attendance = r[1].ToString();
                    m.FName = r[2].ToString();
                    m.LName = r[3].ToString();
                    m.PhNo = (long)r[4];
                    m.Meals = r[5].ToString();
                    m.Games = r[6].ToString();
                    m.Questions = r[7].ToString();
                    data.Add(m);
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return data;
        }
    }
}