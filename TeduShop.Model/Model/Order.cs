using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("Orders")]
    class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmai{ get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerMobile{ get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerMessage{ get; set; }

        public DateTime CreatedDate { get; set; }


        [MaxLength(50)]
        public string CreatedBy {get; set; }


        [Required]
        [MaxLength(250)]
        public string PaymentMethod { get; set; }


        [Required]
        [MaxLength(250)]
        public string PaymentStatus { get; set; }


        [Required]
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
