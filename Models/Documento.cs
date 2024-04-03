using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EditorTexto.Models
{
    public class Documento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Corpo { get; set; }
        [Required]
        public string UsuarioId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? Usuario { get; set; }
    }
}
