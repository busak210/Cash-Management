using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class imprestDetail : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtpdate.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void btnprint_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtpurpose.Text == "" || txtamt.Text == "" || txtpdate.Text == "" || txtremarks.Text == "" || dplrecieved.SelectedItem.ToString() == "Please select a name" || dplyear.SelectedItem.ToString() == "Please select a year")
            {

                MsgBox("One of the required fields is missing, please check");
            }
            else
            {
                int i;
                c = new Connect();
                c.shola();
                c.com.CommandText = "Insert into imprest(Purpose,Amount,RecievedBy,DateRecieved,Remarks,Year) Values('" + txtpurpose.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplrecieved.Text.ToString().ToUpper() + "','" + txtpdate.Text + "','" + txtremarks.Text.ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
                i = c.com.ExecuteNonQuery();
                if (i > 0)
                {

                    //lblmsg.Text = "Successfully Added, Thanks.";
                    MsgBox("Successfully Added, Thanks.");
                    Response.Redirect(Request.Url.AbsoluteUri);
                    Calendar1.SelectedDates.Clear();
                }
                else
                {
                    MsgBox("Unsuccessfully Added, Try Again.");
                    Response.Redirect(Request.Url.AbsoluteUri);

                }
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

}