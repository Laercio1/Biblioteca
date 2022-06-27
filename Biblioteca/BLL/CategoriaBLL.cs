using Model;
using System;
using System.Data;

namespace BLL
{
    class CategoriaBLL
    {
        public Categoria Inserir(Categoria _categoria)
        {
            if (_categoria.Descricao == "")
                throw new Exception("Informe a descrição");

            CategoriaBLL categoriaBLL = new CategoriaBLL();
            return categoriaBLL.Inserir(_categoria);
        }

        public DataTable Buscar(string _filtro)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            return categoriaBLL.Buscar(_filtro);
        }
        public Categoria Alterar(Categoria _categoria)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            return categoriaBLL.Alterar(_categoria);
        }
        public void Excluir(int _id)
        {
            CategoriaBLL categoriaBLL = new CategoriaBLL();
            categoriaBLL.Excluir(_id);
        }
    }
}
