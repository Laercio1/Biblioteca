using Model;
using System.Data;

namespace BLL
{
    class EmprestimoBLL
    {
        public Emprestimo Inserir(Emprestimo _emprestimo)
        {
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
