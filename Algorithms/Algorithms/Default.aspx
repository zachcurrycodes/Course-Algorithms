<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                First Word
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div>
                Second Word
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" Text="??" OnClick="Button1_Click" />
            </div>
            <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
