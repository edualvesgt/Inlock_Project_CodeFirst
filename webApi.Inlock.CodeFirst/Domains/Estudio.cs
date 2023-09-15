using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.Inlock.CodeFirst.Domains
{
    //Informando que essa tabela vira uma la no banco de Dados
    [Table("Estudio")]
    public class Estudio
    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "Nome do Estudio Obrigatorio")]
        public String? Nome { get; set; }

        public List<Jogo>? Jogo { get; set; }

    }
}
