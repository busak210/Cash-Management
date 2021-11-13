using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class search : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        try
        {
            gridView.Visible = true;
            gridView0.Visible = false;
            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT RegNo,Name,Date_Registered,Outstanding,Phone,Email FROM QS where Name LIKE '%" + txtname.Text.ToString().Trim() + "%'";
            c.adapt.SelectCommand = c.com;
            c.adapt.Fill(c.ds);
            gridView.DataSource = c.ds;
            gridView.DataBind();
        }

        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        try
        {
            gridView.Visible = true;
            gridView0.Visible = false;
            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT RegNo,Name,Date_Registered,Outstanding,Phone,Email FROM QS where RegNo= '"+ txtregno.Text.ToString().Trim() + "'";
            c.adapt.SelectCommand = c.com;
            c.adapt.Fill(c.ds);
            gridView.DataSource = c.ds;
            gridView.DataBind();
        }

        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            gridView0.Visible = true;
            gridView.Visible = false;
            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT Name,Phone,Email FROM NRegQS where Name LIKE '%" + txtnqsname.Text.ToString().Trim() + "%'";
            c.adapt.SelectCommand = c.com;
            c.adapt.Fill(c.ds);
            gridView0.DataSource = c.ds;
            gridView0.DataBind();
        }

        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
}