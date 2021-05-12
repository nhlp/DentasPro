
namespace Dentas_Pro.DTO.Definition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Dentas_Pro.DTO.Base;

    /// <summary>
    /// Ünvan entity'si
    /// Bu enetity'yi Base _Entity'den inherit ettiğim için c_tor'da bu entity'de olmayan fieldları da new edebildim.
    /// </summary>
    public class Title : Base_Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Title() 
        {
            Code = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
            Active = true;
            Insert_Time = DateTime.Now;
            Insert_User = string.Empty;
            Update_Time = DateTime.MinValue;
            Update_User = string.Empty;
        }
    }
}
