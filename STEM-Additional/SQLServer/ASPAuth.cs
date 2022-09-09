using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ASPNETSecurity.DataAccessLayer{
    public class DBMethods{
        string connect = "Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=StemDB;Integrated Security=True;";
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        public bool Login(string email,string password){
            try{
                con = new SqlConnection(connect);
                con.Open();
                string query = "SELECT * FROM Login WHERE email=@em AND password@pwd";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@em", email);
                cmd.Parameters.AddWithValue("@pwd", password);
                r = cmd.ExecuteReader();
                if(r.Read()) return true;
            }
            catch (System.Exception){
                throw;
            }
            finally{
                con.Close();
            }
            return false;
        }
    }
}





// Login Method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNETSecurity.DataAccessLayer;

namespace ASPNETSecurity{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login2_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                DBMethods db = new DBMethods();
                var res = db.Login(Login2.UserName, Login2.Password);

                if (res == true)
                {
                    FormsAuthentication.RedirectFromLoginPage(Login2.UserName, true);
                }
                else
                {
                    Login2.FailureText = "Invalid Credentials";
                }
            }
            catch (Exception ex)
            {
                Login2.FailureText = ex.Message;
            }
        }
    }
}


protected void btnSubmit_Click(object sender, EventArgs e){
    if(yesradio.Checked) model.Attendance = yesradio.Text;
    if(yesradio.Checked) model.Attendance = yesradio.Text;

    model.FName = txtname;
    model.FName = txtname;
    model.FName = long.Parse(txtname);

    if(yesradio.Checked) model.Attendance = yesradio.Text;
    if(yesradio.Checked) model.Attendance = yesradio.Text;

    foreach(ListItem li in   .Items){
        if(li.Selected) model.Games += li.Text + ",";
    }
    
}


public int InsertReunion(ReunionModel model){
    try{
        con = new SqlConnection(connect);
        con.Open();
        cmd = new SqlCommand("sp_InsertReunion",con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@attn", model.Attendance);
        cmd.Parameters.AddWithValue("@fn", model.FName);
        cmd.Parameters.AddWithValue("@ln", model.LName);
        cmd.Parameters.AddWithValue("@pn", model.PhNo);
        cmd.Parameters.AddWithValue("@meals", model.Meals);
        cmd.Parameters.AddWithValue("@games", model.Games);
        cmd.Parameters.AddWithValue("@ques", model.Questions);
        SqlParameter memid = new SqlParameter("@memid",SqlDbType.Int);
        memid.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(memid);
        var res = cmd.ExecuteNonQuery();
        if(res > 0) return (int)memid.Value;
    }
    catch (System.Exception)
    {
        
        throw;
    }
    finally{
        con.Close();
    }
    return 0;
}



public List<ReunionModel> SelectReunion() {
    List<ReunionModel> data = new List<ReunionModel>();

    try{
        con = new SqlConnection(connect);
        con.Open();
        cmd = new SqlCommand("sp_SelectReunion",con);
        cmd.CommandType = CommandType.StoredProcedure;
        var r = cmd.ExecuteReader();

        while(r.Read()){
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
    catch (System.Exception){
        throw;
    }
    finally{
        con.Close();
    }
    return data;
}


protected void btnSelect_Click(object sender, EventArgs e){
    try{
        DBMethods db = new DBMethods();
        var res = db.SelectReunion();
        GridView1.DataSource = res;
        GridView1.DataBind();
    }
    catch (Exception ex){
        
        output.Text = ex.Message;
    }
}