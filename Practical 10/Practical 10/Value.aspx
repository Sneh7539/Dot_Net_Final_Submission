<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Value.aspx.cs" Inherits="Practical_10.Value" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username :&nbsp;&nbsp;
            <asp:TextBox ID="Usrnm" runat="server"></asp:TextBox>
            <br />
            <br />
            Password :&nbsp;&nbsp;
            <asp:TextBox ID="Pwd" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
