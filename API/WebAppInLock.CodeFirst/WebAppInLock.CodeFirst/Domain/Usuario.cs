﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppInLock.CodeFirst.Domain
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique= true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email obrigatorio")]

        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Senha obrigatorio")]
        [StringLength(200, MinimumLength =6, ErrorMessage ="Senha de 6 a 20 caracteres")]

        public string? Senha { get; set; }

        [Required(ErrorMessage ="Tipo do usuario obrigatorio")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TipoUsuario { get; set; }
    }
}