<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<script runat="server">

   </script>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width: 100%">
    <tr>
        <td style="width: 173px">&nbsp;</td>
        <td style="vertical-align: top">
            <table style="width: 104%">
                <tr>
                    <td>
                        <table cellpadding="4px" cellspacing="4px" class="style5" style="font-family: Andalus; font-size: small" width="97%">
                            <tr>
                                <td valign="top">
                                    <table class="style6" style="color: #000000; font-family: 'Times New Roman', Times, serif; font-size: medium; width: 672px;">
                                        <tr>
                                            <td class="style16">&nbsp;</td>
                                            <td class="style9" colspan="7">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style16"></td>
                                            <td class="style9" colspan="7">Please fill the fields below to add new payment, thanks</td>
                                        </tr>
                                        <tr>
                                            <td class="style8" style="height: 41px"></td>
                                            <td class="style17" style="height: 41px; width: 143px;">Reg. Number:</td>
                                            <td class="style22" colspan="5" style="height: 41px">
                                                <asp:TextBox ID="txtreg" runat="server" AutoPostBack="True" ontextchanged="txtreg_TextChanged" Width="194px" CssClass="form-control"></asp:TextBox>
                                            </td>
                                            <td style="height: 41px">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style8" style="height: 41px"></td>
                                            <td class="style17" style="height: 41px; width: 143px;">The Sum of:</td>
                                            <td class="style22" colspan="5" style="height: 41px">
                                                <asp:TextBox ID="txtamt" runat="server" AutoPostBack="True" Width="194px" CssClass="form-control" TabIndex="1"  ></asp:TextBox>
                                            </td>
                                            <td style="height: 41px">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style8" style="height: 38px"></td>
                                            <td class="style17" style="height: 38px; width: 143px;">Beign Payment for:</td>
                                            <td class="style22" colspan="5" style="height: 38px">
                                                <asp:DropDownList ID="dplfor"  runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="ProgramName" DataValueField="ProgramName" Height="22px" onselectedindexchanged="dplfor_SelectedIndexChanged" Width="201px" CssClass="dropdown" TabIndex="2" AppendDataBoundItems="True" >
                                                      <asp:ListItem Selected="True" Value="0">Please select a particular</asp:ListItem>
                                                     </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [ProgramName] FROM [MCPD] ORDER BY [ProgramName]"></asp:SqlDataSource>
                                            </td>
                                            <td style="height: 38px"></td>
                                        </tr>
                                        <tr>
                                            <td class="style8" style="height: 38px"></td>
                                            <td class="style17" style="height: 38px; width: 143px;">Recieved From:</td>
                                            <td class="style22" colspan="5" style="height: 38px">
                                                <asp:DropDownList ID="dplfrm" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource4" DataTextField="Name" DataValueField="Name" Enabled="False" Height="22px" Width="201px" CssClass="dropdown" TabIndex="3">
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [Name] FROM [QS] WHERE ([RegNo] = @RegNo)">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="txtreg" Name="RegNo" PropertyName="Text" Type="String" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </td>
                                            <td style="height: 38px"></td>
                                        </tr>
                                        <tr>
                                            <td class="style18" style="height: 38px"></td>
                                            <td class="style19" style="height: 38px; width: 143px;">Payment Mode:</td>
                                            <td class="style23" colspan="5" style="height: 38px">
                                                <asp:DropDownList ID="dplpmode" runat="server" AutoPostBack="True" Height="22px" onselectedindexchanged="dplpmode_SelectedIndexChanged" Width="201px" CssClass="dropdown" TabIndex="4" AppendDataBoundItems="True">
                                                    <asp:ListItem Selected="True" Value="0">Please select mode</asp:ListItem>
                                                    <asp:ListItem>Cash</asp:ListItem>
                                                    <asp:ListItem>Cheque</asp:ListItem>
                                                    <asp:ListItem>Teller/Bank Draft</asp:ListItem>
                                                    <asp:ListItem>Remita</asp:ListItem>
                                                    <asp:ListItem>POS</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td class="style21" style="height: 38px">&nbsp;</td>
                                        </tr>
                                       
                                        <tr>
                                            <td class="style8" style="height: 32px"></td>
                                            <td class="style17" style="height: 32px; width: 143px;">Payment Date:</td>
                                            <td valign="top" style="height: 32px; width: 218px;">
                                                <asp:TextBox ID="txtpdate" runat="server" AutoPostBack="True" Width="194px" CssClass="form-control" TabIndex="5" Enabled="False" ></asp:TextBox>
                                            </td>
                                            <td valign="top" style="height: 32px; width: 10px; text-align: left;">
                                                <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/images/cal1.jpg" onclick="ImageButton1_Click" Width="36px" style="z-index: 1" />
                                            </td>
                                            <td colspan="2" valign="top" style="height: 32px; text-align: left;">
                                                &nbsp;</td>
                                            <td colspan="2" valign="top" style="height: 32px">
                                                &nbsp;</td>
                                        </tr>
                                        
                                        <tr>
                                            <td class="style8" style="height: 32px">&nbsp;</td>
                                            <td class="style17" style="height: 32px; width: 143px;">&nbsp;</td>
                                            <td valign="top" style="height: 32px; width: 218px;">
                                                <asp:Calendar ID="Calendar1" runat="server" onselectionchanged="Calendar1_SelectionChanged" Visible="False" Height="194px" Width="206px" BorderColor="White">
                                                    <DayHeaderStyle BackColor="White" ForeColor="#009900" />
                                                    <DayStyle BorderColor="White" BorderStyle="Solid" Font-Names="Andalus" Font-Size="Small" />
                                                    <TitleStyle BackColor="#00CC66" />
                                                </asp:Calendar>
                                            </td>
                                            <td valign="top" style="height: 32px; width: 10px; text-align: left;">
                                                &nbsp;</td>
                                            <td colspan="2" valign="top" style="height: 32px; text-align: left;">
                                                &nbsp;</td>
                                            <td colspan="2" valign="top" style="height: 32px">
                                                &nbsp;</td>
                                        </tr>
                                        
                                        
                                        
                                        <tr>
                                            <td class="style8" style="height: 38px">&nbsp;</td>
                                            <td class="style17" style="height: 38px; width: 143px; vertical-align: top;">
                                                <asp:Label ID="lblbal0" runat="server" Text="Year of Payment:"></asp:Label>
                                            </td>
                                            <td colspan="6" valign="top" style="height: 38px">
                                                <asp:DropDownList ID="dplyear" runat="server" AutoPostBack="True" CssClass="dropdown" DataSourceID="SqlDataSource1" DataTextField="YEAR" DataValueField="YEAR" Height="22px" Width="201px" TabIndex="7" AppendDataBoundItems="True">
                                                    <asp:ListItem Selected="True" Value="0">Please select a year</asp:ListItem>
                                                   
                                                    
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [YEAR] FROM [YEAR] ORDER BY [YEAR]"></asp:SqlDataSource>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="style8">&nbsp;</td>
                                            <td class="style17" style="width: 143px">Registration Type :</td>
                                            <td style="width: 218px">
                                                <asp:RadioButtonList ID="rbltype" runat="server" AutoPostBack="True" onselectedindexchanged="rbltype_SelectedIndexChanged" RepeatDirection="Horizontal" TabIndex="8">
                                                    <asp:ListItem>Individual</asp:ListItem>
                                                    <asp:ListItem>Firm</asp:ListItem>
                                                </asp:RadioButtonList>
                                            </td>
                                            <td style="width: 10px">&nbsp;</td>
                                            <td>
                                                <asp:Label ID="lbltype" runat="server" Visible="False"></asp:Label>
                                            </td>
                                            <td colspan="3">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style8" style="height: 38px"></td>
                                            <td class="style17" style="height: 38px; width: 143px; vertical-align: top;">
                                                <asp:Label ID="lblbal" runat="server" Text="Former OutStanding :" Visible="False"></asp:Label>
                                            </td>
                                            <td colspan="6" valign="top" style="height: 38px">
                                                <asp:DropDownList ID="dplbal" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource5" DataTextField="Outstanding" DataValueField="Outstanding" Enabled="False" Height="22px" Visible="False" Width="201px" CssClass="dropdown" TabIndex="6">
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [Outstanding] FROM [QS] WHERE (([RegNo] = @RegNo) AND ([Name] = @Name))">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="txtreg" Name="RegNo" PropertyName="Text" Type="String" />
                                                        <asp:ControlParameter ControlID="dplfrm" Name="Name" PropertyName="SelectedValue" Type="String" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </td>
                                        </tr>
                                         <tr>
                                            <td class="style18" style="height: 38px"></td>
                                            <td class="style19" valign="top" style="height: 38px; width: 143px;">
                                                <asp:Label ID="Label8" runat="server" Text="Mode Number :" Visible="False"></asp:Label>
                                            </td>
                                            <td class="style23" colspan="2" valign="top" style="height: 38px">
                                                <asp:TextBox ID="txtmnumber" runat="server" Visible="False" Width="194px" CssClass="form-control" TabIndex="9"></asp:TextBox>
                                            </td>
                                            <td class="style24" colspan="3" valign="top" style="height: 38px">
                                                <asp:Label ID="Label9" runat="server" Text="(Either Cheque No, teller No,or RRR No)" Visible="False"></asp:Label>
                                            </td>
                                            <td class="style21" style="height: 38px">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="style18" style="height: 38px"></td>
                                            <td class="style19" valign="top" style="height: 38px; width: 143px;">
                                                <asp:Label ID="Label10" runat="server" Text="Bank Name:" Visible="False"></asp:Label>
                                            </td>
                                            <td class="style23" colspan="2" valign="top" style="height: 38px">
                                                <asp:DropDownList ID="dplbank" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="BankName" DataValueField="BankName" Height="22px" onselectedindexchanged="dplpmode_SelectedIndexChanged" Visible="False" Width="201px" CssClass="dropdown" TabIndex="10" AppendDataBoundItems="True">
                                                <asp:ListItem Selected="True" Value="0">Please select a bank</asp:ListItem>
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QCMSConnectionString4 %>" SelectCommand="SELECT [BankName] FROM [Bank] ORDER BY [BankName]"></asp:SqlDataSource>
                                            </td>
                                            <td class="style24" colspan="3" valign="top" style="height: 38px"></td>
                                            <td class="style21" style="height: 38px"></td>
                                        </tr>
                                        
                                        
                                       
                                       
                                        
                                       
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                                                <asp:Label ID="lblmsg" runat="server" ForeColor="Black"></asp:Label>
                                            </td>
                </tr>
            </table>
        </td>
        <td style="vertical-align: top">
            <table style="width: 100%">
                <tr>
                    <td colspan="2">&nbsp;</td>
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
                                                &nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="Black"  Text="Done" CssClass="btn" OnClick="Button2_Click" />
                                            &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                                                &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="549px">
                                                    <LocalReport ReportPath="Report.rdlc">
                                                        <DataSources>
                                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet2" />
                                                        </DataSources>
                                                    </LocalReport>
                                                </rsweb:ReportViewer>
                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="myDsTableAdapters.paymentTableAdapter" UpdateMethod="Update">
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
                                                        <asp:ControlParameter ControlID="txtreg" DefaultValue="@RegNo" Name="RegNo" PropertyName="Text" Type="String" />
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


