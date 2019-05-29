<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SchedulingForm3.aspx.cs" Inherits="ExamProject.SchedulingForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
            <asp:ImageButton ID="ImageButton5" runat="server" Height="45px" ImageUrl="~/Images/icons8-slider--filled-50.png" OnClick="ImageButton5_Click" />
            &nbsp;&nbsp;<asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50.png" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/results.PNG" />

        <br />
        <br />
        <br />
        <asp:Image ID="Image3" runat="server" Height="24px" ImageUrl="~/Images/process1.PNG" />
&nbsp;<asp:Image ID="Image4" runat="server" Height="24px" ImageUrl="~/Images/icons8-circle-filled-50RED.png" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image5" runat="server" Height="23px" ImageUrl="~/Images/process2.PNG" />
&nbsp;<asp:Image ID="Image6" runat="server" Height="24px" ImageUrl="~/Images/icons8-circle-filled-50YELLOW.png" />
        <br />
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image7" runat="server" Height="23px" ImageUrl="~/Images/process3.PNG" />
&nbsp;<asp:Image ID="Image8" runat="server" Height="24px" ImageUrl="~/Images/icons8-circle-filled-50BLUE.png" />
        <br />
        <asp:Label ID="Label9" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label11" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label12" runat="server"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;<asp:Image ID="Image23" runat="server" Height="21px" ImageUrl="~/Images/MQ logo.PNG" />
        <br />
        <asp:Image ID="Image21" runat="server" Height="50px" ImageUrl="~/Images/Queue.PNG" />
        <br />
        <br />
        <asp:Image ID="Image9" runat="server" Height="32px" />
        <asp:Image ID="Image10" runat="server" Height="32px" />
        <asp:Image ID="Image11" runat="server" Height="32px" />
        <asp:Image ID="Image12" runat="server" Height="32px" />
        <asp:Image ID="Image13" runat="server" Height="32px" />
        <asp:Image ID="Image14" runat="server" Height="32px" />
        <asp:Image ID="Image15" runat="server" Height="32px" />
        <asp:Image ID="Image16" runat="server" Height="32px" />
        <asp:Image ID="Image17" runat="server" Height="32px" />
        <asp:Image ID="Image18" runat="server" Height="32px" />
        <asp:Image ID="Image19" runat="server" Height="32px" />
        <asp:Image ID="Image20" runat="server" Height="32px" />
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="Image22" runat="server" ImageUrl="~/Images/Full note.PNG" Height="66px" />
        <br />
    </form>
</body>
</html>
