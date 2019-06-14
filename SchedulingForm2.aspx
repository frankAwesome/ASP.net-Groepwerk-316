<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SchedulingForm2.aspx.cs" Inherits="ExamProject.SchedulingForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" Height="150px">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/renderforest-logo3INVERT.png" Height="150px" />
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
            <asp:ImageButton ID="ImageButton6" runat="server" Height="45px" ImageUrl="~/Images/icons8-slider--filled-50WHITE.png" OnClick="ImageButton6_Click" />
            &nbsp;
            <asp:ImageButton ID="ImageButton7" runat="server" Height="45px" ImageUrl="~/Images/icons8-trophy-filled-50BLACK.png" OnClick="ImageButton7_Click" />
            &nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton8" runat="server" Height="45px" ImageUrl="~/Images/icons8-system-task-64.png" OnClick="ImageButton8_Click" />
        </asp:Panel>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/timequantum.PNG" />
        <br />
&nbsp;
        <asp:Image ID="Image6" runat="server" Height="21px" ImageUrl="~/Images/MQ logo.PNG" />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Image ID="Image3" runat="server" Height="33px" ImageUrl="~/Images/process1.PNG" />
        <br />
        <asp:TextBox ID="TextBox1" runat="server">1</asp:TextBox>
        <ajaxToolkit:SliderExtender ID="TextBox1_SliderExtender" runat="server" BehaviorID="TextBox1_SliderExtender" BoundControlID="Label1" Maximum="2" Minimum="1" TargetControlID="TextBox1">
        </ajaxToolkit:SliderExtender>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image4" runat="server" Height="33px" ImageUrl="~/Images/process2.PNG" />
        <br />
        <asp:TextBox ID="TextBox2" runat="server">1</asp:TextBox>
        <ajaxToolkit:SliderExtender ID="TextBox2_SliderExtender" runat="server" BehaviorID="TextBox2_SliderExtender" BoundControlID="Label2" Maximum="2" Minimum="1" TargetControlID="TextBox2">
        </ajaxToolkit:SliderExtender>
        <asp:Label ID="Label4" runat="server" ForeColor="#CC0000" Text="Make sure that 'Process 1' is smaller than 'Process 2'"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image5" runat="server" Height="33px" ImageUrl="~/Images/process3.PNG" />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <ajaxToolkit:SliderExtender ID="TextBox3_SliderExtender" runat="server" BehaviorID="TextBox3_SliderExtender" BoundControlID="Label3" Maximum="2" Minimum="1" TargetControlID="TextBox3">
        </ajaxToolkit:SliderExtender>
        <asp:Label ID="Label5" runat="server" ForeColor="#CC0000" Text="Make sure that 'Process 2' is smaller than 'Process 3'"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/icons8-add-new-filled-50.png" OnClick="ImageButton5_Click" />
        <br />
        <br />


    </form>
</body>
</html>
