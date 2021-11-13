<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="nnrqs.aspx.cs" Inherits="nnrqs" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 104px">&nbsp;</td>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td>
                            <table cellpadding="4px" cellspacing="4px" class="style5" style="font-family: Andalus; font-size: small" width="97%">
                                <tr>
                                    <td valign="top">
                                        <table class="style6" style="color: #000000; font-family: 'Times New Roman', Times, serif; font-size: medium;">
                                            <tr>
                                                <td class="style16" style="height: 66px"></td>
                                                <td class="style9" colspan="5" style="height: 66px">Please fill the fields below to add new person, thanks</td>
                                            </tr>
                                            <tr>
                                                <td class="style8" style="height: 48px"></td>
                                                <td class="style17" style="height: 48px">Full Name :</td>
                                                <td class="style22" style="height: 48px">
                                                    <asp:TextBox ID="txtfname" runat="server" AutoPostBack="True" CssClass="form-control" Width="194px"></asp:TextBox>
                                                </td>
                                                <td class="style22" colspan="2" style="height: 48px"></td>
                                                <td style="height: 48px"></td>
                                            </tr>
                                            <tr>
                                                <td class="style8" style="height: 48px"></td>
                                                <td class="style17" style="height: 48px">Phone Number :</td>
                                                <td colspan="2" style="height: 48px">
                                                    <asp:TextBox ID="txtpnumber" runat="server" AutoPostBack="True" CssClass="form-control" Width="194px"></asp:TextBox>
                                                </td>
                                                <td class="style22" colspan="2" style="height: 48px"></td>
                                                <td style="height: 48px"></td>
                                            </tr>
                                            <tr>
                                                <td class="style8" style="height: 48px"></td>
                                                <td class="style17" style="height: 48px">E-mail Address :</td>
                                                <td colspan="2" style="height: 48px">
                                                    <asp:TextBox ID="txtemail" runat="server" AutoPostBack="True" CssClass="form-control" Width="194px"></asp:TextBox>
                                                </td>
                                                <td class="style22" colspan="2" style="height: 48px"></td>
                                                <td style="height: 48px"></td>
                                            </tr>
                                            <tr>
                                                <td class="style8" style="height: 50px"></td>
                                                <td class="style17" style="height: 50px"></td>
                                                <td colspan="4" style="height: 50px">
                                                    <asp:Button ID="btnAdd" runat="server" CssClass="btn" Font-Bold="True" onclick="btnAdd_Click" Text="Add" Width="67px" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style8">&nbsp;</td>
                                                <td class="style10" colspan="5">
                                                    <asp:Label ID="lblmsg" runat="server" ForeColor="#FF0066" style="color: #000000"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="style8">&nbsp;</td>
                                                <td class="style10" colspan="2">&nbsp;</td>
                                                <td class="style10" colspan="3">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="style8">&nbsp;</td>
                                                <td class="style10" colspan="5">&nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
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


