<%@ Control Language="C#" AutoEventWireup="true" CodeFile="soltaraf.ascx.cs" Inherits="soltaraf" %>
  <div class="sol-taraf">

                <div class="hizli-kayit">

                    <asp:Panel ID="pnlgiris" runat="server">

                    <div class="ust">
                       Kullanıcı Girişi
                    </div>

                    <div class="alt">
                        <div class="kullanici">
                        <span>Kullanıcı adı</span>
                        <asp:TextBox ID="txtkullaniciadi" CssClass="textbox" runat="server" />
                      
                   </div>

                         <div class="sifre">
                        <span>Şifre</span>
                        <asp:TextBox ID="txtsifre" CssClass="textbox" runat="server" />
                        </div>

                        <asp:Button ID="btnkayit" CssClass="btnkayit" Text="KAYIT" runat="server" OnClick="btnkayit_Click" />
                        <asp:Button ID="btngiris" CssClass="btngiris" Text="GİRİŞ" runat="server" OnClick="btngiris_Click"/>
                       

                    </div>
                        </asp:Panel>
                        <asp:Label  ID="Lblsonuc"  runat="server" Text="" ></asp:Label>
                    <asp:Panel ID="pnlkullanici" runat="server" BackColor="White">
                     
                    <br />
                       <a href="bilgiduzenleme.aspx">
                    <asp:Label ID="LblPersonelBilgi" runat="server" Text="Bilgilerimi Değiştir"></asp:Label>
                     </a>
                    <br />
                    <a href="afetekleme.aspx?personelid=<%= GetPersonelBilgi() %>">
                    <asp:Label ID="LblAfetEkle" runat="server" Text="Afet Ekle"></asp:Label>
                     </a>
                        <br /><br />
                        <asp:Button ID="btncikis" Text="ÇIKIŞ" runat="server" cssClass="btncikis"  OnClick="btncikis_Click" />
                        <asp:Label ID="lblkullaniciadi" Text="" runat="server" />
                    </asp:Panel>
                </div>
                

            </div>