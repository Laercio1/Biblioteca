using Model;
using System;
using System.Data;

namespace BLL
{
    class ReservaBLL
    {
        public Reserva Inserir(Reserva _reserva)
        {
            if (_reserva.CodigoLivro == 0)
                throw new Exception("Informe o livro");

            if (_reserva.CodigoUsuario == 0)
                throw new Exception("Informe o leitor");

            //Validar depois a Data Reserva

            ReservaBLL reservaBLL = new ReservaBLL();
            return reservaBLL.Inserir(_reserva);
        }

        public DataTable Buscar(string _filtro)
        {
            ReservaBLL reservaBLL = new ReservaBLL();
            return reservaBLL.Buscar(_filtro);
        }
        public Reserva Alterar(Reserva reserva)
        {
            ReservaBLL reservaBLL = new ReservaBLL();
            return reservaBLL.Alterar(reserva);
        }
        public void Excluir(int _id)
        {
            ReservaBLL reservaBLL = new ReservaBLL();
            reservaBLL.Excluir(_id);
        }
    }
}
