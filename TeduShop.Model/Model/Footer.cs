using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("Footers")]
    class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string Content { get; set; }
    }
}
