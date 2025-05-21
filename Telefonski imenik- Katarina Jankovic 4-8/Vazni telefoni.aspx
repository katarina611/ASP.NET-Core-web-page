<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vazni telefoni.aspx.cs" Inherits="Telefonski_imenik__Katarina_Jankovic_4_8.Vazni_telefoni" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Policija 192<br/>Hitna pomoc 194<br/>Vatrogasna sluzba 193<br/>Tacno vreme 195<br/>Pomoc na putu 1987<br/>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="button button4" Text="Imenik" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="button button4" Text="Uputstvo" />
    </div>
    </form>
</body>
</html>
