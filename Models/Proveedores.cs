using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace firstApp.Models
{
    public class Proveedores
    {
        //definir propiedades
        [Key]
        public int proveedorID {get; set;}

        [Required(ErrorMessage="Firstname is required")]
        [Display(Name="Firstname")]
        public string firstName {get; set;}
        [Required(ErrorMessage="Lastname is required")]
        [Display(Name="Lastname")]
        public string lastName {get; set;}
        [Required(ErrorMessage="Email is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email", Prompt="email@domain.com")]
        public string email {get; set;}
        [Required(ErrorMessage="Address is required")]
        [Display(Name="Address")]
        public string address {get; set;}
        [Required(ErrorMessage="Telephon is required")]
        [Display(Name="Telephone")]
        public int telephone {get; set;}

        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();


    }
}