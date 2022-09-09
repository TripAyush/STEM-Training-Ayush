using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using RegistrationForm.Models;

namespace RegistrationForm.DataAccessLayer{
    public class RegTableDB{
        string connstr = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = StemDBAyush; Integrated Security = True";

        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader read = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        //Connected Architecture
        public int InsertRegTable(RegTableModel model){
            try{
                con = new SqlConnection(connstr);
                con.Open();
                string query = "insert into RegTable values(@nm,@add,@pwd,@gen,@q,@city,@sk,@age,@em)";
                cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@nm",model.Name);
                cmd.Parameters.AddWithValue("@add",model.Address);
                cmd.Parameters.AddWithValue("@pwd",model.Password);
                cmd.Parameters.AddWithValue("@gen",model.Gender);
                cmd.Parameters.AddWithValue("@q",model.Qualification);
                cmd.Parameters.AddWithValue("@city",model.City);
                cmd.Parameters.AddWithValue("@sk",model.SkillSets);
                cmd.Parameters.AddWithValue("@age",model.Age);
                cmd.Parameters.AddWithValue("@em",model.Email);
                int res = cmd.ExecuteNonQuery();
                if(res == 1) return 1;
            }
            catch (SqlException sql){
                throw sql;
            }
            catch (Exception ex){
                throw ex;
            }
            finally{
                con.Close();
            }
            return 0;
        }

    public List<RegTableModel> SelectData(){
    List<RegTableModel> data = new List<RegTableModel>();
    try{
        con = new SqlConnection(connstr);
        con.Open();
        cmd = new SqlCommand("Select * from RegTable", con);
        read = cmd.ExecuteReader();
        while (read.Read()){
            RegTableModel model = new RegTableModel();
            model.Name = read[0].ToString();
            model.Address = read[1].ToString();
            model.Password = read[2].ToString();
            model.Gender = read[3].ToString();
            model.Qualification = read[4].ToString();
            model.City = read[5].ToString();
            model.SkillSets = read[6].ToString();
            model.Age = int.Parse(read[7].ToString());
            model.Email = read[8].ToString();
            data.Add(model);
            }
        }
    catch(Exception ex){
        throw ex;
        }
    finally{
        con.Close();
        }
    
    return data;
    }

        public DataSet SelectDisconnected()
        {
            try
            {
                con = new SqlConnection(connstr);
                adp = new SqlDataAdapter("Select * from RegTable", con);
                ds = new DataSet();

                adp.Fill(ds, "RegTable");//Data set table
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
