/*Kullanıcıların bağlı oldukları departman*/
namespace Dentas_Pro.DTO.Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Dentas_Pro.DTO.Base;

    public class User_Department : Base_Entity
    {
        #region Description
        /*Departman kodu*/
        #endregion
        public string Code { get; set; }

        #region Description
        /*Departman Adı*/
        #endregion
        public string Name { get; set; }


        public User_Department() 
        {
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}

