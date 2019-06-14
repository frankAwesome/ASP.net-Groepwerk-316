<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagingForm1.aspx.cs" Inherits="ExamProject.PagingForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" Height="150px">
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/Images/renderforest-logo3INVERT.png" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#009933" Height="45px">
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
            &nbsp;
            <asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50BLACK.png" OnClick="ImageButton6_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton7" runat="server" Height="45px" ImageUrl="~/Images/icons8-system-task-64WHITE.png" OnClick="ImageButton7_Click" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image9" runat="server" Height="57px" ImageUrl="~/Images/virtualmem.PNG" />
        <br />
        <br />
        <br />
        <asp:Image ID="Image10" runat="server" Height="16px" ImageUrl="~/Images/Total aMem.PNG" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image11" runat="server" Height="17px" ImageUrl="~/Images/SelectOS.PNG" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>1 GB</asp:ListItem>
            <asp:ListItem>1,5 GB</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Image ID="Image12" runat="server" Height="16px" ImageUrl="~/Images/sizeOfPageF.PNG" />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>4 KB</asp:ListItem>
            <asp:ListItem>16 KB</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/Images/icons8-add-new-filled-50.png" OnClick="ImageButton8_Click" />
        <br />
        <br />
        <asp:Image ID="Image14" runat="server" ImageUrl="~/Images/pageF.PNG" />
        <br />
        <br />
        <asp:Image ID="Image13" runat="server" Height="17px" ImageUrl="~/Images/amountOfPF.PNG" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="250,000"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image15" runat="server" Height="16px" ImageUrl="~/Images/addressOFirst.PNG" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="ff06"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image16" runat="server" Height="42px" ImageUrl="~/Images/searchPF.PNG" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/Images/icons8-search-filled-50.png" OnClick="ImageButton9_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="The address was found."></asp:Label>
        <br />
        <asp:Image ID="Image17" runat="server" ImageUrl="~/Images/icons8-lost-and-found-30.png" />
        <br />
    </form>
</body>
</html>
