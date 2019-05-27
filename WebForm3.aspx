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
                <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton2_Click" Width="45px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50WHITE.png" Width="45px" OnClick="ImageButton3_Click3" />
            </asp:Panel>
        </div>
        <p>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/viewtext.PNG" />
        </p>
        <p>
            <asp:ImageButton ID="ImageButton4" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50.png" OnClick="ImageButton4_Click1" style="width: 45px" />
        </p>
        <p>
            <asp:TextBox ID="TextBoxShow" runat="server" Height="276px" TextMode="MultiLine" Width="647px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
