using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {

       public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
       public string CreatedBy { set; get; }
       public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }

    }
}
