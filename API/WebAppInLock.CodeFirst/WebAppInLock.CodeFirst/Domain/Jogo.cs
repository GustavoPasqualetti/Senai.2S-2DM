﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppInLock.CodeFirst.Domain
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do jogo e obrigatorio")]

        public string? Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao do jogo obrigatorio")]

        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data do lancamento obrigatorio")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "Decimal(5,2)")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "Informe o estudio que produziu o jogo")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio Estudio { get; set; }
    }
}
