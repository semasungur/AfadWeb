<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kayit.aspx.cs" Inherits="kayit" %>

<%@ Register Src="~/siteayar.ascx" TagPrefix="uc1" TagName="siteayar" %>
<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <uc1:siteayar runat="server" ID="siteayar" />
</head>
<body>
    <form id="form1" runat="server">
        <uc1:header runat="server" ID="header" />
     <div id="wrapper">

        <div class="sol-taraf">
         <div class="hizli-kayit">

                    <div class="ust">
                        Hızlı Kayıt Ol
                    </div>

                    <div class="alt">
                        <div class="kullanici">
                        <span>Kullanıcı adı</span>
                        <asp:TextBox ID="txtkullaniciadi" CssClass="textbox" runat="server" />
                      </div>

                         <div class="sifre">
                        <span>Şifre</span>
                        <asp:TextBox ID="txtsifre" CssClass="textbox" runat="server" TextMode="Password" />
                        </div>

                        <asp:Button ID="btnkayit" CssClass="btnkayit" Text="KAYIT" runat="server" OnClick="btnkayit_Click" />
                        <asp:Label  ID="lblsonuc" Text="" runat="server" />

                    </div>
             </div>
            </div>
         <uc1:footer runat="server" ID="footer" />
         </div>
    </form>
</body>
</html>
