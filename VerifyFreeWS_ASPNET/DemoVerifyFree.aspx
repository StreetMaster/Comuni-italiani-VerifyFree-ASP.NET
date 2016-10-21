<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoVerifyFree.aspx.cs" Inherits="VerifyFreeWS_ASPNET.DemoVerify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Verify Free-Street Master</title>
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
    </style>
</head>
<body bgcolor="#E6E6FA">
    <form id="DemoVerify" runat="server">
        <div style="border: groove; border-color: #336600; width: 482px;">

            <table border="0" cellpadding="2" cellspacing="2">
                <tr>
                    <th colspan="2">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/logo-street-master.png" />
                        <br />
                        <font size="5">VERIFY Free</font></th>
                </tr>
                <tr>
                    <td class="auto-style1">Key
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtKey" Autocomplete="off" Width="400px" runat="server" Text="Specificare una chiave per il servizio VERIFY Free" />
                    </td
                </tr>
                <tr>
                    <td>Provincia</td>
                    <td>
                        <asp:TextBox ID="txtProv" Autocomplete="off" Width="30px" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Comune</td>
                    <td>
                        <asp:TextBox ID="txtComune" autocomplete="off" Width="400px" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Cap</td>
                    <td>
                        <asp:TextBox ID="txtCap" autocomplete="off" Width="50px" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Frazione</td>
                    <td>
                        <asp:TextBox ID="txtFrazione" autocomplete="off" Width="400px" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="btnCallVerifyFree" runat="server" OnClick="btnCallVerifyFree_Click" Text="Call VERIFY Free" />
        </p>
        <div id="outArea" runat="server" style="width: 482px;" />
    </form>
</body>
</html>
