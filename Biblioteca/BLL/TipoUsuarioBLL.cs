using Model;
using System.Data;
namespace BLL
{
    class TipoUsuarioBLL
    {
        public TipoUsuarioBLL Inserir(TipoUsuarioBLL _tipousuario)
        {
            TipoUsuarioBLL tipousuarioBLL = new TipoUsuarioBLL();
            return tipousuarioBLL.Inserir(_tipousuario);
        }

        public DataTable Buscar(string _filtro)
        {
            TipoUsuarioBLL tipousuarioBLL = new TipoUsuarioBLL();
            return tipousuarioBLL.Buscar(_filtro);
        }
        public TipoUsuarioBLL Alterar(TipoUsuarioBLL _tipousuario)
        {
            TipoUsuarioBLL tipousuarioBLL = new TipoUsuarioBLL();
            return tipousuarioBLL.Alterar(_tipousuario);
        }
        public void Excluir(int _id)
        {
            TipoUsuarioBLL tipousuarioBLL = new TipoUsuarioBLL();
            tipousuarioBLL.Excluir(_id);
        }
    }
}
