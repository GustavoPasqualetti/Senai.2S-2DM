using System;
using System.Collections.Generic;

namespace WebAPI.InLock.DbFirst.Domains;

public partial class TiposUsuario
{
    public Guid IdTipoUsuario { get; set; }

    public string Titulo { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
