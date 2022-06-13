using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class injection
{
    public static string temizle(string Text)
    {

        string strReturn = Text.Trim();

        strReturn = strReturn.Replace("&gt;", "");
        strReturn = strReturn.Replace("&lt;", "");
        strReturn = strReturn.Replace("--", "");
        strReturn = strReturn.Replace("'", "");
        strReturn = strReturn.Replace("char", "");
        strReturn = strReturn.Replace("delete", "");
        strReturn = strReturn.Replace("insert", "");
        strReturn = strReturn.Replace("update", "");
        strReturn = strReturn.Replace("select", "");
        strReturn = strReturn.Replace("truncate", "");
        strReturn = strReturn.Replace("union", "");
        strReturn = strReturn.Replace("script", "");
        strReturn = strReturn.Replace("concat", "");
        strReturn = strReturn.Replace("database", "");
        strReturn = strReturn.Replace("limit", "");
        strReturn = strReturn.Replace("limit 1", "");
        strReturn = strReturn.Replace("where", "");
        strReturn = strReturn.Replace("order by", "");
        strReturn = strReturn.Replace("union select", "");
        strReturn = strReturn.Replace("union select version()", "");
        strReturn = strReturn.Replace("union select database()", "");
        strReturn = strReturn.Replace("table_schema", "");
        strReturn = strReturn.Replace("from", "");
        strReturn = strReturn.Replace("information_schema", "");
        strReturn = strReturn.Replace("information_schema.tables", "");
        
        
        strReturn = strReturn.Replace("char", "");
        strReturn = strReturn.Replace("char(32)", "");
        strReturn = strReturn.Replace("password", "");
        strReturn = strReturn.Replace("table", "");
        strReturn = strReturn.Replace("users", "");
        strReturn = strReturn.Replace("name", "");
        strReturn = strReturn.Replace("script", "");
        strReturn = strReturn.Replace("<script>", "");
        strReturn = strReturn.Replace("</script>", "");
        strReturn = strReturn.Replace("location", "");
        strReturn = strReturn.Replace("http", "");
        strReturn = strReturn.Replace("http://", "");
        strReturn = strReturn.Replace("www", "");
        strReturn = strReturn.Replace("www.", "");
        strReturn = strReturn.Replace("dump", "");
        strReturn = strReturn.Replace("user", "");
        strReturn = strReturn.Replace("password", "");
        strReturn = strReturn.Replace("exec", "");
        strReturn = strReturn.Replace("cmdshell", "");
        strReturn = strReturn.Replace("Char", "");
        strReturn = strReturn.Replace("Delete", "");
        strReturn = strReturn.Replace("Insert", "");
        strReturn = strReturn.Replace("Update", "");
        strReturn = strReturn.Replace("Select", "");
        strReturn = strReturn.Replace("Truncate", "");
        strReturn = strReturn.Replace("Union", "");
        strReturn = strReturn.Replace("Script", "");
        strReturn = strReturn.Replace("Concat", "");
        strReturn = strReturn.Replace("Database", "");
        strReturn = strReturn.Replace("Limit", "");
        strReturn = strReturn.Replace("Limit 1", "");
        strReturn = strReturn.Replace("Where", "");
        strReturn = strReturn.Replace("Order By", "");
        strReturn = strReturn.Replace("Union Select", "");
        strReturn = strReturn.Replace("Union Select Version()", "");
        strReturn = strReturn.Replace("Union Select Database()", "");
        strReturn = strReturn.Replace("Table_Schema", "");
        strReturn = strReturn.Replace("From", "");
        strReturn = strReturn.Replace("Information_Schema", "");
        strReturn = strReturn.Replace("Information_Schema.Tables", "");
     
       
        strReturn = strReturn.Replace("Char", "");
        strReturn = strReturn.Replace("Char(32)", "");
        strReturn = strReturn.Replace("Password", "");
        strReturn = strReturn.Replace("Table", "");
        strReturn = strReturn.Replace("Users", "");
        strReturn = strReturn.Replace("Name", "");
        strReturn = strReturn.Replace("Script", "");
        strReturn = strReturn.Replace("<Script>", "");
        strReturn = strReturn.Replace("</Script>", "");
        strReturn = strReturn.Replace("Location", "");
        strReturn = strReturn.Replace("Http", "");
        strReturn = strReturn.Replace("Http://", "");
        strReturn = strReturn.Replace("Www", "");
        strReturn = strReturn.Replace("Www.", "");
        strReturn = strReturn.Replace("Dump", "");
        strReturn = strReturn.Replace("User", "");
        strReturn = strReturn.Replace("Password", "");
        strReturn = strReturn.Replace("Exec", "");
        strReturn = strReturn.Replace("Cmdshell", "");
        strReturn = strReturn.Replace("CHAR", "");
        strReturn = strReturn.Replace("DELETE", "");
        strReturn = strReturn.Replace("INSERT", "");
        strReturn = strReturn.Replace("UPDATE", "");
        strReturn = strReturn.Replace("SELECT", "");
        strReturn = strReturn.Replace("TRUNCATE", "");
        strReturn = strReturn.Replace("UNION", "");
        strReturn = strReturn.Replace("SCRIPT", "");
        strReturn = strReturn.Replace("CONCAT", "");
        strReturn = strReturn.Replace("DATABASE", "");
        strReturn = strReturn.Replace("LIMIT", "");
        strReturn = strReturn.Replace("LIMIT 1", "");
        strReturn = strReturn.Replace("WHERE", "");
        strReturn = strReturn.Replace("ORDER BY", "");
        strReturn = strReturn.Replace("UNION SELECT", "");
        strReturn = strReturn.Replace("UNION SELECT VERSION()", "");
        strReturn = strReturn.Replace("UNION SELECT DATABASE()", "");
        strReturn = strReturn.Replace("TABLE_SCHEMA", "");
        strReturn = strReturn.Replace("FROM", "");
        strReturn = strReturn.Replace("INFORMATION_SCHEMA", "");
        strReturn = strReturn.Replace("INFORMATION_SCHEMA.TABLES", "");
     
        
        strReturn = strReturn.Replace("CHAR", "");
        strReturn = strReturn.Replace("CHAR(32)", "");
        strReturn = strReturn.Replace("PASSWORD", "");
        strReturn = strReturn.Replace("TABLE", "");
        strReturn = strReturn.Replace("USERS", "");
        strReturn = strReturn.Replace("NAME", "");
        strReturn = strReturn.Replace("SCRIPT", "");
        strReturn = strReturn.Replace("<SCRIPT>", "");
        strReturn = strReturn.Replace("</SCRIPT>", "");
        strReturn = strReturn.Replace("LOCATION", "");
        strReturn = strReturn.Replace("HTTP", "");
        strReturn = strReturn.Replace("HTTP://", "");
        strReturn = strReturn.Replace("WWW", "");
        strReturn = strReturn.Replace("WWW.", "");
        strReturn = strReturn.Replace("DUMP", "");
        strReturn = strReturn.Replace("USER", "");
        strReturn = strReturn.Replace("PASSWORD", "");
        strReturn = strReturn.Replace("EXEC", "");
        strReturn = strReturn.Replace("CMDSHELL", "");
        strReturn = strReturn.Replace("'","");
        strReturn = strReturn.Replace("-","");
        strReturn = strReturn.Replace("!","");
        strReturn = strReturn.Replace("?","");
        strReturn = strReturn.Replace("(","");
        strReturn = strReturn.Replace(")","");
        strReturn = strReturn.Replace("{","");
        strReturn = strReturn.Replace("}","");
        strReturn = strReturn.Replace("<","");
        strReturn = strReturn.Replace(">","");
        strReturn = strReturn.Replace("/", "");
        strReturn = strReturn.Replace("=","");
        strReturn = strReturn.Replace("%","");
        strReturn = strReturn.Replace("&","");
        strReturn = strReturn.Replace(";","");
        strReturn = strReturn.Replace("+", "");
        strReturn = strReturn.Replace("*", "");
        strReturn = strReturn.Replace("''", "");
        strReturn = strReturn.Replace("[", "");
        strReturn = strReturn.Replace("]", "");
        
        return strReturn;


    }

    public static string UrlSeo(string Metin)
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
    public static string detaytemizlik(string Text)
    {

        string detayci = Text.Trim();

        detayci = detayci.Replace("--", "");
        detayci = detayci.Replace("'", "");
        detayci = detayci.Replace("char", "");
        detayci = detayci.Replace("delete", "");
        detayci = detayci.Replace("insert", "");
        detayci = detayci.Replace("update", "");
        detayci = detayci.Replace("select", "");
        detayci = detayci.Replace("truncate", "");
        detayci = detayci.Replace("union", "");
        detayci = detayci.Replace("script", "");
        detayci = detayci.Replace("concat", "");
        detayci = detayci.Replace("database", "");
        detayci = detayci.Replace("limit", "");
        detayci = detayci.Replace("limit 1", "");
        detayci = detayci.Replace("where", "");
        detayci = detayci.Replace("order by", "");
        detayci = detayci.Replace("union select", "");
        detayci = detayci.Replace("union select version()", "");
        detayci = detayci.Replace("union select database()", "");
        detayci = detayci.Replace("table_schema", "");
        detayci = detayci.Replace("from", "");
        detayci = detayci.Replace("information_schema", "");
        detayci = detayci.Replace("information_schema.tables", "");
        detayci = detayci.Replace("char", "");
        detayci = detayci.Replace("char(32)", "");
        detayci = detayci.Replace("password", "");
        detayci = detayci.Replace("table", "");
        detayci = detayci.Replace("users", "");
        detayci = detayci.Replace("name", "");
        detayci = detayci.Replace("script", "");
        detayci = detayci.Replace("<script>", "");
        detayci = detayci.Replace("</script>", "");
        detayci = detayci.Replace("location", "");
        detayci = detayci.Replace("dump", "");
        detayci = detayci.Replace("user", "");
        detayci = detayci.Replace("password", "");
        detayci = detayci.Replace("exec", "");
        detayci = detayci.Replace("cmdshell", "");
        detayci = detayci.Replace("Char", "");
        detayci = detayci.Replace("Delete", "");
        detayci = detayci.Replace("Insert", "");
        detayci = detayci.Replace("Update", "");
        detayci = detayci.Replace("Select", "");
        detayci = detayci.Replace("Truncate", "");
        detayci = detayci.Replace("Union", "");
        detayci = detayci.Replace("Script", "");
        detayci = detayci.Replace("Concat", "");
        detayci = detayci.Replace("Database", "");
        detayci = detayci.Replace("Limit", "");
        detayci = detayci.Replace("Limit 1", "");
        detayci = detayci.Replace("Where", "");
        detayci = detayci.Replace("Order By", "");
        detayci = detayci.Replace("Union Select", "");
        detayci = detayci.Replace("Union Select Version()", "");
        detayci = detayci.Replace("Union Select Database()", "");
        detayci = detayci.Replace("Table_Schema", "");
        detayci = detayci.Replace("From", "");
        detayci = detayci.Replace("Information_Schema", "");
        detayci = detayci.Replace("Information_Schema.Tables", "");
      
       
        detayci = detayci.Replace("Char", "");
        detayci = detayci.Replace("Char(32)", "");
        detayci = detayci.Replace("Password", "");
        detayci = detayci.Replace("Table", "");
        detayci = detayci.Replace("Users", "");
        detayci = detayci.Replace("Name", "");
        detayci = detayci.Replace("Script", "");
        detayci = detayci.Replace("<Script>", "");
        detayci = detayci.Replace("</Script>", "");
        detayci = detayci.Replace("Location", "");
        detayci = detayci.Replace("Dump", "");
        detayci = detayci.Replace("User", "");
        detayci = detayci.Replace("Password", "");
        detayci = detayci.Replace("Exec", "");
        detayci = detayci.Replace("Cmdshell", "");
        detayci = detayci.Replace("CHAR", "");
        detayci = detayci.Replace("DELETE", "");
        detayci = detayci.Replace("INSERT", "");
        detayci = detayci.Replace("UPDATE", "");
        detayci = detayci.Replace("SELECT", "");
        detayci = detayci.Replace("TRUNCATE", "");
        detayci = detayci.Replace("UNION", "");
        detayci = detayci.Replace("SCRIPT", "");
        detayci = detayci.Replace("CONCAT", "");
        detayci = detayci.Replace("DATABASE", "");
        detayci = detayci.Replace("LIMIT", "");
        detayci = detayci.Replace("LIMIT 1", "");
        detayci = detayci.Replace("WHERE", "");
        detayci = detayci.Replace("ORDER BY", "");
        detayci = detayci.Replace("UNION SELECT", "");
        detayci = detayci.Replace("UNION SELECT VERSION()", "");
        detayci = detayci.Replace("UNION SELECT DATABASE()", "");
        detayci = detayci.Replace("TABLE_SCHEMA", "");
        detayci = detayci.Replace("FROM", "");
        detayci = detayci.Replace("INFORMATION_SCHEMA", "");
        detayci = detayci.Replace("INFORMATION_SCHEMA.TABLES", "");
      
       
        detayci = detayci.Replace("CHAR", "");
        detayci = detayci.Replace("CHAR(32)", "");
        detayci = detayci.Replace("PASSWORD", "");
        detayci = detayci.Replace("TABLE", "");
        detayci = detayci.Replace("USERS", "");
        detayci = detayci.Replace("NAME", "");
        detayci = detayci.Replace("SCRIPT", "");
        detayci = detayci.Replace("<SCRIPT>", "");
        detayci = detayci.Replace("</SCRIPT>", "");
        detayci = detayci.Replace("LOCATION", "");
        detayci = detayci.Replace("DUMP", "");
        detayci = detayci.Replace("USER", "");
        detayci = detayci.Replace("PASSWORD", "");
        detayci = detayci.Replace("EXEC", "");
        detayci = detayci.Replace("CMDSHELL", "");
        detayci = detayci.Replace("'", "");
        detayci = detayci.Replace("!", "");
        detayci = detayci.Replace("?", "");
        detayci = detayci.Replace("{", "");
        detayci = detayci.Replace("}", "");
        detayci = detayci.Replace("@", "");
        detayci = detayci.Replace("%", "");
        detayci = detayci.Replace("+", "");
        detayci = detayci.Replace("*", "");
      
       
        
        return detayci;


    }
    public static string virgulyoktemizlik(string Text)
    {
        string virgulyok = Text.Trim();

        virgulyok = virgulyok.Replace("&gt;", "");
        virgulyok = virgulyok.Replace("&lt;", "");
        virgulyok = virgulyok.Replace("--", "");
        virgulyok = virgulyok.Replace("'", "");
        virgulyok = virgulyok.Replace("char", "");
        virgulyok = virgulyok.Replace("delete", "");
        virgulyok = virgulyok.Replace("insert", "");
        virgulyok = virgulyok.Replace("update", "");
        virgulyok = virgulyok.Replace("select", "");
        virgulyok = virgulyok.Replace("truncate", "");
        virgulyok = virgulyok.Replace("union", "");
        virgulyok = virgulyok.Replace("script", "");
        virgulyok = virgulyok.Replace("concat", "");
        virgulyok = virgulyok.Replace("database", "");
        virgulyok = virgulyok.Replace("limit", "");
        virgulyok = virgulyok.Replace("limit 1", "");
        virgulyok = virgulyok.Replace("where", "");
        virgulyok = virgulyok.Replace("order by", "");
        virgulyok = virgulyok.Replace("union select", "");
        virgulyok = virgulyok.Replace("union select version()", "");
        virgulyok = virgulyok.Replace("union select database()", "");
        virgulyok = virgulyok.Replace("table_schema", "");
        virgulyok = virgulyok.Replace("from", "");
        virgulyok = virgulyok.Replace("information_schema", "");
        virgulyok = virgulyok.Replace("information_schema.tables", "");
       
        
        virgulyok = virgulyok.Replace("char", "");
        virgulyok = virgulyok.Replace("char(32)", "");
        virgulyok = virgulyok.Replace("password", "");
        virgulyok = virgulyok.Replace("table", "");
        virgulyok = virgulyok.Replace("users", "");
        virgulyok = virgulyok.Replace("name", "");
        virgulyok = virgulyok.Replace("script", "");
        virgulyok = virgulyok.Replace("<script>", "");
        virgulyok = virgulyok.Replace("</script>", "");
        virgulyok = virgulyok.Replace("location", "");
        virgulyok = virgulyok.Replace("http", "");
        virgulyok = virgulyok.Replace("http://", "");
        virgulyok = virgulyok.Replace("www", "");
        virgulyok = virgulyok.Replace("www.", "");
        virgulyok = virgulyok.Replace("dump", "");
        virgulyok = virgulyok.Replace("password", "");
        virgulyok = virgulyok.Replace("exec", "");
        virgulyok = virgulyok.Replace("cmdshell", "");
        virgulyok = virgulyok.Replace("Char", "");
        virgulyok = virgulyok.Replace("Delete", "");
        virgulyok = virgulyok.Replace("Insert", "");
        virgulyok = virgulyok.Replace("Update", "");
        virgulyok = virgulyok.Replace("Select", "");
        virgulyok = virgulyok.Replace("Truncate", "");
        virgulyok = virgulyok.Replace("Union", "");
        virgulyok = virgulyok.Replace("Script", "");
        virgulyok = virgulyok.Replace("Concat", "");
        virgulyok = virgulyok.Replace("Database", "");
        virgulyok = virgulyok.Replace("Limit", "");
        virgulyok = virgulyok.Replace("Limit 1", "");
        virgulyok = virgulyok.Replace("Where", "");
        virgulyok = virgulyok.Replace("Order By", "");
        virgulyok = virgulyok.Replace("Union Select", "");
        virgulyok = virgulyok.Replace("Union Select Version()", "");
        virgulyok = virgulyok.Replace("Union Select Database()", "");
        virgulyok = virgulyok.Replace("Table_Schema", "");
        virgulyok = virgulyok.Replace("From", "");
        virgulyok = virgulyok.Replace("Information_Schema", "");
        virgulyok = virgulyok.Replace("Information_Schema.Tables", "");
       
        
        virgulyok = virgulyok.Replace("Char", "");
        virgulyok = virgulyok.Replace("Char(32)", "");
        virgulyok = virgulyok.Replace("Password", "");
        virgulyok = virgulyok.Replace("Table", "");
        virgulyok = virgulyok.Replace("Users", "");
        virgulyok = virgulyok.Replace("Name", "");
        virgulyok = virgulyok.Replace("Script", "");
        virgulyok = virgulyok.Replace("<Script>", "");
        virgulyok = virgulyok.Replace("</Script>", "");
        virgulyok = virgulyok.Replace("Location", "");
        virgulyok = virgulyok.Replace("Http", "");
        virgulyok = virgulyok.Replace("Http://", "");
        virgulyok = virgulyok.Replace("Www", "");
        virgulyok = virgulyok.Replace("Www.", "");
        virgulyok = virgulyok.Replace("Dump", "");
        virgulyok = virgulyok.Replace("User", "");
        virgulyok = virgulyok.Replace("Password", "");
        virgulyok = virgulyok.Replace("Exec", "");
        virgulyok = virgulyok.Replace("Cmdshell", "");
        virgulyok = virgulyok.Replace("CHAR", "");
        virgulyok = virgulyok.Replace("DELETE", "");
        virgulyok = virgulyok.Replace("INSERT", "");
        virgulyok = virgulyok.Replace("UPDATE", "");
        virgulyok = virgulyok.Replace("SELECT", "");
        virgulyok = virgulyok.Replace("TRUNCATE", "");
        virgulyok = virgulyok.Replace("UNION", "");
        virgulyok = virgulyok.Replace("SCRIPT", "");
        virgulyok = virgulyok.Replace("CONCAT", "");
        virgulyok = virgulyok.Replace("DATABASE", "");
        virgulyok = virgulyok.Replace("LIMIT", "");
        virgulyok = virgulyok.Replace("LIMIT 1", "");
        virgulyok = virgulyok.Replace("WHERE", "");
        virgulyok = virgulyok.Replace("ORDER BY", "");
        virgulyok = virgulyok.Replace("UNION SELECT", "");
        virgulyok = virgulyok.Replace("UNION SELECT VERSION()", "");
        virgulyok = virgulyok.Replace("UNION SELECT DATABASE()", "");
        virgulyok = virgulyok.Replace("TABLE_SCHEMA", "");
        virgulyok = virgulyok.Replace("FROM", "");
        virgulyok = virgulyok.Replace("INFORMATION_SCHEMA", "");
        virgulyok = virgulyok.Replace("INFORMATION_SCHEMA.TABLES", "");
       
        virgulyok = virgulyok.Replace("CHAR", "");
        virgulyok = virgulyok.Replace("CHAR(32)", "");
        virgulyok = virgulyok.Replace("PASSWORD", "");
        virgulyok = virgulyok.Replace("TABLE", "");
        virgulyok = virgulyok.Replace("USERS", "");
        virgulyok = virgulyok.Replace("NAME", "");
        virgulyok = virgulyok.Replace("SCRIPT", "");
        virgulyok = virgulyok.Replace("<SCRIPT>", "");
        virgulyok = virgulyok.Replace("</SCRIPT>", "");
        virgulyok = virgulyok.Replace("LOCATION", "");
        virgulyok = virgulyok.Replace("HTTP", "");
        virgulyok = virgulyok.Replace("HTTP://", "");
        virgulyok = virgulyok.Replace("WWW", "");
        virgulyok = virgulyok.Replace("WWW.", "");
        virgulyok = virgulyok.Replace("DUMP", "");
        virgulyok = virgulyok.Replace("USER", "");
        virgulyok = virgulyok.Replace("PASSWORD", "");
        virgulyok = virgulyok.Replace("EXEC", "");
        virgulyok = virgulyok.Replace("CMDSHELL", "");
        virgulyok = virgulyok.Replace("'", "");
        virgulyok = virgulyok.Replace("-", "");
        virgulyok = virgulyok.Replace("!", "");
        virgulyok = virgulyok.Replace("?", "");
        virgulyok = virgulyok.Replace("(", "");
        virgulyok = virgulyok.Replace(")", "");
        virgulyok = virgulyok.Replace("{", "");
        virgulyok = virgulyok.Replace("}", "");
        virgulyok = virgulyok.Replace("<", "");
        virgulyok = virgulyok.Replace(">", "");
        virgulyok = virgulyok.Replace("=", "");
        virgulyok = virgulyok.Replace("%", "");
        virgulyok = virgulyok.Replace("&", "");
        virgulyok = virgulyok.Replace(";", "");
        virgulyok = virgulyok.Replace("+", "");
        virgulyok = virgulyok.Replace("*", "");
        virgulyok = virgulyok.Replace("''", "");
        virgulyok = virgulyok.Replace("[", "");
        virgulyok = virgulyok.Replace("]", "");

        return virgulyok;


    }

}