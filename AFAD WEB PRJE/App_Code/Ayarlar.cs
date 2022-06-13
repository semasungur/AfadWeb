using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Ayarlar
/// </summary>
public class Ayarlar
{

    public Ayarlar()
    {



    }



    public static string Temizle(string Metin)
    {

        string deger = Metin;



        deger = deger.Replace("&gt;", "");
        deger = deger.Replace("&lt;", "");
        deger = deger.Replace("--", "");
        deger = deger.Replace("'", "");
        deger = deger.Replace("char ", "");
        deger = deger.Replace("delete ", "");
        deger = deger.Replace("insert ", "");
        deger = deger.Replace("update ", "");
        deger = deger.Replace("select ", "");
        deger = deger.Replace("truncate ", "");
        deger = deger.Replace("union ", "");
        deger = deger.Replace("script ", "");
        deger = deger.Replace("concat ", "");
        deger = deger.Replace("database ", "");
        deger = deger.Replace("limit ", "");
        deger = deger.Replace("limit 1 ", "");
        deger = deger.Replace("where ", "");
        deger = deger.Replace("order by ", "");
        deger = deger.Replace("union select ", "");
        deger = deger.Replace("union select version() ", "");
        deger = deger.Replace("union select database() ", "");
        deger = deger.Replace("table_schema ", "");
        deger = deger.Replace("from ", "");
        deger = deger.Replace("information_schema ", "");
        deger = deger.Replace("information_schema.tables ", "");
        deger = deger.Replace("and ", "");
        deger = deger.Replace("or ", "");
        deger = deger.Replace("char ", "");
        deger = deger.Replace("char(32) ", "");
        deger = deger.Replace("password ", "");
        deger = deger.Replace("table ", "");
        deger = deger.Replace("users ", "");
        deger = deger.Replace("name ", "");
        deger = deger.Replace("script ", "");
        deger = deger.Replace("<script> ", "");
        deger = deger.Replace("</script> ", "");
        deger = deger.Replace("location ", "");
        deger = deger.Replace("http ", "");
        deger = deger.Replace("http:// ", "");
        deger = deger.Replace("www ", "");
        deger = deger.Replace("www. ", "");
        deger = deger.Replace("dump ", "");
        deger = deger.Replace("user ", "");
        deger = deger.Replace("password ", "");
        deger = deger.Replace("'", "");
        deger = deger.Replace("-", "");
        deger = deger.Replace("!", "");
        deger = deger.Replace("?", "");
        deger = deger.Replace("(", "");
        deger = deger.Replace(")", "");
        deger = deger.Replace("{", "");
        deger = deger.Replace("}", "");
        deger = deger.Replace("<", "");
        deger = deger.Replace(">", "");
        deger = deger.Replace("/", "");
        deger = deger.Replace("=", "");
        deger = deger.Replace("@", "");
        deger = deger.Replace("%", "");
        deger = deger.Replace("&", "");
        deger = deger.Replace(";", "");



        return deger;

    }





    public static string LinkDuzenle(string Metin)
    {

        string deger = Metin;

        deger = deger.Replace("'", "");

        deger = deger.Replace(" ", "_");

        deger = deger.Replace("<", "");

        deger = deger.Replace(">", "");

        deger = deger.Replace("&", "");

        deger = deger.Replace("[", "");

        deger = deger.Replace("]", "");

        deger = deger.Replace("ı", "i");

        deger = deger.Replace("ö", "o");

        deger = deger.Replace("ü", "u");

        deger = deger.Replace("ş", "s");

        deger = deger.Replace("ç", "c");

        deger = deger.Replace("ğ", "g");

        deger = deger.Replace("İ", "i");

        deger = deger.Replace("Ö", "o");

        deger = deger.Replace("Ü", "u");

        deger = deger.Replace("Ş", "s");

        deger = deger.Replace("Ç", "c");

        deger = deger.Replace("Ğ", "g");



        return deger;

    }





}