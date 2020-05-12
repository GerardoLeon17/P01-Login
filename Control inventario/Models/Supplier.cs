using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Control_inventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Display(Name = "Codigo Proveedor")]//Data annotation
        public string SupplierCode { get; set; }
        [Display(Name = "Nombre")]
        public string SupplierName { get; set; }
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        public string Phone { get; set; }
        [Display(Name = "Direccion")]
        public string Address { get; set; }
    }
}