<%@ Page Language="C#" AutoEventWireup="true" CodeFile="afetekleme.aspx.cs" Inherits="afetekleme" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Register Src="~/siteayar.ascx" TagPrefix="uc1" TagName="siteayar" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/soltaraf.ascx" TagPrefix="uc1" TagName="soltaraf" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <uc1:siteayar runat="server" ID="siteayar" />

    <style type="text/css">
        .auto-style2 {
            width: 698px;
        }
           .tableborder {
            border-style:solid;
            border: 1px solid #D1E0E0;
            font-family:Calibri;
            font-size:14pt;
        }
        .MyCalendar .ajax__calendar_container {
            border: 1px solid #646464;
            background-color: lemonchiffon;
            color: red;
        }
 
            .MyCalendar .ajax__calendar_container th {
                padding: 0px;
            }
 
            .MyCalendar .ajax__calendar_container td {
                background-color: lemonchiffon;
                padding: 0px;
            }
 
        .MyCalendar .ajax__calendar_other .ajax__calendar_day, .MyCalendar .ajax__calendar_other .ajax__calendar_year {
            color: black;
        }
 
        .MyCalendar .ajax__calendar_hover .ajax__calendar_day, .MyCalendar .ajax__calendar_hover .ajax__calendar_month, .MyCalendar .ajax__calendar_hover .ajax__calendar_year {
            color: black;
        }
 
        .MyCalendar .ajax__calendar_active .ajax__calendar_day, .MyCalendar .ajax__calendar_active .ajax__calendar_month, .MyCalendar .ajax__calendar_active .ajax__calendar_year {
            color: black;
            font-weight: bold;
        }
        .auto-style5 {
            border: 1px solid #D1E0E0;
            font-family: Calibri;
            font-size: 14pt;
            width: 324px;
        }
        .auto-style6 {
          }
        .auto-style7 {
            border: 1px solid #D1E0E0;
            font-family: Calibri;
            font-size: 14pt;
            width: 257px;
        }
        .auto-style8 {
            border: 1px solid #D1E0E0;
            font-family: Calibri;
            font-size: 14pt;
            width: 698px;
        }
        .auto-style9 {
            width: 257px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:header runat="server" ID="header" />
        <uc1:soltaraf runat="server" ID="soltaraf" />
       
            <asp:ToolkitScriptManager runat="server"></asp:ToolkitScriptManager>
       
            <div class="icerik">
                <asp:Label ID="LblAnaBaslik" runat="server" Text="AFET EKLE" Font-Size="14" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                <br />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ValidationGroup="Kayit" Font-Bold="True" Font-Size="9pt" ForeColor="Red" />
                <table>
                    <tr>
                        <td style="width:250px;height:50px">AFET TÜRÜ</td>
                        <td style="width:250px;height:50px">
                            <asp:DropDownList ID="DropAfetTuru" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Afet Türü Alanı Boş Bırakılamaz" ValidationGroup="Kayit" ControlToValidate="DropAfetTuru">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                     <tr>
                        <td style="width:250px;height:50px">AFET ADI</td>
                        <td style="width:250px;height:50px">
                            <asp:TextBox ID="TxtAfetAdi" runat="server" Width="250px" Height="30px" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Afet Adı Alanı Boş Bırakılamaz" ValidationGroup="Kayit" ControlToValidate="TxtAfetAdi">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                       <tr>
                       <td style="width:250px;height:50px">İLÇE</td>
                       <td style="width:250px;height:50px"><asp:DropDownList ID="Dropilce" runat="server"></asp:DropDownList>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="İlçe Adı Alanı Boş Bırakılamaz" ValidationGroup="Kayit" ControlToValidate="Dropilce">*</asp:RequiredFieldValidator>
                       </td>
                    </tr>
                     <tr>
                       <td style="width:250px;height:50px">OLAY TARİHİ</td>
                       <td style="width:250px;height:50px"><asp:TextBox ID="TxtTarih" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Tarih Alanı Boş Bırakılamaz" ValidationGroup="Kayit" ControlToValidate="TxtTarih">*</asp:RequiredFieldValidator>
                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TxtTarih" PopupButtonID="Image3"  CssClass="MyCalendar"></asp:CalendarExtender>
                        <asp:Image ID="Image3" runat="server" ImageUrl="images/icon-calendar.png" Height="27px" Width="33px" />

                       </td>
                    </tr>
                     <tr>
                       <td style="width:250px;height:50px">AÇIKLAMA</td>
                       <td style="width:250px;height:50px"><asp:TextBox ID="TxtAciklama" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                       <td style="width:250px;height:50px">RESİM</td>
                       <td style="width:250px;height:50px"> <asp:FileUpload ID="FileUpload1" runat="server" />
                           <asp:Image ID="Image1" runat="server" />
                           <asp:Image ID="Image2" runat="server" />
                       </td>
                    </tr>
                   
                </table >
                <asp:Button ID="BtnDevam" cssClass="btncikis" runat="server" Text="Devam" OnClick="BtnDevam_Click" ValidationGroup="Kayit" />
            </div>
        <uc1:footer runat="server" ID="footer" />
    </form>
</body>
</html>
