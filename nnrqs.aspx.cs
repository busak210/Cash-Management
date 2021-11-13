using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class nnrqs : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into NRegQS(Name,Phone,Email) Values('" + txtfname.Text.ToUpper() + "','" + txtpnumber.Text.ToString().ToUpper() + "','" + txtemail.Text.ToString() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                Response.Redirect("addNregQS.aspx");

                txtfname.Text = "";
                txtpnumber.Text = "";
                txtemail.Text = "";

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtfname.Text = "";
                txtpnumber.Text = "";
                txtemail.Text = "";


            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
}