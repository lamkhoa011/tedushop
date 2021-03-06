using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Product")]
    public class Product : ISeoable, IAuditable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        [Required]
        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory {set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }

        public string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CreateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}