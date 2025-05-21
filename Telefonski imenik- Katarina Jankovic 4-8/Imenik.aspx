<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Imenik.aspx.cs" Inherits="Telefonski_imenik__Katarina_Jankovic_4_8.Imenik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;Ime&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" style="margin-left: 0px" OnTextChanged="TextBox3_TextChanged" TextMode="Search" CssClass="kontejner" Height="16px" onkeyup="RefrechUpdatePanel();"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Prezime"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" AutoPostBack="True" OnTextChanged="TextBox4_TextChanged" TextMode="Search" CssClass="kontejner" Height="16px" onkeyup="RefrechUpdatePanel();"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Adresa"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox5" runat="server" AutoPostBack="True" OnTextChanged="TextBox5_TextChanged" TextMode="Search" CssClass="kontejner" Height="16px" onkeyup="RefrechUpdatePanel();"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Mesto"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Br tel"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" AutoPostBack="True" OnTextChanged="TextBox7_TextChanged" TextMode="Search" CssClass="kontejner" Height="16px" onkeyup="RefrechUpdatePanel();"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Vazni tel." Height="41px" OnClick="Button1_Click" Width="69px" CssClass="button button4"/>
            <asp:Button ID="Button2"  runat="server" Text="Uputstvo" Height="41px" OnClick="Button2_Click" Width="69px" CssClass="button button4"/>
        </p>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server" ></asp:PlaceHolder>
    </form>
</body>
</html>
