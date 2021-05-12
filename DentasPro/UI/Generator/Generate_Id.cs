/*
*Unique Id üretir. Ihtiyaç olan her yer için kullanabilirsin.
*/
namespace Dentas_Pro.UI.Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Generate_Id
    {
        DAL_Function.Sql_Server_DB_From_DentasProDataContext sql_Server_Db_From_DentasProDataContext = new DAL_Function.Sql_Server_DB_From_DentasProDataContext();
        DAL_Function.Messages messages = new DAL_Function.Messages();

        public string Generate_The_Unique_Id_For_Department_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_ForDepartment = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Departments
                 #region Description
 /*Obj_Id alanını ters'ten sıralıyoruz.*/
 #endregion
                 orderby s.Obj_Id descending
                 select s
                 ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_ForDepartment++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_ForDepartment.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        public string Generate_The_Unique_Id_For_Registration_Number_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Users
                #region Description
 /*Obj_Id alanını ters'ten sıralıyoruz.*/
 #endregion
                orderby s.Obj_Id descending
                select s
                ).First().Registration_Number);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        public string Generate_The_Unique_Id_For_Expense_Group_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Expense_Groups
                 #region Description
                 /*Obj_Id alanını ters'ten sıralıyoruz.*/
                 #endregion
                 orderby s.Obj_Id descending
                 select s
                ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        public string Generate_The_Unique_Id_For_Permit_Reason_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Permit_Reasons
                 #region Description
                 /*Obj_Id alanını ters'ten sıralıyoruz.*/
                 #endregion
                 orderby s.Obj_Id descending
                 select s
                ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        public string Generate_The_Unique_Id_For_Title_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Titles
                 #region Description
                 /*Obj_Id alanını ters'ten sıralıyoruz.*/
                 #endregion
                 orderby s.Obj_Id descending
                 select s
                ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        /// <summary>
        /// Seyehat harcama türü
        /// </summary>
        public string Generate_The_Unique_Id_For_Travel_Expense_Type_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Travel_Expense_Types
                 #region Description
                 /*Obj_Id alanını ters'ten sıralıyoruz.*/
                 #endregion
                 orderby s.Obj_Id descending
                 select s
                ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        public string Generate_The_Unique_Id_For_Travel_Vehicle_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Travel_Vehicles
                 #region Description
                 /*Obj_Id alanını ters'ten sıralıyoruz.*/
                 #endregion
                 orderby s.Obj_Id descending
                 select s
                ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }

        public string Generate_The_Unique_Id_For_Location_Id()
        {
            try
            {
                #region Description
                /*Select ettiğim Id'yi "int.Parse" ile int'e cast ediyoruz.*/
                #endregion
                int Number_For_Registration_Id = int.Parse(
                #region Description
                    /*Obj_Id'yi okuyoruz.*/
                #endregion
                (from s
                 in sql_Server_Db_From_DentasProDataContext.Locations
                 #region Description
                 /*Obj_Id alanını ters'ten sıralıyoruz.*/
                 #endregion
                 orderby s.Obj_Id descending
                 select s
                ).First().Code);
                #region Description
                /*Numarayı 1 artırıyoruz*/
                #endregion
                Number_For_Registration_Id++;
                #region Description
                /*Numarayı 7 digit olacak hale getiriyoruz*/
                #endregion
                string New_Number = Number_For_Registration_Id.ToString().PadLeft(3, '0');
                #region Description
                /*Numarayı dışarı veriyoruz*/
                #endregion
                return New_Number;
            }
            #region Description
            /*
            * Eğer herhangi bir numara yok ise "0000001" döndürecek.
            * 
            */
            #endregion
            catch (Exception)
            {
                return "001";
            }
        }
    }
}
