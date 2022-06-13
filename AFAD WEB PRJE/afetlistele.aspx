<%@ Page Language="C#" AutoEventWireup="true" CodeFile="afetlistele.aspx.cs" Inherits="afetlistele" %>

<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/siteayar.ascx" TagPrefix="uc1" TagName="siteayar" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <uc1:siteayar runat="server" ID="siteayar" />
     <style>
         table {
    border-collapse: collapse;
    width: 100%;
}

table, th, td {
    border: 1px solid black;
    height: 30px;
    vertical-align: bottom;
    text-align: left;
      padding: 15px;

}
     </style>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        function shrinkandgrow(input) {
            var displayIcon = "img" + input;
            if ($("#" + displayIcon).attr("src") == "grow.png") {
                $("#" + displayIcon).closest("tr")
			    .after("<tr><td></td><td colspan = '100%'>" + $("#" + input)
			    .html() + "</td></tr>");
                $("#" + displayIcon).attr("src", "shrink.png");
            } else {
                $("#" + displayIcon).closest("tr").next().remove();
                $("#" + displayIcon).attr("src", "grow.png");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:header runat="server" ID="header" />
           <div class="orta">


               <asp:Repeater ID="RAfetTuru" runat="server" OnItemDataBound="RAfetTuru_ItemDataBound">
    <HeaderTemplate>
        <table>
      <tr style="background-color:#ffd800">
            <td style="width:20px">Sıra No</td>
           
            <td>Resim</td>
           
            <td>Afet Adı</td>
           
            <td>Açıklama</td>
            <td>Detay</td>
    </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
         
            <td style="background-color:#f6e5e5"><%# Container.ItemIndex + 1 %></td>
           
             <td>
                 <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("img") %>' Width="70px" Height="70px"/></td>
             
            <td><%# Eval("afetadi") %></td>
          
            <td><%# Eval("aciklama") %></td>
             <td>
                 <a href="JavaScript:shrinkandgrow('div<%# Eval("afetid") %>');">
				<img alt="Details" id="imgdiv<%# Eval("afetid") %>" src="grow.png" />
			</a>
                   
			<div id="div<%# Eval("afetid") %>" style="display: none;">
				
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" DataKeyNames="afetkatid"
                HeaderStyle-BackColor="#FFA500" HeaderStyle-ForeColor="White">
				<Columns>
					<asp:BoundField ItemStyle-Width="150px" DataField="afetistatistikadi" HeaderText="Afet Adı" />
					<asp:BoundField ItemStyle-Width="100px" DataField="afetistatistikdeger" HeaderText="Sayısı" />
					
				</Columns>
				</asp:GridView>

			</div>
               
             </td>
        </tr>


        

    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>
               <asp:Label ID="Lbllistelemeuyari" runat="server" Text="Label"></asp:Label>   
               </div>

        <uc1:footer runat="server" ID="footer" />
    </form>
</body>
</html>
