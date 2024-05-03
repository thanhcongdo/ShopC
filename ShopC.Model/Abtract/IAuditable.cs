using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopC.Model.Abtract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        [MaxLength(256)]
        string MetaKeyword { set; get; }

        [MaxLength(256)]
        string MetaDescription { set; get; }
        bool Status { set; get; }

    }
}
