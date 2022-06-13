<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<%@ Register Src="~/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/siteayar.ascx" TagPrefix="uc1" TagName="siteayar" %>
<%@ Register Src="~/soltaraf.ascx" TagPrefix="uc1" TagName="soltaraf" %>
<%@ Register Src="~/footer.ascx" TagPrefix="uc1" TagName="footer" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <uc1:siteayar runat="server" ID="siteayar" />
</head>
<body>
    <form id="form1" runat="server">
  
        <uc1:header runat="server" ID="header" />
        <uc1:soltaraf runat="server" id="soltaraf" />

        <div class="icerik">
          Misyonumuz:
Afetlerin gerçekleşmesinin kaçınılmaz olduğu gerçeğinden hareketle, afet zararlarını azaltmayı, önlemlerini almayı ve etkilerini azaltmayı amaçlayan AFAD, misyonunu;
    <br />
“Afetlere dirençli toplum oluşturmak”
    <br />
şeklinde belirlemiştir.
<br />
Depremler, seller, heyelanlar, kaya düşmeleri, kuraklıklar, fırtınalar, tsunamiler ve diğer birçok afetin insanlar, çevre ve ekonomi üzerinde yıkıcı etkileri vardır. Ancak insan ve mekânların dirençliliğinin – insanlar ve mekânlar üzerindeki bu yıkıcı etkilere karşı koyma ve hızlı bir şekilde ayağa kalkma yeteneği – artırılması mümkündür. Söz konusu dirençliliğin artırılması afetlerin etkilerini, zararlarını en aza indirecek ve afet sonrası toplumun ayağa kalkma süresini minimize edecektir. AFAD misyonunu bu bakış açısıyla belirlemiştir.
    <br />
Misyonumuz çerçevesinde AFAD’ın sloganı;
    <br />
“Beklenmeyene hazırlıklıyız”
    <br />
olarak belirlenmiştir.
    <br />
    <br />
Vizyonumuz:
AFAD’ın vizyonu;
    <br />
“Afet ve acil durumlar ile ilgili çalışmalarda sürdürülebilir kalkınmayı esas alan risk odaklı, etkin, etkili ve güvenilir hizmet sunan uluslararası düzeyde model alınabilecek yönlendirici ve koordinatör bir kurum olmak.”
    <br />
şeklinde belirlenmiştir.
    <br />
AFAD vizyonuyla; risk yönetimi odaklı, sürdürülebilir kalkınmanın önemine haiz, hizmet sunumunda etkililiğe, etkinliğe ve güvenirliliğe özen gösteren, uluslararası düzeyde güçlü ve afet yönetiminde görev alan tüm kurumları etkili bir şekilde koordine eden bir kurum olmayı öngörmektedir.
    <br />
    <br />
Hedefimiz:
AFAD’ın misyonu olan “Afetlere Dirençli Toplum Oluşturmak” bağlamında AFAD Stratejik Planının temel amacı, bu misyona ulaşmak için şu şekilde tanımlanmıştır;
    <br />
“Stratejik plan dâhilinde stratejik yönetim sistemini kurmak ve planın etkili ve etkin uygulanmasını sağlamak”
    <br />
Bu temel çerçeve doğrultusunda, “AFAD Amaç ve Hedefleri”ni tespit ederken aşağıdaki çalışmaların sonuçlarından istifade edilmiştir:
    <br />
Taslak Stratejik Planının değerlendirilmesi,
Mevcut durum analizi,
Dünyada afet ve acil durum yönetimi konusundaki gelişmeler,
Çalışma Grup Başkanları ile yapılan görüşmeler,
Daire Başkanları ile mülakatlar,
Kurum içi ortak akıl toplantıları,
Dış paydaş - çözüm ortakları ile yapılan süreç analiz çalışmaları,
Strateji Arama Toplantısında ortaya çıkan analizler.

            </div>
        <uc1:footer runat="server" ID="footer" />

    </form>
</body>
</html>
