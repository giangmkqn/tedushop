using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;
namespace TeduShop.Model.Model
{  
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        //[Required]
        //[MaxLength(250)] 
        //public string Code { get; set; }

        //[MaxLength(250)]
        //public string ValueString { get; set; }

        //[MaxLength(250)]
        //public int? ValueIng { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }

        public string Content { get; set; }

    }
}
