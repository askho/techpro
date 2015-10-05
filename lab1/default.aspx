<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="lab1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab1</title>
    <link rel="stylesheet" type="text/css" href="css/style.less">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <div class="header">
            <img src="Images/logo.png" alt="Dell" height="250px"/>
            <p>Leon's Investment Calculator</p>
        </div>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Monthly Investment</td>
                <td>
                    <asp:DropDownList ID="investmentOption" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Annual Interest Rate</td>
                <td>
                    <asp:TextBox ID="interestRate" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Number of Years</td>
                <td>
                    <asp:TextBox ID="numberYears" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Future Value</td>
                <td>
                    <asp:Label ID="output" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="calc" runat="server" Text="Calculate" Width="86px" OnClick="calc_Click" />
                </td>
                <td>
                    <asp:Button ID="clear" runat="server" Text="Clear" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
