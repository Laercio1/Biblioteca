using Model;
using DAL;
using System.Data;
using System;

namespace BLL
{
    public class UsuarioBLL
    {
        public Usuario Inserir(Usuario _usuario)
        {
            if (_usuario.Nome == "")
                throw new Exception("Informe o nome");

            if (_usuario.Endereco == "")
                throw new Exception("Informe o endereço");

            if (_usuario.Bairro == "")
                throw new Exception("Informe o bairro");

            if (_usuario.CodigoTipoUsuario == 0)
                throw new Exception("informe o tipo usuário");

            if (_usuario.Senha == "")
                throw new Exception("Favor informe uma senha");

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Inserir(_usuario);
        }
        public DataTable Buscar(string _filtro)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Buscar(_filtro);
        }
        public Usuario Alterar(Usuario _usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }
    }
}
