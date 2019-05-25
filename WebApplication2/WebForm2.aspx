<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="159px" ImageUrl="~/Images/renderforest-logo3.png" style="margin-left: 28px" Width="281px" />
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#0099FF" Height="86px">
                &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" Width="45px" ImageUrl="~/Images/icons8-dog-house-filled-50.png" OnClick="ImageButton1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-plus-sign-filled-50WHITE.png" OnClick="ImageButton2_Click" Width="45px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton3_Click" Width="45px" />
            </asp:Panel>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="New Form"></asp:Label>
    </form>
</body>
</html>
