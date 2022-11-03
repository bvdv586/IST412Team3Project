﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace LogisticalEnterprises.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name ="Product Description")]
        public string ProductDescription { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}
