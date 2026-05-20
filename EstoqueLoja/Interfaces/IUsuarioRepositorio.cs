using EstoqueLoja.Models;

namespace EstoqueLoja.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Usuario? Validar(string email, string senha);
    }
}
