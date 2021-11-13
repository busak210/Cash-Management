<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <table style="width: 100%">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td style="background-color: #FFFFFF; font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bolder;">Search Registered Quantity Surveyors</td>
                        <td style="background-color: #FFFFFF; font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bolder">Search Non-registered Quantity Surveyors</td>
                    </tr>
                    <tr>
                        <td style="width: 768px">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 768px">
                            <table style="width: 98%">
                                <tr>
                                    <td style="width: 225px">
                                        <asp:TextBox ID="txtname" runat="server" Width="210px" CssClass="form-control"></asp:TextBox>
                                    </td>
                                    <td style="width: 203px">
                                        <asp:Button ID="Button2" runat="server" Text="Search By Name" OnClick="Button2_Click" CssClass="btn-lg" />
                                    </td>
                                    <td style="width: 224px">
                                        <asp:TextBox ID="txtregno" runat="server" Width="210px" CssClass="form-control"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button3" runat="server" Text="Search By Number" CssClass="btn-lg" OnClick="Button3_Click" />
                                    </td>
                                </tr>
                                
                            </table>
                        </td>
                        <td>
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 226px">
                                        <asp:TextBox ID="txtnqsname" runat="server" Width="210px" CssClass="form-control"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="Button4" runat="server" Text="Search By Name" CssClass="btn-lg" OnClick="Button4_Click" />
                                    </td>
                                </tr>
                                
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="text-align: left">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"  HeaderStyle-Font-Bold="true"  Width="1264px" BackColor="White" Font-Names="Andalus" Font-Size="Medium">
                    <Columns>
                        <asp:BoundField DataField="RegNo" HeaderText="Registration Number" />
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Date_Registered" HeaderText="Registration Date" />
                        <asp:BoundField DataField="Outstanding" HeaderText="Outstanding Balance" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone Number" />
                        <asp:BoundField DataField="Email" HeaderText="Email Address" />
                    </Columns>
                    <HeaderStyle BackColor="#009933" BorderColor="#009933" BorderStyle="Solid" Font-Bold="True" BorderWidth="2px" />
                   
                    <RowStyle BorderColor="#009900" BorderStyle="Solid" BorderWidth="2px" />
                    <SelectedRowStyle BackColor="#009933" />
                   
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="gridView0" runat="server" AutoGenerateColumns="False"  HeaderStyle-Font-Bold="true"  Width="1264px" BackColor="White" Font-Names="Andalus" Font-Size="Medium">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone Number" />
                        <asp:BoundField DataField="Email" HeaderText="Email Address" />
                    </Columns>
                    <HeaderStyle BackColor="#009933" BorderColor="#009933" BorderStyle="Solid" Font-Bold="True" BorderWidth="2px" />
                   
                    <RowStyle BorderColor="#009900" BorderStyle="Solid" BorderWidth="2px" />
                    <SelectedRowStyle BackColor="#009933" />
                   
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder1">
   <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" runat="server" href="#" style="font-family: 'Times New Roman', Times, serif; width: 397px;"><strong>QSRBN CASH MANAGEMENT SOLUTION</strong></a>
        </div>
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li><a runat="server" href="~/main.aspx">Registered QS</a></li>
                <li><a runat="server" href="~/addNregQS.aspx">Non-Registered QS</a></li>
                <li><a runat="server" href="~/imprest.aspx">Imprest</a></li>
                <li><a runat="server" href="~/search.aspx">Search</a></li>
                 <li><a runat="server" href="~/summary.aspx">Summary</a></li>
            </ul>
            <asp:LoginView runat="server" ViewStateMode="Disabled">
                <AnonymousTemplate>
                    <ul class="nav navbar-nav navbar-right">
                        <li><a runat="server" href="~/Default.aspx">Log out</a></li>
                    </ul>
                </AnonymousTemplate>
                <LoggedInTemplate>
                    <ul class="nav navbar-nav navbar-right">
                        <li><a runat="server" href="~/Account/Manage" title="Manage your account">Hello, <%: Context.User.Identity.GetUserName()  %>!</a></li>
                        
                    </ul>
                </LoggedInTemplate>
            </asp:LoginView>
        </div>
    </div>
</asp:Content>


