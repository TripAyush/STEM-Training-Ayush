protected void btnLogin_Click(object sender, EventArgs e){
    try{
        BankingDB db = new BankingDB();
        var res = db.Login(int.Parse(txtcid.Text),txtpass.Text);
        output.Text = res;
        if(res == "Login Success"){
            Session["cid"] = long.Parse(txtcid.Text);
            // FormsAuthentication.RedirectFromLoginPage(txtcid.Text,false);
            Response.Redirect("Home.aspx");
        }
    }
    catch(Exception ex ){
        output.Text = ex.Message;
    }
}

protected void btnRegister_Click(object sender, EventArgs e){
    try{
        BankingDB db = new BankingDB();
        CustomerModel m = new CustomerModel();

        m.CustName = cname.Text;
        m.CustAddress = caddr.Text;
        m.MobNo = long.Parse(cmob.Text);
        m.EmailId = cemail.Text;
        m.Password = cpass.Text;
        if(rmale.Checked) m.Gender = rmale.Text;
        if(rfemale.Checked) m.Gender = rfemale.Text;
        if(rother.Checked) m.Gender = rother.Text;

        var res = db.InsertCustomer(m);
        if(res > 0) output.Text = "New CustomerID is : " + res;
        }
    catch (Exception ex){
        output.Text = ex.Message;
        }
}

protected void Page_Load(object sender, EventArgs e){
    if(Session["cid"] == null){
        Response.Redirect("Login.aspx");
    }
    
    else{
        txtcid.Text = Session["cid"].ToString();
    }
}

protected void btnNewAcc_Click(object sender, EventArgs e){
    try{
        AccountsModel am = new AccountsModel();
        am.CustId = int.Parse(txtcid.Text);
        am.AccountType = DropDown1.SelectedItem.Text;
        if(ractive.Checked) am.Status = ractive.Text;
        if(rinactive.Checked) am.Status = rinactive.Text;

        BankingDB db = new BankingDB();
        var res = db.InsertAccount(am);
        if(res > 0) output.Text = "New AccountID is : " + res;
    }
    catch (Exception ex){
        output.Text = ex.Message;
    }
}


protected void btnTransact_Click(object sender, EventArgs e){
    try{
        TransactionModel t = new TransactionModel();
        t.AccountNo = long.Parse(accid.Text);

        foreach(ListItem li in rbtt.Items){
            if(li.Selected) t.TransType = li.Text;
        }

        tm.TransAmount = decimal.Parse(tamount.Text);
        BankingDB db = new BankingDB();
        var res = db.InsertTransaction(tm);
        output.Text = res;
        GridView1.DataBind();

    }
    catch(Exception ex){
        output.Text = ex.Message;
    }
}