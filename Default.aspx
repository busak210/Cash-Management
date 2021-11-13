<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td style="width: 333px">&nbsp;</td>
        <td>
            <table class="nav-justified">
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <table cellpadding="4px" cellspacing="4px" class="style16" style="font-family: 'Times New Roman', Times, serif; font-size: medium; color: #000000; height: 246px; background-color: #009933; width: 556px;">
                            <tr>
                                <td colspan="3" style="border: thin solid #FFFFFF; background-color: #FFFFFF">LOGIN PANEL</td>
                            </tr>
                            <tr>
                                <td style="width: 153px">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: right; width: 153px">
                                    <asp:Label ID="Label1" runat="server" CssClass="bold" Text="Username : " style="color: #FFFFFF"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtuser" runat="server" Width="194px" CssClass="form-control"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: right; width: 153px">
                                    <asp:Label ID="Label2" runat="server" CssClass="bold" Text="Password : " style="color: #FFFFFF"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" Width="194px" CssClass="form-control"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 153px">&nbsp;</td>
                                <td>
                                    <asp:Button ID="btnlogin" runat="server" Font-Bold="True" Font-Size="Small" Height="38px" onclick="btnlogin_Click" Text="login" Width="68px" CssClass="btn-lg" />
                                &nbsp;
                                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="style17" ForeColor="#FF0066" NavigateUrl="~/passReset.aspx" style="color: #FFFFFF">Password Reset</asp:HyperLink>
                                &nbsp;&nbsp;&nbsp;
                                    <asp:HyperLink ID="HyperLink2" runat="server" CssClass="style17" ForeColor="#FF0066" NavigateUrl="#" style="color: #FFFFFF">Forget my password</asp:HyperLink>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 153px">&nbsp;</td>
                                <td>
                                    <asp:Label ID="lblmsg" runat="server" ForeColor="White" CssClass="text-success"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 153px">&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
     <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" runat="server" href="#" style="font-family: 'Times New Roman', Times, serif; width: 397px;"><strong>QSRBN CASH MANAGEMENT SOLUTION</strong></a>
        </div>
        
    </div>
</asp:Content>


