<%@ Page Language="C#" AutoEventWireup="true" CodeFile="afetekleme2.aspx.cs" Inherits="afetekleme2" %>

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
                <asp:Label ID="LblAnaBaslik" runat="server" Text="AFET DETAY" Font-Size="14" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                <br />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server"  ValidationGroup="Kayit" Font-Bold="True" Font-Size="9pt" ForeColor="Red" />
                  <table>
                    <tr>
                        <td>                            
                            <asp:DataList ID="DLVeri" runat="server" RepeatColumns="2">
                                <ItemTemplate>
                                    <table>
                             <tr>
                        <td style="width:250px;height:50px">
                            <asp:Label ID="Lblistatistikadi" runat="server" Text='<%#Eval("istatistikadi") %>'></asp:Label></td>
                        <td style="width:250px;height:50px">
                            <asp:TextBox ID="TxtSayi" runat="server" Width="40px" Height="30px"></asp:TextBox>                         
                        </td>
                    </tr>
                </table >
                                </ItemTemplate>
                            </asp:DataList>               
                            </td>
                        </tr>
                      </table>
                <asp:Button ID="BtnDevam" cssClass="btncikis" runat="server" Text="Kaydet" OnClick="BtnDevam_Click" ValidationGroup="Kayit" />
            </div>
        <uc1:footer runat="server" ID="footer" />
    </form>
</body>
</html>
