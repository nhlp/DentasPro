/*İzin türleri*/
namespace Dentas_Pro.DTO.Permit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using Dentas_Pro.DTO.Base;

    class Permit_Reason : Base_Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Permit_Reason() 
        {
            Code = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
        }
    }
}
