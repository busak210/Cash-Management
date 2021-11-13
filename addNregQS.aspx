<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="addNregQS.aspx.cs" Inherits="addNregQS" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 104px">&nbsp;</td>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <table cellpadding="4px" cellspacing="4px" class="style5" style="font-family: Andalus; font-size: small; width: 100%;">
                                <tr>
                                    <td valign="top">
                                        <table cellpadding="4px" cellspacing="4px" class="style5" style="font-family: Andalus; font-size: small; width: 100%;">
                                            <tr>
                                                <td valign="top">
                                                    <table class="style6" style="color: #000000; font-family: 'Times New Roman', Times, serif; font-size: medium;">
                                                        
                                                        <tr>
                                                            <td class="style16" style="height: 44px"></td>
                                                            <td class="style9" colspan="7" style="height: 44px">Please fill the fields below to add new payment, thanks</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style8" style="height: 38px"></td>
                                                            <td class="style17" style="height: 38px">Recieved From:</td>
                                                            <td class="style22" colspan="2" style="height: 38px">
                                                                <asp:DropDownList ID="dplfrm" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" Height="22px" Width="201px" CssClass="dropdown" AppendDataBoundItems="True" OnSelectedIndexChanged="dplfrm_SelectedIndexChanged">
                                                                <asp:ListItem Selected="True" Value="0">Please select a name</asp:ListItem>
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [Name] FROM [NRegQS] ORDER BY [SN]"></asp:SqlDataSource>
                                                            </td>
                                                            <td class="style22" colspan="3" style="height: 38px">
                                                                &nbsp;</td>
                                                            <td style="height: 38px">
                                                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/nnrqs.aspx">Not Found</asp:HyperLink>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style8" style="height: 38px"></td>
                                                            <td class="style17" style="height: 38px">The Sum of:</td>
                                                            <td class="style22" colspan="5" style="height: 38px">
                                                                <asp:TextBox ID="txtamt" runat="server" AutoPostBack="True" Width="194px" CssClass="form-control"></asp:TextBox>
                                                            </td>
                                                            <td style="height: 38px"></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style8" style="height: 38px"></td>
                                                            <td class="style17" style="height: 38px">Beign Payment for:</td>
                                                            <td class="style22" colspan="5" style="height: 38px">
                                                                <asp:DropDownList ID="dplfor" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource4" DataTextField="ProgramName" DataValueField="ProgramName" Height="22px" Width="201px" CssClass="dropdown" AppendDataBoundItems="True">
                                                                <asp:ListItem Selected="True" Value="0">Please select a particular</asp:ListItem>
                                                                </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [ProgramName] FROM [MCPD] ORDER BY [ProgramName]"></asp:SqlDataSource>
                                                            </td>
                                                            <td style="height: 38px"></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style18" style="height: 38px"></td>
                                                            <td class="style19" style="height: 38px">Payment Mode:</td>
                                                            <td class="style23" colspan="5" style="height: 38px">
                                                                <asp:DropDownList ID="dplpmode" runat="server" AutoPostBack="True" Height="22px" onselectedindexchanged="dplpmode_SelectedIndexChanged" Width="201px" CssClass="dropdown" AppendDataBoundItems="True">
                                                                    <asp:ListItem Selected="True" Value="0">Please select mode</asp:ListItem>
                                                                    <asp:ListItem>Cash</asp:ListItem>
                                                                    <asp:ListItem>Cheque</asp:ListItem>
                                                                    <asp:ListItem>Teller/Bank Draft</asp:ListItem>
                                                                    <asp:ListItem>Remita</asp:ListItem>
                                                                    <asp:ListItem>POS</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td class="style21" style="height: 38px"></td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td class="style8">&nbsp;</td>
                                                            <td class="style17">Payment Date:</td>
                                                            <td colspan="3" valign="top">
                                                                <asp:TextBox ID="txtpdate" runat="server" AutoPostBack="True" Enabled="False" Width="194px" CssClass="form-control" TextMode="Date"></asp:TextBox>
                                                <asp:Calendar ID="Calendar1" runat="server" onselectionchanged="Calendar1_SelectionChanged" Visible="False" Height="194px" Width="206px" BorderColor="White">
                                                    <DayHeaderStyle BackColor="White" ForeColor="#009900" />
                                                    <DayStyle BorderColor="White" BorderStyle="Solid" Font-Names="Andalus" Font-Size="Small" />
                                                    <TitleStyle BackColor="#00CC66" />
                                                                </asp:Calendar>
                                                            </td>
                                                            <td colspan="3" valign="top">
                                                                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/images/cal1.jpg" onclick="ImageButton1_Click" Width="36px" />
                                                            </td>
                                                        </tr>
                                                        
                                                        <tr>
                                                            <td class="style8">&nbsp;</td>
                                                            <td class="style17">Year of Payment:</td>
                                                            <td>
                                                <asp:DropDownList ID="dplyear" runat="server" AutoPostBack="True" CssClass="dropdown" DataSourceID="SqlDataSource5" DataTextField="YEAR" DataValueField="YEAR" Height="22px" Width="201px" AppendDataBoundItems="True">
                                                   <asp:ListItem Selected="True" Value="0">Please select a year</asp:ListItem>
                                                     
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [YEAR] FROM [YEAR] ORDER BY [YEAR]"></asp:SqlDataSource>
                                                            </td>
                                                            <td colspan="2">&nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                            <td colspan="2">&nbsp;</td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td class="style8">&nbsp;</td>
                                                            <td class="style17">Registration Type :</td>
                                                            <td>
                                                                <asp:RadioButtonList ID="rbltype" runat="server" AutoPostBack="True" onselectedindexchanged="rbltype_SelectedIndexChanged" RepeatDirection="Horizontal">
                                                                    <asp:ListItem>Individual</asp:ListItem>
                                                                    <asp:ListItem>Firm</asp:ListItem>
                                                                </asp:RadioButtonList>
                                                            </td>
                                                            <td colspan="2">&nbsp;</td>
                                                            <td>
                                                                <asp:Label ID="lbltype" runat="server" Visible="False"></asp:Label>
                                                            </td>
                                                            <td colspan="2">&nbsp;</td>
                                                        </tr>
                                                       
                                                        <tr>
                                                            <td class="style18" style="height: 39px"></td>
                                                            <td class="style19" style="height: 39px" valign="top">
                                                                <asp:Label ID="Label8" runat="server" Text="Mode Number :" Visible="False"></asp:Label>
                                                            </td>
                                                            <td class="style23" colspan="3" style="height: 39px" valign="top">
                                                                <asp:TextBox ID="txtmnumber" runat="server" Visible="False" Width="194px" CssClass="form-control"></asp:TextBox>
                                                            </td>
                                                            <td class="style24" colspan="2" style="height: 39px" valign="top">
                                                                <asp:Label ID="Label9" runat="server" Text="(Either Cheque No, teller No,or RRR No)" Visible="False"></asp:Label>
                                                            </td>
                                                            <td class="style21" style="height: 39px"></td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style18" style="height: 41px"></td>
                                                            <td class="style19" style="height: 41px" valign="top">
                                                                <asp:Label ID="Label10" runat="server" Text="Bank Name:" Visible="False"></asp:Label>
                                                            </td>
                                                            <td class="style23" colspan="3" style="height: 41px" valign="top">
                                                                <asp:DropDownList ID="dplbank" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="BankName" DataValueField="BankName" Height="22px" onselectedindexchanged="dplpmode_SelectedIndexChanged" Visible="False" Width="201px" CssClass="dropdown" AppendDataBoundItems="True">
                                                               <asp:ListItem Selected="True" Value="0">Please select a bank</asp:ListItem>
                                                                     </asp:DropDownList>
                                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [BankName] FROM [Bank] ORDER BY [BankName]"></asp:SqlDataSource>
                                                            </td>
                                                            <td class="style24" colspan="2" style="height: 41px" valign="top"></td>
                                                            <td class="style21" style="height: 41px"></td>
                                                        </tr>
                                                       
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
            <td style="vertical-align: top">
                <table style="width: 100%">
                    
                    
                    <tr>
                        <td colspan="2">
                                                                &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                                                                &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                                                                &nbsp;</td>
                        <td>
                                                                &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                                                                <asp:Button ID="btnprint" runat="server" Font-Bold="True" onclick="btnprint_Click" Text="Add" Width="67px" CssClass="btn" />
                                                            &nbsp;<asp:Button ID="btnCreateorder0" runat="server" Font-Bold="True" ForeColor="Black" OnClick="btnCreateorder0_Click" Text="Print" CssClass="btn" />
                                                                &nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="Black" onclick="Button1_Click" Text="Done" CssClass="btn" />
                                                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                                                                <asp:Label ID="lblmsg" runat="server" ForeColor="Black"></asp:Label>
                                                            </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                                                                <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="548px">
                                                                    <LocalReport ReportPath="Report2.rdlc">
                                                                        <DataSources>
                                                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet2" />
                                                                        </DataSources>
                                                                    </LocalReport>
                                                                </rsweb:ReportViewer>
                                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="myDsTableAdapters.payment1TableAdapter" UpdateMethod="Update">
                                                                    <DeleteParameters>
                                                                        <asp:Parameter Name="Original_SN" Type="Int32" />
                                                                    </DeleteParameters>
                                                                    <InsertParameters>
                                                                        <asp:Parameter Name="RegNo" Type="String" />
                                                                        <asp:Parameter Name="Recieved_From" Type="String" />
                                                                        <asp:Parameter Name="Sum_of" Type="Int32" />
                                                                        <asp:Parameter Name="Being_Payment_for" Type="String" />
                                                                        <asp:Parameter Name="Payment_Mode" Type="String" />
                                                                        <asp:Parameter Name="Mode_Number" Type="String" />
                                                                        <asp:Parameter Name="Transaction_Date" Type="DateTime" />
                                                                        <asp:Parameter Name="BankName" Type="String" />
                                                                        <asp:Parameter Name="FOutstandingBalance" Type="Int32" />
                                                                        <asp:Parameter Name="CurOutstandingBalance" Type="Int32" />
                                                                        <asp:Parameter Name="PaymentYear" Type="String" />
                                                                    </InsertParameters>
                                                                    <SelectParameters>
                                                                        <asp:ControlParameter ControlID="dplfrm" DefaultValue="@Recieved_From" Name="Recieved_From" PropertyName="SelectedValue" Type="String" />
                                                                    </SelectParameters>
                                                                    <UpdateParameters>
                                                                        <asp:Parameter Name="RegNo" Type="String" />
                                                                        <asp:Parameter Name="Recieved_From" Type="String" />
                                                                        <asp:Parameter Name="Sum_of" Type="Int32" />
                                                                        <asp:Parameter Name="Being_Payment_for" Type="String" />
                                                                        <asp:Parameter Name="Payment_Mode" Type="String" />
                                                                        <asp:Parameter Name="Mode_Number" Type="String" />
                                                                        <asp:Parameter Name="Transaction_Date" Type="DateTime" />
                                                                        <asp:Parameter Name="BankName" Type="String" />
                                                                        <asp:Parameter Name="FOutstandingBalance" Type="Int32" />
                                                                        <asp:Parameter Name="CurOutstandingBalance" Type="Int32" />
                                                                        <asp:Parameter Name="PaymentYear" Type="String" />
                                                                        <asp:Parameter Name="Original_SN" Type="Int32" />
                                                                    </UpdateParameters>
                                                                </asp:ObjectDataSource>
                                                            </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                                                                &nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="2">
                                                                &nbsp;</td>
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


