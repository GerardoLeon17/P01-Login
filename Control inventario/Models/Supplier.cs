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
        [Required]
        [MaxLength(10)]
        [StringLength(100,ErrorMessage ="El {0} debe tener un lago de {1} caracteres")]

        public string SupplierCode { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Nombre")]
        public string SupplierName { get; set; }
        [Display(Name = "Correo")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Display(Name = "Direccion")]
        public string Address { get; set; }
    }
}