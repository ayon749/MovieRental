<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="HelloWorld.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Button ID="showID" runat="server" Text="Show" OnClick="showID_Click" />
        </div>
		<br />
		<div>
			<asp:Label ID="showLabel" runat="server"></asp:Label>
		</div>
    </form>
</body>
</html>
