using System.ComponentModel.DataAnnotations;

namespace BlogCore.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public string Smarthphone { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
