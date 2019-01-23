using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("PostTags")]
    public class PostTag
    { 
        [Key]
        [Column(Order = 1)]
        public int PostID { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(Order = 2)]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

    }
}
