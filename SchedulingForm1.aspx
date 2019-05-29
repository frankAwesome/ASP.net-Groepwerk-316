<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SchedulingForm1.aspx.cs" Inherits="ExamProject.SchedulingForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 150px">
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" style="margin-bottom: 0px" BackColor="Black" Height="150px">
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/Images/renderforest-logo3INVERT.png" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#FF6600" Height="45px">
            &nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/icons8-dog-house-filled-50.png" Height="45px" OnClick="ImageButton1_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" Height="45px" ImageUrl="~/Images/icons8-replace-filled-50.png" OnClick="ImageButton2_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton3" runat="server" Height="45px" ImageUrl="~/Images/icons8-view-filled-50.png" OnClick="ImageButton3_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton4" runat="server" Height="45px" ImageUrl="~/Images/icons8-appointment-scheduling-filled-50WHITE.png" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-slider--filled-50.png" OnClick="ImageButton6_Click" />
            &nbsp;
            <asp:ImageButton ID="ImageButton7" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50BLACK.png" OnClick="ImageButton7_Click" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/MQ logo.PNG" />
        <br />
        <br />
        <asp:Panel ID="Panel3" runat="server" BackColor="White" Height="170px" Width="140px">
            <asp:Image ID="Image3" runat="server" Height="33px" ImageUrl="~/Images/process1.PNG" />
            <br />
            <br />
            <asp:Image ID="Image4" runat="server" Height="16px" ImageUrl="~/Images/start time.PNG" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Image5" runat="server" Height="16px" ImageUrl="~/Images/burst time.PNG" />
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="170px" Width="140px">
            <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/process2.PNG" Height="33px" />
            <br />
            <br />
            <asp:Image ID="Image7" runat="server" Height="16px" ImageUrl="~/Images/start time.PNG" />
            <br />
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Image8" runat="server" Height="16px" ImageUrl="~/Images/burst time.PNG" />
            <br />
            <asp:DropDownList ID="DropDownList4" runat="server">
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel5" runat="server" Height="170px" Width="140px">
            <asp:Image ID="Image9" runat="server" ImageUrl="~/Images/process3.PNG" Height="33px" />
            <br />
            <br />
            <asp:Image ID="Image10" runat="server" Height="16px" ImageUrl="~/Images/start time.PNG" />
            <br />
            <asp:DropDownList ID="DropDownList5" runat="server">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Image11" runat="server" Height="16px" ImageUrl="~/Images/burst time.PNG" />
            <br />
            <asp:DropDownList ID="DropDownList6" runat="server">
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/icons8-add-new-filled-50.png" OnClick="ImageButton5_Click" />
        <br />
        <br />
        <br />
        <asp:Image ID="Image12" runat="server" Height="34px" ImageUrl="~/Images/1note.PNG" style="margin-bottom: 0px" />
        <br />
        <br />
        <asp:Image ID="Image13" runat="server" Height="17px" ImageUrl="~/Images/2important.PNG" style="margin-bottom: 0px" />
        <br />
        <br />
        <asp:Image ID="Image14" runat="server" Height="17px" ImageUrl="~/Images/3important.PNG" />
    </form>
</body>
</html>
