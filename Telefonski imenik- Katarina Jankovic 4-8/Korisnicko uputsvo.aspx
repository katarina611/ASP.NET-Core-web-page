<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Korisnicko uputsvo.aspx.cs" Inherits="Telefonski_imenik__Katarina_Jankovic_4_8.Korisnicko_uputsvo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <p>Koriscenje stranice:<br /> Stranica za pretragu omogucava nam da
                na osnovu ukucanih slogova ili odabranog mesta izlistamo upisane kontakte u imeniku.
                <br />Stranica sa vaznim telefonima pruza nam informacije o telefonima vaznih sluzbi <br /> Stranica o 
                uputstvu pruza nam informacije o koriscenju web sajta.
            </p>
    </div>
        <asp:Button ID="Button1" runat="server" Text="Vazni tel." OnClick="Button1_Click" CssClass="button button4" />
        <asp:Button ID="Button2" runat="server" Text="Imenik" OnClick="Button2_Click" CssClass="button button4"/>
    </form>
</body>
</html>
