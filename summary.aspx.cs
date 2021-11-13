using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class summary : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            if (dplyear.SelectedItem.ToString() == "Please select a year" || dplpart.SelectedItem.ToString() == "Please select a particular" || txtdfrom.Text == "" || txtdto.Text == "")
            {

                MsgBox("One of the required fields is missing, please check");
            }
            else if (dplyear.SelectedItem.ToString() == "Please select a year")
            {
                MsgBox("One of the required fields is missing, please check");

            }
            else if (dplpart.SelectedItem.ToString() == "Please select a particular")
            {
                MsgBox("One of the required fields is missing, please check");

            }
            else
            {
                if (dplpart.SelectedItem.ToString() == "Accreditation Fee")
                {

                    summaryAccreditionPM();
                    gridView0.Visible = true;
                   
                }
                else if (dplpart.SelectedItem.ToString() == "Annual Conference")
                {

                    summaryAnnualConferencePM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "BCERT")
                {

                    summaryBCERTPM();
                    gridView0.Visible = true;

                }
                else if (dplpart.SelectedItem.ToString() == "Endowment Fund")
                {

                    summaryEf();
                    gridView0.Visible = true;
                }
                else if (dplpart.SelectedItem.ToString() == "Induction Fee")
                {

                    summaryInductionPM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "Practice Licence Fee")
                {



                    summaryPLPM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "Registration Fee")
                {

                    summaryRegistrationFeePM();

                    gridView0.Visible = true;

                }
                else if (dplpart.SelectedItem.ToString() == "Registration Form Fee")
                {

                    summaryRegistrationFormFeePM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "Rubber Stamp Fee")
                {

                    summaryRubberStampPM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "Personalised Seal Fee")
                {

                    summaryPersonalSealPM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "Proceedings Fee")
                {

                    summaryProceedingsPM();
                    gridView0.Visible = true;

                }
                else if (dplpart.SelectedItem.ToString() == "Professional Clinic Fee")
                {

                    summaryProfessionalCPM();
                    gridView0.Visible = true;


                }
                else if (dplpart.SelectedItem.ToString() == "Summit Fee")
                {

                    summarySummitPM();
                    gridView0.Visible = true;

                }
                else
                {
                    lblmsg.Text = "Unsuccessful, Try again";
                    txtdfrom.Text = "";
                    txtdto.Text = "";

                }
            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    public void summaryAccreditionPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM AccreditationFee Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryAnnualConferencePM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM AnnualConference Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryBCERTPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM BECERT Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryEf()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM EndowmentFund Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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

    public void summaryInductionPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM InductionFee Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryPersonalSealPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM PersonalisedSeal Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryPLPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM RenewalFee Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryProceedingsPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM Proceedings Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryProfessionalCPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM ProfessionalClinic Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryRegistrationFeePM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM RegistrationFee Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryRegistrationFormFeePM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM RegistrationFormFee Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summaryRubberStampPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM RuberStamp Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    public void summarySummitPM()
    {
        try
        {

            c = new Connect();
            c.shola();
            c.com.CommandText = "SELECT DISTINCT Payment_Mode, Sum(Sum_of) As TotalAmount FROM SummitFee Where Transaction_Date BETWEEN '" + txtdfrom.Text.ToString() + "' AND '" + txtdto.Text.ToString() + "' AND PaymentYear='" + dplyear.Text.ToString() + "' Group by Payment_Mode";
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
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtdfrom.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        txtdto.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
        Calendar2.Visible = false;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Calendar2.Visible = true;
    }


    private void MsgBox(string sMessage)
    {
        string msg = "<script language=\"javascript\">";
        msg += "alert('" + sMessage + "');";
        msg += "</script>";
        Response.Write(msg);
    }


    protected void dplyear_SelectedIndexChanged(object sender, EventArgs e)
    {
        gridView0.Visible = false;
    }
    protected void dplpart_SelectedIndexChanged(object sender, EventArgs e)
    {
        gridView0.Visible = false;
    }
}