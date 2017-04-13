<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarPage.aspx.cs" Inherits="CalendarPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans+Condensed:300" rel="stylesheet">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
    <div id="centered">
        <h1>Calendar 2017</h1>
        <asp:Calendar ID="Calendar1" cssClass="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="Label1" runat="server" cssClass="result" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
