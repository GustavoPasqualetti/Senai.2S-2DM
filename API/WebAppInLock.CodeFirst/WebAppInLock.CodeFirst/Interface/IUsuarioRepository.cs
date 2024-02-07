using WebAppInLock.CodeFirst.Domain;

namespace WebAppInLock.CodeFirst.Interface
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);

        void Cadastrar(Usuario usuario);
    }
}
