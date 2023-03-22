using System;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Models
{
    public class CategoryDetail
    {

        public int CategoryId { get; set; }
        //annotation
        [Required(ErrorMessage ="CategoryName is required")]
        [StringLength(100,ErrorMessage ="Minimum 3 and Minimum 5 and max 100 caractere",MinimumLength=3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }

    }

    public class ProductDetail
    {

        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and max 100 caractere", MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        [Range(1,50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> isActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        [Range(typeof(int),"1","500",ErrorMessage ="Invalid Quantity")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal),"1","200000",ErrorMessage ="invalid Price")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }
    }
}