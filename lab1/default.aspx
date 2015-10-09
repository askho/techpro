<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="lab1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab1</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/1.11.8/semantic.min.css"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/1.11.8/semantic.min.js"></script>
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
    <form id="form" runat="server">
        <table class="table ui raised segment celled striped table" >
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
                    <asp:RequiredFieldValidator ID="intresetRateValidator" runat="server" ControlToValidate="interestRate" Display="Dynamic" ErrorMessage="You need to fill this in"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Number of Years</td>
                <td>
                    <asp:TextBox ID="numberYears" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="yearRangeValidator" runat="server" ControlToValidate="numberYears" Display="Dynamic" ErrorMessage="This must be between 0 and 100" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Future Value</td>
                <td>
                    <asp:Label ID="output" runat="server"></asp:Label>
                </td>
            </tr>
            <tr class="button">
                <td>
                    <asp:Button ID="calc" runat="server" class="ui primary button" Text="Calculate" OnClick="calc_Click"/>
                </td>
                <td>
                    <asp:Button ID="clear" runat="server" class="ui button" Text="Clear" OnClick="clear_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
