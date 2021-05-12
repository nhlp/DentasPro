namespace Dentas_Pro.UI.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Text_Replacer
    {
        public string Replace_The_Text(string value) 
        {
            string once, sonra;
            once = value;
            sonra = once.Replace('ı', 'i');
            once = sonra.Replace('ö', 'o');
            sonra = once.Replace('ü', 'u');
            once = sonra.Replace('ş', 's');
            sonra = once.Replace('ğ', 'g');
            once = sonra.Replace('ç', 'c');
            /*sonra = once.Replace('İ', 'I');
            once = sonra.Replace('Ö', 'O');
            sonra = once.Replace('Ü', 'U');
            once = sonra.Replace('Ş', 'S');
            sonra = once.Replace('Ğ', 'G');
            once = sonra.Replace('Ç', 'C');*/
            value = once;
            return value;
        }
    }
}
