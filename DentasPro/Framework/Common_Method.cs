/*Ortak metodlar*/
namespace Dentas_Pro.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Common_Methods
    {
        /// <Development Note>
        /// String datanın sadece ilk harfini büyük harf yapar kalanları küçük.
        /// İrfan_D.
        /// Developed_Time             : 2015_01_15_09:34
        /// Additional_Development Time: 2015_02_26_10:36
        /// </summary>
        public static string Fitst_Letter_Upper_Case_Other_Lower(string value)
        {
            {
                char[] array = value.ToCharArray();
                // Handle the first letter in the string.
                if (array.Length >= 1)
                {
                    if (char.IsLower(array[0]))
                    {
                        array[0] = char.ToUpper(array[0]);
                    }
                }
                // Scan through the letters, checking for spaces.
                // ... Uppercase the lowercase letters following spaces.
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] != ' ')
                    {
                        if (char.IsUpper(array[i]))
                        {
                            array[i] = char.ToLower(array[i]);
                        }
                    }
                }
                return new string(array);
            }
        }


        /// <summary>
        /// Bu metod strin değeri hem int'e parse ediyor hemde 
        /// ilk değer veriyor
        /// 2015_01_16_
        /// By: İrfan_Dölek
        /// </summary>
        public static int Convert_String_To_Int(this string Value)
        {
            if (Value == "" || Value == null)
            {
                Value = "0";
            }
            return int.Parse(Value);
        }

        public static DateTime Convert_String_To_DateTime(this string Value)
        {
            if (Value == "" || Value == null)
            {
                Value = "0";
            }

            return DateTime.Parse(Value);
        }


        public static bool Citizen_Id_Check(string citizen_Id)
        {
            bool returnvalue = false;
            if (citizen_Id.Length == 11)
            {
                Int64 atcno, btcno, tcno;
                long c1, c2, c3, c4, c5, c6, c7, c8, c9, q1, q2;
                tcno = Int64.Parse(citizen_Id);
                atcno = tcno / 100;
                btcno = tcno / 100;
                c1 = atcno % 10;
                atcno = atcno / 10;
                c2 = atcno % 10;
                atcno = atcno / 10;
                c3 = atcno % 10;
                atcno = atcno / 10;
                c4 = atcno % 10;
                atcno = atcno / 10;
                c5 = atcno % 10;
                atcno = atcno / 10;
                c6 = atcno % 10;
                atcno = atcno / 10;
                c7 = atcno % 10;
                atcno = atcno / 10;
                c8 = atcno % 10;
                atcno = atcno / 10;
                c9 = atcno % 10;
                atcno = atcno / 10;
                q1 = ((10 - ((((c1 + c3 + c5 + c7 + c9) * 3) + (c2 + c4 + c6 + c8)) % 10)) % 10);
                q2 = ((10 - (((((c2 + c4 + c6 + c8) + q1) * 3) + (c1 + c3 + c5 + c7 + c9)) % 10)) % 10);
                returnvalue = ((btcno * 100) + (q1 * 10) + q2 == tcno);
            }
            return returnvalue;
        }

    }
}
