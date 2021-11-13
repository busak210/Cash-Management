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

public partial class main : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnprint_Click(object sender, EventArgs e)
    {
        try
        {
            if (dplpmode.SelectedItem.ToString() == "Cash" && (txtreg.Text == "" || txtamt.Text == "" || txtpdate.Text == "" || rbltype.SelectedValue == "" || dplfor.SelectedItem.ToString() == "Please select a particular" || dplyear.SelectedItem.ToString() == "Please select a year"))
            {

                MsgBox("One of the required fields is missing, please check");
            }
            else if ((dplpmode.SelectedItem.ToString() == "Cheque" || dplpmode.SelectedItem.ToString() == "Teller/Bank Draft" || dplpmode.SelectedItem.ToString() == "Remita") && (txtreg.Text == "" || txtamt.Text == "" || txtpdate.Text == "" || rbltype.SelectedValue == "" || txtmnumber.Text == "" || dplfor.SelectedItem.ToString() == "Please select a particular" || dplyear.SelectedItem.ToString() == "Please select a year" || dplbank.SelectedItem.ToString() == "Please select a bank"))
            {
                MsgBox("One of the required fields is missing, please check");
            }
            else if (dplpmode.SelectedItem.ToString() == "Please select mode")
            {
                MsgBox("One of the required fields is missing, please check");

            }
            else
            {
                if (dplfor.SelectedItem.ToString() == "Accreditation Fee")
                {

                    popAccreditationFee();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);

                    //popGrid();
                    //popGridsum();
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;


                }
                else if (dplfor.SelectedItem.ToString() == "Annual Conference")
                {
                    popannualConference();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "BCERT")
                {
                    popBecert();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Endowment Fund")
                {
                    popEndowmentFund();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();

                }
                else if (dplfor.SelectedItem.ToString() == "Induction Fee")
                {
                    popInductionFees();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Practice Licence Fee")
                {


                    popRenewal();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    Calendar1.SelectedDates.Clear();
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = false;
                    //lblmsg.Text = "Successfully Added, Thanks.";


                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = false;
                    //popGrid();
                    //popGridsum();
                    ////updateRenewal();


                }
                else if (dplfor.SelectedItem.ToString() == "Registration Fee")
                {
                    popRegistrationFee();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Registration Form Fee")
                {
                    popRegistrationFormFee();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Rubber Stamp Fee")
                {
                    popRubberStamp();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Personalised Seal Fee")
                {
                    popPersonalisedSeal();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Proceedings Fee")
                {
                    popProceedings();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Professional Clinic Fee")
                {
                    popProfessionalClinic();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Summit Fee")
                {
                    popSummit();
                    poppayment();
                    txtreg.Text = "";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    txtreg.Focus();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else
                {
                    lblmsg.Text = "Unsuccessful, Try again";
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                }
            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    public void popAccreditationFee()
    {

        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into AccreditationFee(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();
            }
            else
            {
                lblmsg.Text = "";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }

    }
    public void popannualConference()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into AnnualConference(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }

    }

    public void popBecert()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into BECERT(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();
            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }


    public void popEndowmentFund()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into EndowmentFund(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();
            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    public void popInductionFees()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into InductionFee(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    public void popRegistrationFee()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into RegistrationFee(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();
            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    public void popRegistrationFormFee()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into RegistrationFormFee(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    public void popRubberStamp()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into RuberStamp(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    public void popPersonalisedSeal()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into PersonalisedSeal(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    public void popProceedings()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into Proceedings(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }


        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    public void popProfessionalClinic()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into ProfessionalClinic(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();
            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    public void popSummit()
    {
        try
        {
            lbltype.Text = rbltype.SelectedItem.Text;
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into SummitFee(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }


    public void poppayment()
    {
        try
        {
            if (dplfor.SelectedItem.ToString() != "Practice Licence Fee")
            {
                int i;

                c = new Connect();
                c.shola();
                c.com.CommandText = "Insert into payment(RegNo,Recieved_From, Sum_of,Being_Payment_for, Payment_Mode,Mode_Number, Transaction_Date, BankName,PaymentYear) Values('" + txtreg.Text.ToString().ToUpper() + "','" + dplfrm.Text.ToString().ToUpper() + "','" + txtamt.Text.ToString() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToString().ToUpper() + "','" + txtpdate.Text.ToString() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
                i = c.com.ExecuteNonQuery();
                if (i > 0)
                {

                    //lblmsg.Text = "Successfully Added, Thanks";
                    //MsgBox("Successfully Added, Thanks.");
                }
                else
                {
                    lblmsg.Text = "Unsuccessful, Try again";


                }
            }
            else
            {
                int amt = Int32.Parse(dplbal.Text) - Int32.Parse(txtamt.Text);
                int i;
                c = new Connect();
                c.shola();
                c.com.CommandText = "Insert into payment(RegNo,Recieved_From, Sum_of,Being_Payment_for, Payment_Mode,Mode_Number, Transaction_Date, BankName,FOutstandingBalance,CurOutstandingBalance,PaymentYear) Values('" + txtreg.Text.ToString().ToUpper() + "','" + dplfrm.Text.ToString().ToUpper() + "','" + txtamt.Text + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplbal.Text.ToString().ToUpper() + "','" + amt.ToString() + "','" + dplyear.Text.ToString().ToUpper() + "')";
                i = c.com.ExecuteNonQuery();
                if (i > 0)
                {

                    //lblmsg.Text = "Successfully Added, Thanks";
                    //MsgBox("Successfully Added, Thanks.");
                }
                else
                {
                    lblmsg.Text = "Unsuccessful, Try again";


                }
            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    public void reneSatisfy()
    {
        try
        {
            poppayment();
            calRenewalBal();

            lbltype.Text = rbltype.SelectedItem.Text;
            int amt = Int32.Parse(dplbal.Text) - Int32.Parse(txtamt.Text);
            int i;
            c = new Connect();
            c.shola();
            c.com.CommandText = "Insert into RenewalFee(RegNo, Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date,FOutstandingBalance,CurOutstandingBalance,MemberType, BankName,PaymentYear) Values('" + txtreg.Text.ToUpper() + "','" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + dplbal.Text.ToString().ToUpper() + "','" + amt.ToString() + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
            i = c.com.ExecuteNonQuery();
            if (i > 0)
            {

                //lblmsg.Text = "Successfully Added, Thanks.";
                MsgBox("Successfully Added, Thanks.");

                Calendar1.SelectedDates.Clear();

            }
            else
            {
                lblmsg.Text = "Unsuccessful, Try again";
                txtamt.Text = "";
                txtmnumber.Text = "";
                txtpdate.Text = "";


            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    public void popRenewal()
    {
        try
        {
            if (dplbal.Text.ToString() == "" || dplbal.Text.ToString() == "0" || dplbal.Text.ToString() == "LATE")
            {

                MsgBox("This member is not Owing the Practice Licence Fee, Thanks.");

                Calendar1.SelectedDates.Clear();
            }
            else
            {
                reneSatisfy();

            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }


    //public void popGrid()
    //{
    //    try
    //    {
    //        c = new Connect();
    //        c.shola();
    //        c.com.CommandText = "Select SN, Sum_of, Being_Payment_for  from payment where RegNo='" + txtreg.Text.ToString() + "'";
    //        c.adapt.SelectCommand = c.com;
    //        c.adapt.Fill(c.ds);
    //        gridView.DataSource = c.ds;
    //        gridView.DataBind();
    //    }

    //    catch (Exception me)
    //    {
    //        lblmsg.Text = me.Message;
    //    }

    //}

    //public void popGridsum()
    //{
    //    try
    //    {
    //        c = new Connect();
    //        c.shola();
    //        c.com.CommandText = "Select Sum(Sum_of) as TotalAmount from payment where RegNo='" + txtreg.Text.ToString() + "'";
    //        c.adapt.SelectCommand = c.com;
    //        c.adapt.Fill(c.ds);
    //        GridView2.DataSource = c.ds;
    //        GridView2.DataBind();
    //    }

    //    catch (Exception me)
    //    {
    //        lblmsg.Text = me.Message;
    //    }

    //}


    protected void btnCreateorder0_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtreg.Text;
            ReportViewer1.Visible = true;
            ObjectDataSource1.SelectParameters["RegNo"].DefaultValue = name;
            ObjectDataSource1.DataBind();
            this.ReportViewer1.LocalReport.Refresh();
            lblmsg.Visible = false;
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }

        //Label6.Visible = true;

    }

    //protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    //{
    //    string SN = gridView.DataKeys[e.RowIndex].Values["SN"].ToString();
    //    c = new Connect();
    //    c.shola();
    //    c.com.CommandText = "delete from payment where SN=" + SN;
    //    int result = c.com.ExecuteNonQuery();
    //    // con.Close();
    //    if (result == 1)
    //    {
    //        popGrid();
    //        lblmsg.Text = "      Deleted successfully.......    ";
    //    }
    //    popGridsum();

    //}
    //protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        string SN = Convert.ToString(DataBinder.Eval(e.Row.DataItem, "SN"));
    //        Button lnkbtnresult = (Button)e.Row.FindControl("ButtonDelete");
    //        if (lnkbtnresult != null)
    //        {
    //            lnkbtnresult.Attributes.Add("onclick", "javascript:return deleteConfirm('" + SN + "')");
    //        }
    //    }

    //}


    protected void dplfor_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (dplfor.SelectedItem.ToString() == "Practice Licence Fee")
            {
                dplbal.Visible = true;

                lblbal.Visible = true;

                lblmsg.Visible = false;


            }

            else
            {
                dplbal.Visible = false;

                lblbal.Visible = false;

            }

        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    protected void dplpmode_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            if (dplpmode.SelectedItem.ToString() == "Cash" || dplpmode.SelectedItem.ToString() == "Please select mode")
            {
                Label8.Visible = false;
                Label9.Visible = false;
                txtmnumber.Visible = false;
                Label10.Visible = false;
                dplbank.Visible = false;
            }

            else
            {
                Label8.Visible = true;
                Label9.Visible = true;
                txtmnumber.Visible = true;
                Label10.Visible = true;
                dplbank.Visible = true;
            }



        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }


    public void calRenewalBal()
    {

        try
        {
            c = new Connect();
            c.shola();
            c.com.CommandText = "SpUpdatRenwal @registrationo, @amount";
            c.com.Parameters.Add(new SqlParameter("@registrationo", txtreg.Text));
            c.com.Parameters.Add(new SqlParameter("@amount", txtamt.Text));
            int result = c.com.ExecuteNonQuery();
            // con.Close();
            if (result == 0)
            {

                lblmsg.Text = " ";

            }
            else
            {
                lblmsg.Text = "Error ";
            }


        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    protected void txtreg_SelectedIndexChanged(object sender, EventArgs e)
    {

        txtamt.Text = "";
        lblmsg.Visible = false;
    }
    protected void rbltype_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (rbltype.SelectedIndex == 0)
            {

                lbltype.Text = "Individual";
            }
            else
            {
                lbltype.Text = "Firm";

            }
        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtpdate.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        Calendar1.Visible = false;

    }

    private void MsgBox(string sMessage)
    {
        string msg = "<script language=\"javascript\">";
        msg += "alert('" + sMessage + "');";
        msg += "</script>";
        Response.Write(msg);
    }


    protected void txtreg_TextChanged(object sender, EventArgs e)
    {
        txtamt.Text = "";
        txtpdate.Text = "";
        txtmnumber.Text = "";
        ReportViewer1.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            c = new Connect();
            c.shola();
            c.com.CommandText = "delete from payment where RegNo='" + txtreg.Text.ToString() + "'";
            int result = c.com.ExecuteNonQuery();
            // con.Close();
            if (result == 0)
            {

                lblmsg.Text = " ";
                ReportViewer1.Visible = false;
                txtreg.Text = "";
                txtreg.Focus();

            }
            //gridView.Visible = false;
            //GridView2.Visible = false;
            //Label6.Visible = false;
            //lblmsg.Visible = false;
            //txtamt.Text = "";
            //txtreg.Text = "";
            //txtpdate.Text = "";


        }
        catch (Exception me)
        {
            lblmsg.Text = me.Message;
        }
    }
    
}