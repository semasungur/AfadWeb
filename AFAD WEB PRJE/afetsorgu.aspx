<%@ Page Language="C#" AutoEventWireup="true" CodeFile="afetsorgu.aspx.cs" Inherits="afetsorgu" %>

<%@ Register Src="~/siteayar.ascx" TagPrefix="uc1" TagName="siteayar" %>
<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>




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

          <asp:ToolkitScriptManager runat="server"></asp:ToolkitScriptManager>
       
            <div class="orta">
                <asp:Label ID="LblAnaBaslik" runat="server" Text="AFET SORGU" Font-Size="14" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                <br />
                <br />
           
                <table>
                     <tr>
                        <td style="width:250px;height:50px">AFET TÜRÜ</td>
                        <td style="width:250px;height:50px">
                                 <asp:DropDownList ID="Drafetturu" CssClass="afetturu" runat="server" />
                        </td>
                    </tr>
                
                    <tr>
                        <td style="width:250px;height:50px">İLÇE</td>
                        <td style="width:250px;height:50px">
                             <asp:DropDownList ID="Drilce" CssClass="ilce" runat="server" /> 
                        </td>
                    </tr>
                     <tr>
                        <td style="width:250px;height:50px">BAŞLANGIÇ TARİH</td>
                        <td style="width:250px;height:50px"><asp:TextBox ID="Txttarih1" runat="server"></asp:TextBox>
                          
                        <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="Txttarih1" PopupButtonID="Image4"  CssClass="MyCalendar"></asp:CalendarExtender>
                        <asp:Image ID="Image4" runat="server" ImageUrl="images/icon-calendar.png" Height="27px" Width="33px" />
                        </td>
                          <td style="width:250px;height:50px">BİTİŞ TARİH</td>
                        <td style="width:250px;height:50px"><asp:TextBox ID="Txttarih2" runat="server"></asp:TextBox>
                          

                        <asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="Txttarih2" PopupButtonID="Image5"  CssClass="MyCalendar"></asp:CalendarExtender>
                        <asp:Image ID="Image5" runat="server" ImageUrl="images/icon-calendar.png" Height="27px" Width="33px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width:250px;height:50px">&nbsp;</td>
                       <td style="width:250px;height:50px">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width:250px;height:50px">&nbsp;</td>
                       <td style="width:250px;height:50px">&nbsp;</td>
                    </tr>
                       <tr>
                       <td style="width:250px;height:50px">AFET DETAY</td>
                       <td style="width:250px;height:50px"> <asp:CheckBoxList ID="CheckBoxList1"  runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged"> </asp:CheckBoxList>
                       </td>
                    </tr>
                   
                   
                </table >
                   <asp:Button ID="btnlistele" CssClass="btncikis"  OnClientClick="window.document.forms[0].target='_blank';" Text="LİSTELE" runat="server" PostBackUrl="~/afetlistele.aspx"/>
            </div>


        <uc1:footer runat="server" ID="footer" />

    </form>
</body>
</html>
