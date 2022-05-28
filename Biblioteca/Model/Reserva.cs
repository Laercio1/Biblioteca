using System;

namespace Model
{
    public class Reserva
    {
        private int tombo;
        private int codigoUsuario;
        private int codigoFuncionario;
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public int CodigoFuncionario
        {
            get { return codigoFuncionario; }
            set { codigoFuncionario = value; }
        }

        public int CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }

    }
}
