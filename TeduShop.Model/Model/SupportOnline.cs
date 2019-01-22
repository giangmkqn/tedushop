using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
    class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(250)]
        public string Department { get; set; }
        [MaxLength(250)]
        public string Skype { get; set; }
        [MaxLength(250)]
        public string Mobile { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Facebook { get; set; }
        [MaxLength(250)]
        public string Yahoo { get; set; }

        public int? DisplayOrder { get; set; }
        public bool Status { get; set; }
    }
}
