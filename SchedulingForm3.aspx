<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SchedulingForm3.aspx.cs" Inherits="ExamProject.SchedulingForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" Height="150px">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/renderforest-logo3INVERT.png" Height="150px" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#FF6600" Height="45px">
            &nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/Images/icons8-dog-house-filled-50.png" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton2_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50.png" OnClick="ImageButton3_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" Height="45px" ImageUrl="~/Images/icons8-appointment-scheduling-filled-50.png" OnClick="ImageButton4_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton5" runat="server" Height="45px" ImageUrl="~/Images/icons8-slider--filled-50.png" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50.png" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/results.PNG" />
        <br />
        <br />

        <br />
        <br />
    </form>
</body>
</html>
