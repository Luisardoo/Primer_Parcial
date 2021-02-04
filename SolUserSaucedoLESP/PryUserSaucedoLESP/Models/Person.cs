namespace PryUserSaucedoLESP.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Person
    {
        [Key]
        public int id { get; set; }
        [StringLength(100, ErrorMessage = "Porfavor ingrese su nombre completo entre 5 o 100 caracteres", MinimumLength = 5)]
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public Address address { get; set; }
        [Required]
        public string phone { get; set; }
        [Required]
        public string website { get; set; }
        [Required]
        public Company company { get; set; }


    }
}