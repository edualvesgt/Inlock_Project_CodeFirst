using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi.Inlock.CodeFirst.Domains
{
    [Table ("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required (ErrorMessage = "Nome do Jogo OBRIGATORIO")]
        public String? Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao do Jogo obrigatorio")]
        public String? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required (ErrorMessage = "Data do Lancamento Obrigatoria ")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "Preco do Jogo OBRIGATORIO")]
        public decimal Preco { get; set; }

        //Referencia da Chave estrangeira (Tabela Estudio)
        
        [Required(ErrorMessage = "Obrigatorio informar o estudio")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }


    }
}
