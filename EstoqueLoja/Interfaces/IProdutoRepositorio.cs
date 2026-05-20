using EstoqueLoja.Models;

namespace EstoqueLoja.Interfaces
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(int id);
        IEnumerable<Produto> ListarProdutos();
        Produto? BuscarPorId(int id);
    }
}
