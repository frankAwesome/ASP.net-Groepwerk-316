<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ExamProject.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel2" runat="server" Height="150px">
            <asp:Image ID="Image3" runat="server" Height="150px" ImageUrl="~/Images/renderforest-logo3.png" />
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server" BackColor="#6699FF" Height="45px">
&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/Images/icons8-dog-house-filled-50.png" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton2_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50WHITE.png" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton5" runat="server" Height="45px" ImageUrl="~/Images/icons8-appointment-scheduling-filled-50.png" OnClick="ImageButton5_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-slider--filled-50.png" />
            &nbsp;
            <asp:ImageButton ID="ImageButton7" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50BLACK.png" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton8" runat="server" Height="45px" ImageUrl="~/Images/icons8-system-task-64.png" OnClick="ImageButton8_Click" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/viewtext.PNG" />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton4" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50.png" OnClick="ImageButton4_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="272px" TextMode="MultiLine" Width="538px"></asp:TextBox>
    </form>
</body>
</html>
