using System;
namespace TeduShop.Model.Abstract
{
    public interface  IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { set; get; }

    }
}
