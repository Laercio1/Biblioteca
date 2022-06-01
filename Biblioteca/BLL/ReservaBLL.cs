using Model;
using System.Data;

namespace BLL
{
    class ReservaBLL
    {
        public Reserva Inserir(Reserva _reserva)
        {
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
