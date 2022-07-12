using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EWork.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }
    public class CategoryMetaData
    {
        [Required(ErrorMessage ="يجب ادخال هذا الحقل")]
        [MaxLength(50, ErrorMessage ="طول الحقل لا يمكن ان يتجاوز ال 50 حرف")]        
        public string Name { get; set; }
    }
}