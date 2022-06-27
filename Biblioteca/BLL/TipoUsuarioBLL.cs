using Model;
using System;
using System.Data;
namespace BLL
{
    class TipoUsuarioBLL
    {
        public TipoUsuarioBLL Inserir(TipoUsuario _tipoUsuario)
        {
            if (_tipoUsuario.Descricao == "")
                throw new Exception("Informe a descrição");

            TipoUsuarioBLL tipoUsuarioBLL = new TipoUsuarioBLL();
            return tipoUsuarioBLL.Inserir(_tipoUsuario);
        }

        public DataTable Buscar(string _filtro)
        {
            TipoUsuarioBLL tipoUsuarioBLL = new TipoUsuarioBLL();
            return tipoUsuarioBLL.Buscar(_filtro);
        }
        public TipoUsuarioBLL Alterar(TipoUsuarioBLL _tipoUsuario)
        {
            TipoUsuarioBLL tipoUsuarioBLL = new TipoUsuarioBLL();
            return tipoUsuarioBLL.Alterar(_tipoUsuario);
        }
        public void Excluir(int _id)
        {
            TipoUsuarioBLL tipoUsuarioBLL = new TipoUsuarioBLL();
            tipoUsuarioBLL.Excluir(_id);
        }
    }
}
