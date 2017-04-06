<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="style.css" />
    <link href="https://fonts.googleapis.com/css?family=Russo+One" rel="stylesheet">
    <title>Tip Calculator</title>

</head>
<body>
    <div id="container">
    <form id="form1" runat="server">
        <h1>Tip Calculator</h1>
        <hr />
    
    <p>Enter the meal amount <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox></p>
        <p>Choose your tip percent:</p>
        <asp:radiobuttonlist ID="TipPercentRadioButtonList" runat="server"></asp:radiobuttonlist>
        <asp:TextBox ID="OtherTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <p>
        <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label></p>
    </form>
        </div>
</body>
</html>

