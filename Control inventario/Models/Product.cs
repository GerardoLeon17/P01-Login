using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Control_inventario.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name ="Codigo")]//Data annotation
        public string ProductCode { get; set; }
        [Display(Name = "Nombre")]
        public string ProductName { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

    }
}