using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

public partial class addNregQS : System.Web.UI.Page
{
    Connect c;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnprint_Click(object sender, EventArgs e)
    {
        try
        {
            if (dplpmode.SelectedItem.ToString() == "Cash" && (txtamt.Text == "" || txtpdate.Text == "" || rbltype.SelectedValue == "" || dplfor.SelectedItem.ToString() == "Please select a particular" || dplyear.SelectedItem.ToString() == "Please select a year" || dplfrm.SelectedItem.ToString() == "Please select a name"))
            {

                MsgBox("One of the required fields is missing, please check");
            }
            else if ((dplpmode.SelectedItem.ToString() == "Cheque" || dplpmode.SelectedItem.ToString() == "Teller/Bank Draft" || dplpmode.SelectedItem.ToString() == "Remita") && (txtamt.Text == "" || txtpdate.Text == "" || rbltype.SelectedValue == "" || txtmnumber.Text == "" || dplfor.SelectedItem.ToString() == "Please select a particular" || dplyear.SelectedItem.ToString() == "Please select a year" || dplbank.SelectedItem.ToString() == "Please select a bank" || dplfrm.SelectedItem.ToString() == "Please select a name"))
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
                    Response.Redirect(Request.Url.AbsoluteUri);
                    //lblmsg.Visible = true;
                    //lblmsg.Text = "Successfully Added, Thanks.";

                    //gridView.Visible = true;
                    //GridView2.Visible = true;
                    //Label6.Visible = true;
                    //popGrid();
                    //popGridsum();


                }
                else if (dplfor.SelectedItem.ToString() == "Registration Fee")
                {
                    popRegistrationFee();
                    poppayment();
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
                    txtamt.Text = "";
                    txtmnumber.Text = "";
                    txtpdate.Text = "";
                    dplfor.SelectedIndex = 0;
                    dplyear.SelectedIndex = 0;
                    dplpmode.SelectedIndex = 0;
                    dplbank.SelectedIndex = 0;
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
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into AccreditationFee(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType ,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popannualConference()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into AnnualConference( Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popBecert()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into BECERT(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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


    public void popEndowmentFund()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into EndowmentFund(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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
    public void popInductionFees()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into InductionFee(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popRegistrationFee()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into RegistrationFee(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popRegistrationFormFee()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into RegistrationFormFee(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popRubberStamp()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into RuberStamp(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popPersonalisedSeal()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into PersonalisedSeal(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popProceedings()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into Proceedings(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popProfessionalClinic()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into ProfessionalClinic(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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

    public void popSummit()
    {
       
        lbltype.Text = rbltype.SelectedItem.Text;
        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into SummitFee(Recieved_From, Sum_of, Being_Payment_for, Payment_Mode, Mode_Number, Transaction_Date, MemberType,BankName ,PaymentYear) Values('" + dplfrm.Text.ToUpper() + "','" + txtamt.Text.ToUpper() + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + lbltype.Text.ToUpper() + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

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


    public void poppayment()
    {

        int i;
        c = new Connect();
        c.shola();
        c.com.CommandText = "Insert into payment(Recieved_From, Sum_of,Being_Payment_for, Payment_Mode,Mode_Number, Transaction_Date,BankName ,PaymentYear) Values('" + dplfrm.Text.ToString().ToUpper() + "','" + txtamt.Text + "','" + dplfor.Text.ToString().ToUpper() + "','" + dplpmode.Text.ToString().ToUpper() + "','" + txtmnumber.Text.ToUpper() + "','" + txtpdate.Text + "','" + dplbank.Text.ToString().ToUpper() + "','" + dplyear.Text.ToString().ToUpper() + "')";
        i = c.com.ExecuteNonQuery();
        if (i > 0)
        {

            MsgBox("Successfully Added, Thanks.");

            Calendar1.SelectedDates.Clear();

        }
        else
        {
            lblmsg.Text = "Unsuccessful, Try again";


        }
    }



    //public void popGrid()
    //{
    //    try
    //    {
    //        c = new Connect();
    //        c.shola();
    //        c.com.CommandText = "Select SN, Sum_of, Being_Payment_for  from payment";
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
    //        c.com.CommandText = "Select Sum(Sum_of) as TotalAmount from payment";
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        c = new Connect();
        c.shola();
        c.com.CommandText = "delete from payment where Recieved_From='"+dplfrm.Text.ToString()+"'";
        int result = c.com.ExecuteNonQuery();
        // con.Close();
        if (result == 0)
        {

            lblmsg.Text = " ";
            ReportViewer2.Visible = false;
            

        }
        //gridView.Visible = false;
        //GridView2.Visible = false;
        //Label6.Visible = false;
        lblmsg.Visible = false;
        txtamt.Text = "";

        txtpdate.Text = "";
        txtmnumber.Text = "";



    }
    protected void btnCreateorder0_Click(object sender, EventArgs e)
    {
        string name = dplfrm.Text.ToString();
        ReportViewer2.Visible = true;
        ObjectDataSource1.SelectParameters["Recieved_From"].DefaultValue = name;
        ObjectDataSource1.DataBind();
        this.ReportViewer2.LocalReport.Refresh();
        lblmsg.Visible = false;
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



    protected void dplpmode_SelectedIndexChanged(object sender, EventArgs e)
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


    //public void calBal()
    //{ 

    //        int amt = Int32.Parse(dplbal.Text) - Int32.Parse(txtamt.Text);
    //       


    //}

    protected void txtreg_SelectedIndexChanged(object sender, EventArgs e)
    {

        txtamt.Text = "";
        lblmsg.Visible = false;
    }
    protected void rbltype_SelectedIndexChanged(object sender, EventArgs e)
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



    protected void dplfrm_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReportViewer2.Visible = false;
    }
}