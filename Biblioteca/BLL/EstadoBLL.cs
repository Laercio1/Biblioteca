using Model;
using System.Data;

namespace BLL
{
    class EstadoBLL
    {
        public Estado Inserir(Estado _categoria)
        {
            EstadoBLL categoriaBLL = new EstadoBLL();
            return categoriaBLL.Inserir(_categoria);
        }

        public DataTable Buscar(string _filtro)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            return estadoBLL.Buscar(_filtro);
        }
        public Estado Alterar(Estado _estado)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            return estadoBLL.Alterar(_estado);
        }
        public void Excluir(int _id)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            estadoBLL.Excluir(_id);
        }
    }
}
