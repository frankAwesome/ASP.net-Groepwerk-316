<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ExamProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/Images/renderforest-logo3.png" />
        <asp:Panel ID="Panel1" runat="server" Height="45px" BackColor="#6699FF">
            &nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/Images/icons8-dog-house-filled-50WHITE.png" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton2_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50.png" OnClick="ImageButton3_Click" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/welcome 316.PNG" />
    </form>
    <p>
        by F de Klerk &amp; M Davies</p>
</body>
</html>
