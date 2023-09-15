using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.Inlock.CodeFirst.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true )]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email Obrigatorio ")]
        public String? Email { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Senha Obrigatoria")]
        [StringLength(200,MinimumLength = 3 , ErrorMessage = "Senha de Minimo 3 caracteres no Maximo 20")]
        public String? Senha { get; set; }

        //Referencia a Tipo Usuario 

        [Required(ErrorMessage = "Tipo do Usuario Obrigatorio")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TipoUsuario { get; set; }
    }
}
