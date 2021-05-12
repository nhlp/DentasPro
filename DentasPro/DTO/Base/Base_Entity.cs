/*Bütün entitylerin base'i*/
namespace Dentas_Pro.DTO.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Base_Entity
    {
        #region Description
        /*Kaydı yapan kullanıcı adı + soyadı bilgisi*/
        #endregion
        public string Insert_User { get; set; }
        #region Description
        /*Kaydın insert edildiği tarih*/
        #endregion
        public DateTime Insert_Time { get; set; }
        #region Description
        /*Kaydı güncelleyen kişinin ad+ soyadı*/
        #endregion
        public string Update_User { get; set; }
        #region Description
        /*Kaydın güncellenme tarihi*/
        #endregion
        public DateTime Update_Time { get; set; }

        public bool Active { get; set; }

        public Base_Entity() 
        {
            Insert_User = string.Empty;
            Insert_Time = DateTime.Now.Date;
            Update_User = string.Empty;
            Active = true;
        }
    }
}
