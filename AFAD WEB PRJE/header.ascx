<%@ Control Language="C#" AutoEventWireup="true" CodeFile="header.ascx.cs" Inherits="header" %>
      
        <div id="wrapper">
            <header>
                <div class="logo">
                    AFAD
                </div>
                <nav>
                    <ul>
                                              
                        <li>
                            <a href="default.aspx">Anasayfa</a>
                        </li>


                        <li>
                           <a href="afetsorgu.aspx">Afet Sorgu</a>
                        </li>
                       
                    </ul>
                </nav>
                <div class="arama-wrap">
                    
                    <asp:TextBox ID="txtarama" CssClass="txtarama" runat="server" placeholder="Arama" />
                    <asp:Button ID="btnarama" CssClass="btnarama" Text="ARA" runat="server" />

                    </div>
            </header>

            <div class="banner">

        </div>