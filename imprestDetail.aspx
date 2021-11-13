<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="imprestDetail.aspx.cs" Inherits="imprestDetail" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width: 672px; color: #000000; font-family: 'Times New Roman', Times, serif; font-size: medium;">
        <tr>
            <td>&nbsp;</td>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td style="height: 41px; width: 137px">&nbsp;</td>
                        <td style="width: 203px; height: 41px;">
                            &nbsp;</td>
                        <td style="height: 41px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3" style="height: 52px">Please fill the fields below appropriately, thanks.</td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px">Purpose :</td>
                        <td style="width: 203px; height: 41px;">
                            <asp:TextBox ID="txtpurpose" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td style="height: 41px"></td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px">Amount :</td>
                        <td style="width: 203px; height: 41px;">
                            <asp:TextBox ID="txtamt" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td style="height: 41px"></td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px">Recieved By :</td>
                        <td style="width: 203px; height: 41px;">
                            <asp:DropDownList ID="dplrecieved" runat="server" CssClass="dropdown" DataSourceID="SqlDataSource2" DataTextField="StaffName" DataValueField="StaffName" AppendDataBoundItems="True">
                            <asp:ListItem Selected="True" Value="0">Please select a name</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [StaffName] FROM [Staff] ORDER BY [StaffName]"></asp:SqlDataSource>
                        </td>
                        <td style="height: 41px"></td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px">Date Recieved : </td>
                        <td style="width: 203px; height: 41px;">
                                                <asp:TextBox ID="txtpdate" runat="server" AutoPostBack="True" Width="194px" CssClass="form-control" TabIndex="5" Enabled="False"></asp:TextBox>
                                            </td>
                        <td style="height: 41px">
                                                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/images/cal1.jpg" onclick="ImageButton1_Click" Width="36px" style="z-index: 1" />
                                            </td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px"></td>
                        <td style="width: 203px; height: 41px;">
                                                <asp:Calendar ID="Calendar1" runat="server" onselectionchanged="Calendar1_SelectionChanged" Visible="False" Height="194px" Width="206px" BorderColor="White">
                                                    <DayHeaderStyle BackColor="White" ForeColor="#009900" />
                                                    <DayStyle BorderColor="White" BorderStyle="Solid" Font-Names="Andalus" Font-Size="Small" />
                                                    <TitleStyle BackColor="#00CC66" />
                                                </asp:Calendar>
                                            </td>
                        <td style="height: 41px"></td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px">Remarks : </td>
                        <td style="width: 203px; height: 41px;">
                            <asp:TextBox ID="txtremarks" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                        <td style="height: 41px"></td>
                    </tr>
                    <tr>
                        <td style="height: 41px; width: 137px">Year : </td>
                        <td style="width: 203px; height: 41px;">
                                                <asp:DropDownList ID="dplyear" runat="server" AutoPostBack="True" CssClass="dropdown" DataSourceID="SqlDataSource1" DataTextField="YEAR" DataValueField="YEAR" Height="22px" Width="201px" TabIndex="7" AppendDataBoundItems="True">
                                                    <asp:ListItem Selected="True" Value="0">Please select a year</asp:ListItem>
                                                     
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [YEAR] FROM [YEAR] ORDER BY [YEAR]"></asp:SqlDataSource>
                        </td>
                        <td style="height: 41px"></td>
                    </tr>
                    <tr>
                        <td style="height: 35px; width: 137px"></td>
                        <td style="width: 203px; height: 35px;">
                                                <asp:Button ID="btnprint" runat="server" Font-Bold="True" onclick="btnprint_Click" Text="Add" Width="67px" CssClass="btn" />
                                            </td>
                        <td style="height: 35px"></td>
                    </tr>
                    <tr>
                        <td style="width: 137px">&nbsp;</td>
                        <td colspan="2">
                            <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </td>
                    </tr>
                    
                </table>
            </td>
            <td style="vertical-align: top">
                <table style="width: 100%">
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
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


