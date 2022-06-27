using Model;
using System;
using System.Data;

namespace BLL
{
    class EstadoBLL
    {
        public Estado Inserir(Estado _estado)
        {
            if (_estado.Descricao == "")
                throw new Exception("Informe a descrição");

            EstadoBLL estadoBLL = new EstadoBLL();
            return estadoBLL.Inserir(_estado);
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
