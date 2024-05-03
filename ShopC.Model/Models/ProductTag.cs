using ShopC.Model.Abtract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopC.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag 
    {
        [Key]
        public int ProductID { set; get; }
        [Required]

        [Key]
        [Collum(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagID { set; get; }

        [ForeignKey("PostID")]
        public virtual Product Product { set; get; } 
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
