<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ExamProject.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Only one user may enter at a time.<br />
            If you are already editing the file, this message will also show if you try to go to the home page.</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
    </form>
</body>
</html>
