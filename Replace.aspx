<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Replace.aspx.cs" Inherits="ExamProject.Replace" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel2" runat="server" Height="150px">
            <asp:Image ID="Image5" runat="server" Height="150px" ImageUrl="~/Images/renderforest-logo3.png" />
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server" Height="45px" BackColor="#6699FF">
            &nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/Images/icons8-dog-house-filled-50.png" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50WHITE.png" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50.png" OnClick="ImageButton3_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton5" runat="server" Height="45px" ImageUrl="~/Images/icons8-appointment-scheduling-filled-50.png" OnClick="ImageButton5_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-slider--filled-50.png" />
            &nbsp;
            <asp:ImageButton ID="ImageButton7" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50BLACK.png" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/replacer.PNG" />
        <br />
        <br />
        <asp:Image ID="Image3" runat="server" Height="32px" ImageUrl="~/Images/oldtext.PNG" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="Please enter text here."></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image4" runat="server" Height="28px" ImageUrl="~/Images/new text.PNG" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" ForeColor="#CC0000" Text="Please enter text here:"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton4_Click" />
    </form>
</body>
</html>
