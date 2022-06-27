using Model;
using System;
using System.Data;

namespace BLL
{
    class CidadeBLL
    {
        public Cidade Inserir(Cidade _cidade)
        {
            if (_cidade.Descricao == "")
                throw new Exception("Informe a descrição");

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
            CidadeBLL cidadeBLL = new CidadeBLL();
            return cidadeBLL.Alterar(_categoria);
        }
        public void Excluir(int _id)
        {
            CidadeBLL cidadeBLL = new CidadeBLL();
            cidadeBLL.Excluir(_id);
        }
    }
}
