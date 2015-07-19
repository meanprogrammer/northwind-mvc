using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Mvc.Data.Models
{
    [MetadataType(typeof(CategoryMeta))]
    public partial class Category
    { 
        //this is just a test
    }

    public class CategoryMeta
    {
        [Required(ErrorMessage="Name is required.")]
        [Display(Name="Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
