using Model;
using System;
using System.Data;

namespace BLL
{
    class SituacaoBLL
    {
        public Situacao Inserir(Situacao _situacao)
        {
            if (_situacao.Descricao == "")
                throw new Exception("Informe a descrição");

            SituacaoBLL situacaoBLL = new SituacaoBLL();
            return situacaoBLL.Inserir(_situacao);
        }

        public DataTable Buscar(string _filtro)
        {
            SituacaoBLL situacaoBLL = new SituacaoBLL();
            return situacaoBLL.Buscar(_filtro);
        }
        public Situacao Alterar(Situacao _situacao)
        {
            SituacaoBLL situacaoBLL = new SituacaoBLL();
            return situacaoBLL.Alterar(_situacao);
        }
        public void Excluir(int _id)
        {
            SituacaoBLL situacaoBLL = new SituacaoBLL();
            situacaoBLL.Excluir(_id);
        }
    }
}
