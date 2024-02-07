using System;
using System.Collections.Generic;

namespace WebAPI.InLock.DbFirst.Domains;

public partial class Usuario
{
    public Guid IdUsuario { get; set; }

    public Guid? IdTipoUsuario { get; set; }

    public string Email { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public virtual TiposUsuario? IdTipoUsuarioNavigation { get; set; }
}
