using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PayrollManagement.Models;

namespace PayrollManagement.DataAccessLayer
{
    public class DBMethods
    {
        string connect = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=Payroll;Integrated Security=true;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        public string Login(int uid, string password,string role)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_LoginUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@role", role);

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


        public int InsertUser(UserModels um)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", um.UserName);
                cmd.Parameters.AddWithValue("@pass", um.Password);
                cmd.Parameters.AddWithValue("@role", um.UserRole);
                SqlParameter uid = new SqlParameter("@uid", SqlDbType.Int);
                uid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(uid);
                var res = cmd.ExecuteNonQuery();
                if (res == 1) return (int)uid.Value;

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



        public int InsertEmployee(EmployeeModels em){
            try{
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", em.Empname);
                cmd.Parameters.AddWithValue("@dept", em.Dept);
                cmd.Parameters.AddWithValue("@email", em.EmailId);
                cmd.Parameters.AddWithValue("@mno", em.MobNo);
                cmd.Parameters.AddWithValue("@loc", em.Location);
                cmd.Parameters.AddWithValue("@desg", em.Desg);

                SqlParameter eid = new SqlParameter("@eid", SqlDbType.Int);
                eid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(eid);
                var res = cmd.ExecuteNonQuery();
                if (res == 1) return (int)eid.Value;

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

        public bool DeleteEmployee(EmployeeModels em)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", em.EmpId);

                var res = cmd.ExecuteNonQuery();
                if (res == 1) return true;
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

        public bool ChangePassword(UserModels um)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_ChangePassword", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@uid", um.UserId);
                cmd.Parameters.AddWithValue("@pass", um.Password);

                var res = cmd.ExecuteNonQuery();
                if (res == 1) return true;
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


        public bool UpdateProfile(EmployeeModels em)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_UpdateProfile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@eid", em.EmpId);
                cmd.Parameters.AddWithValue("@name", em.Empname);
                cmd.Parameters.AddWithValue("@email", em.EmailId);
                cmd.Parameters.AddWithValue("@mno", em.MobNo);
                cmd.Parameters.AddWithValue("@loc", em.Location);


                var res = cmd.ExecuteNonQuery();
                if (res == 1) return true;
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

        public int GenerateSalary(SalaryModels sm)
        {
            try
            {
                con = new SqlConnection(connect);
                con.Open();
                cmd = new SqlCommand("sp_GenerateSalary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empid", sm.EmpId);
                cmd.Parameters.AddWithValue("@desg", sm.Desg);
                cmd.Parameters.AddWithValue("@sal", sm.Salary);
                SqlParameter sid = new SqlParameter("@sid", SqlDbType.Int);
                sid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sid);
                var res = cmd.ExecuteNonQuery();
                if (res == 1) return (int)sid.Value;
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

    }
}