using Model;
using System.Data;

namespace BLL
{
    class CidadeBLL
    {
        public Cidade Inserir(Cidade _cidade)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            return cidadeBLL.Inserir(_cidade);
        }

        public DataTable Buscar(string _filtro)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            return cidadeBLL.Buscar(_filtro);
        }
        public Cidade Alterar(Cidade _categoria)
        {
            CidadeBLL categoriaBLL = new CidadeBLL();
            return categoriaBLL.Alterar(_categoria);
        }
        public void Excluir(int _id)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            cidadeBLL.Excluir(_id);
        }
    }
}
