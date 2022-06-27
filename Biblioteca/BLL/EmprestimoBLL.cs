using Model;
using System;
using System.Data;

namespace BLL
{
    class EmprestimoBLL
    {
        public Emprestimo Inserir(Emprestimo _emprestimo)
        {
            if (_emprestimo.CodigoLivro == 0)
                throw new Exception("Informe o livro");

            if (_emprestimo.Exemplar == 0)
                throw new Exception("Informe a quantidade");

            if (_emprestimo.CodigoUsuario == 0)
                throw new Exception("Informe o usuário");

            //Validar depois a data Emprestimo e Data Devolução
              

            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            return emprestimoBLL.Inserir(_emprestimo);
        }

        public DataTable Buscar(string _filtro)
        {
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            return emprestimoBLL.Buscar(_filtro);
        }
        public Emprestimo Alterar(Emprestimo _emprestimo)
        {
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            return emprestimoBLL.Alterar(_emprestimo);
        }
        public void Excluir(int _id)
        {
            EmprestimoBLL emprestimoBLL = new EmprestimoBLL();
            emprestimoBLL.Excluir(_id);
        }
    }
}
