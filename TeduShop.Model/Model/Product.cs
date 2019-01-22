﻿using System;
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
    [Table("Products")]
    public class Product : Auditable {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        
        [MaxLength(500)]
        public XElement MoreImages { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        [MaxLength(500  )]
        public string Description { get; set; }
        public string Content {get;set;}

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

    }
}
