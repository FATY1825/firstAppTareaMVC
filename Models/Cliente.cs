using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace firstApp.Models
{
    public class Cliente
    {
        [Key]
        public int clienteId { get; set; }
        [Required(ErrorMessage="Names is required")]
        [Display(Name="Names")]
        public string names { get; set; }
        [Required(ErrorMessage="Address is required")]
        [Display(Name="Address")]
        public string address { get; set; }
        [Required(ErrorMessage="Telephone is required")]
        [Display(Name="Telephone")]
        public string telephone { get; set; }
        [Required(ErrorMessage="Mobile is required")]
        [Display(Name="Mobile")]
        public string mobile { get; set; }

        //Referencias a proveedores 
        [Required(ErrorMessage="Proveedor is required")]
        [Display(Name="Proveedor")]
        public int proveedorID { get; set; }
        public Proveedores Proveedores { get; set; }
    }
}