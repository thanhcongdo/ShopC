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
    [Table("SupportOnlines")]
    public class SupportOnline
    {
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Chỉ ra đc ID tự tăng
        public int ID { set; get; }

        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Department { set; get; }

        [MaxLength(50)]
        public string Skype { set; get; }

        [MaxLength(50)]
        public string Mobile { set; get; }

        [MaxLength(50)]
        public string Email { set; get; }

        [MaxLength(50)]
        public string Yahoo { set; get; }

         [MaxLength(50)]
        public string Facebook { set; get; }
       
        public int? DisplayOrder {set; get; }

        [MaxLength(50)]

        public bool Status {set; get; }

    }
}