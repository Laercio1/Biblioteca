using Model;
using System;
using System.Data;

namespace BLL
{
    public class LivroBLL
    {
        public Livro Inserir(Livro _livro)
        {
            if (_livro.Isbn == 0)
                throw new Exception("Informe o ISBN.");

            if (_livro.CodigoAutor == 0)
                throw new Exception("Informe o Autor");

            if (_livro.Titulo == "")
                throw new Exception("Informe o Título");

            if (_livro.CodigoEditora == 0)
                throw new Exception("Informe a Editora");

            if (_livro.Tombo == 0)
                throw new Exception("Informe o Tombo");


            LivroBLL livroBLL = new LivroBLL();
            return livroBLL.Inserir(_livro);
        }

        public DataTable Buscar(string _filtro)
        {
            LivroBLL livroBLL = new LivroBLL();
            return livroBLL.Buscar(_filtro);
        }
        public Livro Alterar(Livro _livro)
        {
            LivroBLL livroBLL = new LivroBLL();
            return livroBLL.Alterar(_livro);
        }
        public void Excluir(int _id)
        {
            LivroBLL livroBLL = new LivroBLL();
            livroBLL.Excluir(_id);
        }
    }
}
