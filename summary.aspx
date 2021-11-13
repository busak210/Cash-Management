<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="summary.aspx.cs" Inherits="summary" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td>
                <table style="width: 95%">
                    <tr>
                        <td colspan="2">
                            <asp:Panel ID="Panel1" runat="server" GroupingText="Summarize By :" Width="1207px">
                                <asp:Button ID="Button1" runat="server" Text="Payment Mode" CssClass="btn-link" OnClick="Button1_Click" />
                            </asp:Panel>
                        </td>
                        <td colspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;</td>
                        <td colspan="2">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <table style="width: 100%">
                                <tr>
                                    <td style="width: 86px; text-align: right; vertical-align: top;"><b style="vertical-align: top">Date From :</b></td>
                                    <td style="width: 188px">
                                        <asp:TextBox ID="txtdfrom" runat="server" Width="187px" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                                <asp:Calendar ID="Calendar1" runat="server" onselectionchanged="Calendar1_SelectionChanged" Visible="False" Height="194px" Width="146px" BorderColor="White">
                                                    <DayHeaderStyle BackColor="White" ForeColor="#009900" />
                                                    <DayStyle BorderColor="White" BorderStyle="Solid" Font-Names="Andalus" Font-Size="Small" />
                                                    <TitleStyle BackColor="#00CC66" />
                                                </asp:Calendar>
                                            </td>
                                    <td style="width: 23px; vertical-align: top; ">
                                                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/images/cal1.jpg" onclick="ImageButton1_Click" Width="36px" style="z-index: 1" />
                                            </td>
                                    <td style="width: 72px; text-align: right; vertical-align: top;"><b>Date To :</b></td>
                                    <td style="width: 209px">
                                        <asp:TextBox ID="txtdto" runat="server" Width="183px" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                                <asp:Calendar ID="Calendar2" runat="server" onselectionchanged="Calendar2_SelectionChanged" Visible="False" Height="194px" Width="168px" BorderColor="White">
                                                    <DayHeaderStyle BackColor="White" ForeColor="#009900" />
                                                    <DayStyle BorderColor="White" BorderStyle="Solid" Font-Names="Andalus" Font-Size="Small" />
                                                    <TitleStyle BackColor="#00CC66" />
                                                </asp:Calendar>
                                            </td>
                                    <td style="vertical-align: top; ">
                                                <asp:ImageButton ID="ImageButton2" runat="server" Height="22px" ImageUrl="~/images/cal1.jpg" onclick="ImageButton2_Click" Width="36px" style="z-index: 1" />
                                            </td>
                                    <td style="width: 115px; text-align: right; vertical-align: top;"><b>Payment Year : </b></td>
                                    <td style="text-align: left; vertical-align: top;">
                                                <asp:DropDownList ID="dplyear"  runat="server" AutoPostBack="True" CssClass="dropdown" TabIndex="2" AppendDataBoundItems="True" DataSourceID="SqlDataSource1" DataTextField="YEAR" DataValueField="YEAR" OnSelectedIndexChanged="dplyear_SelectedIndexChanged"  >
                                                      <asp:ListItem Selected="True" Value="0">Please select a year</asp:ListItem>
                                                     </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [YEAR] FROM [YEAR] ORDER BY [YEAR]"></asp:SqlDataSource>
                                            </td>
                                    <td style="vertical-align: top; font-weight: 700;">Particular:</td>
                                    <td style="vertical-align: top">
                                                <asp:DropDownList ID="dplpart"  runat="server" AutoPostBack="True" CssClass="dropdown" TabIndex="2" AppendDataBoundItems="True" DataSourceID="SqlDataSource2" DataTextField="ProgramName" DataValueField="ProgramName" OnSelectedIndexChanged="dplpart_SelectedIndexChanged"  >
                                                      <asp:ListItem Selected="True" Value="0">Please select a particular</asp:ListItem>
                                                     </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [ProgramName] FROM [MCPD] ORDER BY [ProgramName]"></asp:SqlDataSource>
                                                </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                   
                    <tr>
                        <td colspan="4">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4">
                <asp:GridView ID="gridView0" runat="server"  HeaderStyle-Font-Bold="true"  Width="524px" BackColor="White" Font-Names="Andalus" Font-Size="Medium" Height="16px">
                    <HeaderStyle BackColor="#009933" BorderColor="#009933" BorderStyle="Solid" Font-Bold="True" BorderWidth="2px" />
                   
                    <RowStyle BorderColor="#009900" BorderStyle="Solid" BorderWidth="2px" />
                    <SelectedRowStyle BackColor="#009933" />
                   
                </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
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


