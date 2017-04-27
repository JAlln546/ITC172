<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Author.aspx.cs" Inherits="Author" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donations</title>
</head>
<body>
    <h1>Please Donate!</h1>
    <form id="form1" runat="server">
    <div>
    <p>Donation Amount
        <asp:TextBox ID="DonationAmountTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></p>
    </div>
    </form>
</body>
</html>
