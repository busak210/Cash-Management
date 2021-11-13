using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class imprest : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            c = new Connect();
            c.shola();
            c.com.CommandText = "Select username,password from ImprestLogintb where username='" + txtuser.Text + "' and password='" + txtpwd.Text + "'";
            c.dr = c.com.ExecuteReader();
            if (c.dr.Read())
            {
                Response.Redirect("imprestDetail.aspx");
                txtuser.Text = "";
                txtpwd.Text = "";

            }
            else
            {
                lblmsg.Text = "Invalid username or password, Contact admin pls.";
                txtuser.Text = "";
                txtpwd.Text = "";
            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
}