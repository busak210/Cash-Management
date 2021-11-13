using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

public partial class passReset : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "update Logintb set password='" + txtnpwd.Text.ToString().Trim() + "' where username= '" + txtuser.Text.ToString().Trim() + "' and password='" + txtpwd.Text.ToString().Trim() + "'";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Updated, Thanks.");

                

            }
            else
            {
                lblmsg.Text = "The old password and username do not match, Try again.";
                txtuser.Text = "";
                txtpwd.Text = "";
                txtnpwd.Text = "";


            }


        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    private void MsgBox(string sMessage)
    {
        string msg = "<script language=\"javascript\">";
        msg += "alert('" + sMessage + "');";
        msg += "</script>";
        Response.Write(msg);
    }

    protected void btnlog_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}