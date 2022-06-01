using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class AutorBLL
    {
        public Autor Inserir(Autor _autor)
        {
            AutorBLL autorBLL = new AutorBLL();
            return autorBLL.Inserir(_autor);
        }

        public DataTable Buscar(string _filtro)
        {
            AutorBLL autorBLL = new AutorBLL();
            return autorBLL.Buscar(_filtro);
        }
        public Autor Alterar(Autor _autor)
        {
            AutorBLL autorBLL = new AutorBLL();
            return autorBLL.Alterar(_autor);
        }
        public void Excluir(int _id)
        {
            AutorBLL autorBLL = new AutorBLL();
            autorBLL.Excluir(_id);
        }
    }
}
